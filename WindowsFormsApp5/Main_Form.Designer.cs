namespace WindowsFormsApp5
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
            this.btn_si_up = new System.Windows.Forms.Button();
            this.btn_zsi_in = new System.Windows.Forms.Button();
            this.lb_infor = new System.Windows.Forms.ListBox();
            this.lv_infor = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btn_si_up
            // 
            this.btn_si_up.Location = new System.Drawing.Point(12, 28);
            this.btn_si_up.Name = "btn_si_up";
            this.btn_si_up.Size = new System.Drawing.Size(232, 36);
            this.btn_si_up.TabIndex = 0;
            this.btn_si_up.Text = "Sign up";
            this.btn_si_up.UseVisualStyleBackColor = true;
            this.btn_si_up.Click += new System.EventHandler(this.btn_si_up_Click);
            // 
            // btn_zsi_in
            // 
            this.btn_zsi_in.Location = new System.Drawing.Point(304, 28);
            this.btn_zsi_in.Name = "btn_zsi_in";
            this.btn_zsi_in.Size = new System.Drawing.Size(236, 36);
            this.btn_zsi_in.TabIndex = 1;
            this.btn_zsi_in.Text = "Sign in";
            this.btn_zsi_in.UseVisualStyleBackColor = true;
            this.btn_zsi_in.Click += new System.EventHandler(this.btn_si_in_Click);
            // 
            // lb_infor
            // 
            this.lb_infor.FormattingEnabled = true;
            this.lb_infor.ItemHeight = 12;
            this.lb_infor.Location = new System.Drawing.Point(15, 108);
            this.lb_infor.Name = "lb_infor";
            this.lb_infor.Size = new System.Drawing.Size(221, 304);
            this.lb_infor.TabIndex = 2;
            // 
            // lv_infor
            // 
            this.lv_infor.HideSelection = false;
            this.lv_infor.Location = new System.Drawing.Point(304, 108);
            this.lv_infor.Name = "lv_infor";
            this.lv_infor.Size = new System.Drawing.Size(236, 304);
            this.lv_infor.TabIndex = 3;
            this.lv_infor.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 452);
            this.Controls.Add(this.lv_infor);
            this.Controls.Add(this.lb_infor);
            this.Controls.Add(this.btn_zsi_in);
            this.Controls.Add(this.btn_si_up);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_si_up;
        private System.Windows.Forms.Button btn_zsi_in;
        private System.Windows.Forms.ListBox lb_infor;
        private System.Windows.Forms.ListView lv_infor;
    }
}

