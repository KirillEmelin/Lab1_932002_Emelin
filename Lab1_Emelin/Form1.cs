using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Emelin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double t, x, y, v0, cosa, sina, S, m, k, vx, vy, dt, a, ymax=0;

        private void EdWeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LblTimeStep_Click(object sender, EventArgs e)
        {

        }

        private void EdHeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LblMaxHeightOutp_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int i =-1;

        const double g = 9.81;
        const double C = 0.15;
        const double rho = 1.29;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            t = t + dt;
            double v = Math.Sqrt((vx * vx + vy * vy));
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;
            x = x + vx * dt;
            y = y + vy * dt;
            if (ymax < y) ymax = y;
            Chart1.Series[i].Points.AddXY(x, y);
            if (y < 0)
            {
                LblDistanceOutp.Text = x.ToString();
                LblMaxHeightOutp.Text = ymax.ToString();
                LblTimeStepOutp.Text = dt.ToString();
                LblSpeedAtTheEndPointOutp.Text = v.ToString();

                Timer1.Stop();
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            y = (double)EdHeight.Value;
            m = (double)EdWeight.Value;
            v0 = (double)EdSpeed.Value;
            a = (double)EdAngle.Value;
            S = (double)EdSize.Value;
            dt = (double)TrackTimeStep.Value/100;
            cosa = Math.Cos(a * Math.PI / 180);
            sina = Math.Sin(a * Math.PI / 180);
            k = 0.5 * C * rho * S / m;
            vx = v0 * cosa;
            vy = v0 * sina;
            t = 0; x = 0;

       
            if (CheckTrajectories.Checked == false || i>4)
            {
                
                i = 0;
                foreach (var series in Chart1.Series)
                {
                    series.Points.Clear();
                }
                Chart1.Series[i].Points.AddXY(x, y);
                Timer1.Start();
            }
            else
            {
   
                i++;
                Chart1.Series[i].Points.AddXY(x, y);
                Timer1.Start();
            }
        }
    }
}
