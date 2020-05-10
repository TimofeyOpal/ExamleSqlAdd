using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examleSqlAdd
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.PassField.AutoSize = false;
            this.PassField.Size = new Size(this.PassField.Size.Width, 46);
        }

        private void clousButtonClick_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void clousButtonClick_MouseHover(object sender, EventArgs e)
        {
            clousButtonClick.ForeColor = Color.Blue;
        }

        private void clousButtonClick_MouseLeave(object sender, EventArgs e)
        {
            clousButtonClick.ForeColor = Color.White;
        }


        Point lastpoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                Top += e.Y - lastpoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
    }
}
