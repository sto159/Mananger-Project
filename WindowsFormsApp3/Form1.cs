using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        string id = "admin";
        string pw = "123123";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //아이템이 추가되고
            string item_id = tb_id.Text;
            string item_pw = tb_pw.Text;
            //기존 아이와 비밀번호와 대조되고
            if(item_id == id && item_pw ==pw)
            {
                MessageBox.Show("검사완료");
            }
            //맞으면 메세지로 로그인 출력
            else
            {
                MessageBox.Show("로그인 실패");
            }
            //틀리면 나가리
        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {
            tb_chk_id.Text = tb_id.Text;
        }

        private void tb_pw_TextChanged(object sender, EventArgs e)
        {
            tb_chk_pw.Text = tb_pw.Text;
        }
    }
}
