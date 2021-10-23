using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourismManagement
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            ucRoom.Visible = false;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void button_phong_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            label_tieude.Text = btn.Text;
            foreach (Control item in panel_Menu.Controls)
                item.BackColor = panel_Menu.BackColor;
            btn.BackColor = Color.Orange;

            ucRoom.Visible = true;
        }
    }
}
