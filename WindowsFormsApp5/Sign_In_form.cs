using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Sign_In_form : Form
    {
        public Sign_In_form()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_id.Text == "")
            {
                
                label_error.Visible = true;
                MessageBox.Show("fail","Error");
                //if(label_error = true)
                //{
                //Thread.Sleep(2000);    
                //Sign_In_form sif = new Sign_In_form();
                //sif.Show();
                //}
            }
            //Form1 login = new Form1();
            //login.ShowDialog();
            //this.Close();
            
        }

      
    }
}
