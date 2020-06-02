namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_value = new System.Windows.Forms.TextBox();
            this.lb_add = new System.Windows.Forms.ListBox();
            this.lb_spare = new System.Windows.Forms.ListBox();
            this.btn_erase = new System.Windows.Forms.Button();
            this.btn_lr = new System.Windows.Forms.Button();
            this.btn_rl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(196, 61);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "추가하기";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_value
            // 
            this.tb_value.Location = new System.Drawing.Point(45, 61);
            this.tb_value.Name = "tb_value";
            this.tb_value.Size = new System.Drawing.Size(120, 21);
            this.tb_value.TabIndex = 1;
            // 
            // lb_add
            // 
            this.lb_add.FormattingEnabled = true;
            this.lb_add.ItemHeight = 12;
            this.lb_add.Items.AddRange(new object[] {
            "123",
            "1",
            "2",
            "3",
            "a",
            "b",
            "as",
            "1"});
            this.lb_add.Location = new System.Drawing.Point(45, 108);
            this.lb_add.Name = "lb_add";
            this.lb_add.Size = new System.Drawing.Size(120, 148);
            this.lb_add.TabIndex = 2;
            this.lb_add.DoubleClick += new System.EventHandler(this.lb_add_DoubleClick);
            // 
            // lb_spare
            // 
            this.lb_spare.FormattingEnabled = true;
            this.lb_spare.ItemHeight = 12;
            this.lb_spare.Items.AddRange(new object[] {
            "123",
            "1",
            "3",
            "2",
            "b",
            "aa",
            "as",
            "12345"});
            this.lb_spare.Location = new System.Drawing.Point(239, 108);
            this.lb_spare.Name = "lb_spare";
            this.lb_spare.Size = new System.Drawing.Size(120, 148);
            this.lb_spare.TabIndex = 3;
            this.lb_spare.DoubleClick += new System.EventHandler(this.lb_spare_DoubleClick);
            // 
            // btn_erase
            // 
            this.btn_erase.Location = new System.Drawing.Point(163, 265);
            this.btn_erase.Name = "btn_erase";
            this.btn_erase.Size = new System.Drawing.Size(75, 23);
            this.btn_erase.TabIndex = 4;
            this.btn_erase.Text = "전체삭제";
            this.btn_erase.UseVisualStyleBackColor = true;
            this.btn_erase.Click += new System.EventHandler(this.btn_erase_Click);
            // 
            // btn_lr
            // 
            this.btn_lr.Location = new System.Drawing.Point(182, 142);
            this.btn_lr.Name = "btn_lr";
            this.btn_lr.Size = new System.Drawing.Size(38, 19);
            this.btn_lr.TabIndex = 5;
            this.btn_lr.Text = ">>";
            this.btn_lr.UseVisualStyleBackColor = true;
            this.btn_lr.Click += new System.EventHandler(this.btn_lr_Click);
            // 
            // btn_rl
            // 
            this.btn_rl.Location = new System.Drawing.Point(182, 180);
            this.btn_rl.Name = "btn_rl";
            this.btn_rl.Size = new System.Drawing.Size(38, 22);
            this.btn_rl.TabIndex = 6;
            this.btn_rl.Text = "<<";
            this.btn_rl.UseVisualStyleBackColor = true;
            this.btn_rl.Click += new System.EventHandler(this.btn_rl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 300);
            this.Controls.Add(this.btn_rl);
            this.Controls.Add(this.btn_lr);
            this.Controls.Add(this.btn_erase);
            this.Controls.Add(this.lb_spare);
            this.Controls.Add(this.lb_add);
            this.Controls.Add(this.tb_value);
            this.Controls.Add(this.btn_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_value;
        private System.Windows.Forms.ListBox lb_add;
        private System.Windows.Forms.ListBox lb_spare;
        private System.Windows.Forms.Button btn_erase;
        private System.Windows.Forms.Button btn_lr;
        private System.Windows.Forms.Button btn_rl;
    }
}

