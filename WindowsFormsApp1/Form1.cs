using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        
        string id = "admin";
        string pw = "0000";
        private void btn_login_Click(object sender, EventArgs e)
        {
            string idtext = tb_id.Text;
            string pwtext = tb_pw.Text;
            

            //입력된 아이디 비번과 일치하는지 비교
            if (id == idtext && pw == pwtext)
            {
            //맞으면 로그인 메시지 출력
                MessageBox.Show("로그인");
            }
            else
            {
            //아니면 틀렸다고 출력
                MessageBox.Show("로그인 실패");
            }

        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {
            tb_idc.Text = tb_id.Text;            
        }

        private void tb_pw_TextChanged(object sender, EventArgs e)
        {
            tb_pwc.Text = tb_pw.Text;
        }
    }
}
