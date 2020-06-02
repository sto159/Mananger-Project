using System;
using System.Windows.Forms;
using WindowsFormsApp5.domain;

namespace WindowsFormsApp5
{
    public partial class Sign_up_form : Form
    {
        public Sign_up_form()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
