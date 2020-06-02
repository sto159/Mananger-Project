using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //아이템을 어느 값에 추가
            string item_tb = tbb.Text;
            //추가된 값을 리스트에 넣고
            lb_data.Items.Add(item_tb);
            //텍스트 박스 값을 지우고
            tbb.Text = "";
            //리스트에 추가된 값을 누르면 텍스트박스에 표시
        }

        private void lb_data_DoubleClick(object sender, EventArgs e)
        {
            string word = lb_data.GetItemText(lb_data.SelectedItem);
            tbb.Text = word;
        }
    }
}
