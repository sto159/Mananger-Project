using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //텍스트박스의 글을 가져와서
            string value = tb_value.Text;
            //버튼을 눌러 추가시키고
            lb_add.Items.Add(value);
            //완료메세지를 띄우고
            //텍스트박스가 지워지고
            tb_value.Text = "";
        }

        private void lb_add_DoubleClick(object sender, EventArgs e)
        {
            string value = (string)lb_add.SelectedItem;
            lb_spare.Items.Add(value);
        }

        private void lb_spare_DoubleClick(object sender, EventArgs e)
        {
            //클릭된lb_spare값과 lb_add에 같은값이 있으면 지우고
            if (lb_add.Items.Contains(lb_spare.SelectedItem))
            {
                int index = lb_add.Items.IndexOf(lb_spare.SelectedItem);
                MessageBox.Show(Convert.ToString(index));
                lb_add.Items.RemoveAt(index);
            }
            else
            {
            //값이 없으면 없음 이라고 메세지 출력
                MessageBox.Show("없음");
            }
        }

        private void btn_erase_Click(object sender, EventArgs e)
        {
            //lb_spare, lb_add를 삭제
            lb_add.Items.Clear();
            lb_spare.Items.Clear();
        }
        
        private void btn_lr_Click(object sender, EventArgs e)
        {
            //lb_add 지목
            int index = lb_add.SelectedIndex;
            //주소값 확인
            lb_spare.Items.Add((string)lb_add.Items[index]);
            lb_add.Items.RemoveAt(index);
            //가져감
        }

        private void btn_rl_Click(object sender, EventArgs e)
        {
            int index = lb_spare.SelectedIndex;
            lb_add.Items.Add(lb_spare.SelectedItem);
            lb_spare.Items.RemoveAt(index);
        }
    }
}
