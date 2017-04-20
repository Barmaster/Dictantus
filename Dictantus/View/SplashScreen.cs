using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictantus
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

            var timer = new Timer() { Interval = 5000 };
            timer.Tick += new EventHandler(timer_Tick);

            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            var timer = sender as Timer;
            if (timer != null)
            {
                timer.Stop();
            }
            Close();
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Refresh();
            while (Opacity < 1)
            {

                this.Refresh();
                System.Threading.Thread.Sleep(5);
                Opacity += .01d;
            }
        }
    }
}
