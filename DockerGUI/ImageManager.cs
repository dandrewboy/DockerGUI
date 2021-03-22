using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockerGUI
{
    public partial class ImageManager : Form
    {
        public ImageManager()
        {
            InitializeComponent();
        }

        private void b_cmMainPage_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            Hide();
        }
    }
}
