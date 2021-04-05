using DockerGUI.Service;
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
        PowerShellService pss = new PowerShellService();
        public ImageManager(string imgName, string imgPort, string imgPassword, string ide)
        {
            InitializeComponent();
            dgv_ImageList.Rows.Add(""+imgName+"", ""+ide+"", ""+imgPort+"", ""+imgPassword+"");
        }

        private void b_cmMainPage_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            Hide();
        }

        private void ImageManager_Load(object sender, EventArgs e)
        {
           
        }

        private void b_DeleteContainer_Click(object sender, EventArgs e)
        {
            if (this.dgv_ImageList.SelectedRows.Count > 0)
            {
                dgv_ImageList.Rows.RemoveAt(this.dgv_ImageList.SelectedRows[0].Index);
                pss.removeImage((string)dgv_ImageList.SelectedRows[0].Cells[0].Value);
            }
        }
    }
}
