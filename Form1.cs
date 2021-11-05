using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fractal
{
    public partial class MainForm : Form
    {
        Mondelbrot mondelbrot;
        private Point initialPoint;
        private bool EventHandlerEnabled = true;
        private const decimal x0 = -2, y0 = -2, size = 4;

        public void DrawFrac()
        {
            Cursor.Current = Cursors.WaitCursor;
            UseWaitCursor = true;
            mondelbrot = new Mondelbrot(PB.ClientSize, (int)udIter.Value, (double)udX.Value, (double)udY.Value, (double)udSize.Value);
            PB.Invalidate();
            UseWaitCursor = false;
            Cursor.Current = Cursors.Default;
        }

        private void ResetValues()
        {
            udX.Value = x0;
            udY.Value = y0;
            udSize.Value = size;
        }

        public MainForm()
        {
            InitializeComponent();
            cbZoom.SelectedIndex = 0;
            DrawFrac();
        }

        private void btDraw_Click(object sender, EventArgs e)
        {
            DrawFrac();
        }

        private void PB_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(mondelbrot.bmp, 0, 0);
        }

        private void PB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int zoom = Int32.Parse(cbZoom.SelectedItem.ToString());
            Zoom(e.Location, zoom);
        }

        private void SetUd(NumericUpDown ud, decimal value)
        {
            if (ud.Minimum > value)
                ud.Value = ud.Minimum;
            else 
            if (ud.Maximum < value)
                ud.Value = ud.Maximum;
            else
                ud.Value = value;
        }

        private void Zoom(Point p, decimal scale)
        {
            EventHandlerEnabled = false;
            decimal x_centr = udSize.Value / PB.ClientSize.Width * p.X + udX.Value;
            decimal y_centr = udSize.Value / PB.ClientSize.Height * p.Y + udY.Value;

            if (rbPlus.Checked)
                SetUd(udSize, udSize.Value / scale);
            else
                SetUd(udSize, udSize.Value * scale);

            SetUd(udX, x_centr - udSize.Value / 2);
            SetUd(udY, y_centr - udSize.Value / 2);
            EventHandlerEnabled = true;

            DrawFrac();
        }

        private void udIter_ValueChanged(object sender, EventArgs e)
        {
            if(EventHandlerEnabled)
                DrawFrac();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void PB_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button ==MouseButtons.Left)
                initialPoint = e.Location;
        }

        private void PB_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                EventHandlerEnabled = false;
                int deltaX = initialPoint.X - e.X;
                int deltaY = initialPoint.Y - e.Y;
                SetUd(udX, udSize.Value / PB.ClientSize.Width * deltaX + udX.Value);
                SetUd(udY, udSize.Value / PB.ClientSize.Height * deltaY + udY.Value);
                EventHandlerEnabled = true;
                DrawFrac();
            }
        }

        private void PB_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = PB.CreateGraphics();
                g.Clear(PB.BackColor);
                g.DrawImage(mondelbrot.bmp, e.X - initialPoint.X, e.Y - initialPoint.Y);
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            int W = this.Width - 220;
            int H = this.Height - 40;
            int size = W > H ? H : W;
            PB.Width = size;
            PB.Height = size;
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            DrawFrac();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            udIter.Value++;
        }

        private void btSaveImg_Click(object sender, EventArgs e)
        {
            if (sfdPic.ShowDialog() == DialogResult.OK)
            {
                switch (sfdPic.FilterIndex)
                {
                    case 1:
                        mondelbrot.bmp.Save(sfdPic.FileName, ImageFormat.Png);
                        break;
                    case 2:
                        mondelbrot.bmp.Save(sfdPic.FileName, ImageFormat.Bmp);
                        break;
                    default:
                        mondelbrot.bmp.Save(sfdPic.FileName, ImageFormat.Jpeg);
                        break;
                }
            }
        }

        private void btLoadBin_Click(object sender, EventArgs e)
        {
            if (ofdCoord.ShowDialog() == DialogResult.OK)
            {
                BinaryReader br = new BinaryReader(File.Open(ofdCoord.FileName, FileMode.Open));
                SetUd(udX, br.ReadDecimal());
                SetUd(udY, br.ReadDecimal());
                SetUd(udSize, br.ReadDecimal());
                SetUd(udIter, br.ReadDecimal());
                br.Dispose();
                DrawFrac();
            }
        }

        private void btSaveTxt_Click(object sender, EventArgs e)
        {
            if (sfdCoordTxt.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfdCoordTxt.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(udX.Value.ToString());
                sw.WriteLine(udY.Value.ToString());
                sw.WriteLine(udSize.Value.ToString());
                sw.WriteLine(udIter.Value.ToString());
                sw.Dispose();
            }
        }

        private void btLoadTxt_Click(object sender, EventArgs e)
        {
            if (ofdCoordTxt.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofdCoordTxt.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                SetUd(udX, Convert.ToDecimal(sr.ReadLine()));
                SetUd(udY, Convert.ToDecimal(sr.ReadLine()));
                SetUd(udSize, Convert.ToDecimal(sr.ReadLine()));
                SetUd(udIter, Convert.ToDecimal(sr.ReadLine()));
                sr.Dispose();
                DrawFrac();
            }
                
        }

        private void btSaveBin_Click(object sender, EventArgs e)
        {
            if (sfdCoord.ShowDialog() == DialogResult.OK)
            {
                BinaryWriter bw = new BinaryWriter(File.Open(sfdCoord.FileName, FileMode.Create));
                bw.Write(udX.Value);
                bw.Write(udY.Value);
                bw.Write(udSize.Value);
                bw.Write(udIter.Value);
                bw.Dispose();
            }
        }

        private void btTimer_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
            if (btTimer.Text == "Старт")
                btTimer.Text = "Стоп";
            else
                btTimer.Text = "Старт";
        }
    }
}
