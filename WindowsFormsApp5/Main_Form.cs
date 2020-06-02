using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_si_up_Click(object sender, EventArgs e)
        {
            Sign_up_form  su_page = new Sign_up_form();
            su_page.ShowDialog();
        }

        private void btn_si_in_Click(object sender, EventArgs e)
        {
            Sign_In_form si_page = new Sign_In_form();
            si_page.ShowDialog();
        }
        

        /*private void lv_infor(object sender, LayoutEventArgs e)
        {
           
            this.View = View.Details;
            lv_infor.GridLines = true;

            lv_infor.Columns.Add("ID", 15);
        }*/
    }
}
