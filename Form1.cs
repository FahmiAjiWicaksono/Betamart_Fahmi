using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BetaMartFahmi.Properties;

namespace BetamartFahmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void shwfrm( Form frm)
        { 
            frm.ShowDialog();
        }

        public void enable_menu()
        {
            tambahproduk.Enabled = true;
            tsListofProducts.Enabled = true;
            tsLogin.Text = "Logout";
            
            tsUser.Enabled = true;

        }

        private void disable_menu()
        {
            tambahproduk.Enabled = false;
            tsListofProducts.Enabled = false;
            tsLogin.Text = "Login";
            
            tsUser.Enabled = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            disable_menu();
        }

        private void tambahproduk_Click(object sender, EventArgs e)
        {
            shwfrm(new frmProduct());
        }

        private void tsListofProducts_Click(object sender, EventArgs e)
        {
            shwfrm(new frmListofProducts());
        }


        private void tsUser_Click(object sender, EventArgs e)
        {
            shwfrm(new frmUser());
        }


        private void tsLogin_Click(object sender, EventArgs e)
        {
            if(tsLogin.Text == "Login")
            {
                shwfrm(new frmLogin(this));
            }
            else
            {
                disable_menu();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
