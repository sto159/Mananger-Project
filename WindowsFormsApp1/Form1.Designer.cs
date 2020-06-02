namespace WindowsFormsApp1
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
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.tb_idc = new System.Windows.Forms.TextBox();
            this.tb_pwc = new System.Windows.Forms.TextBox();
            this.id_lab = new System.Windows.Forms.Label();
            this.pw_lab = new System.Windows.Forms.Label();
            this.idcon_lab = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(481, 101);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(147, 61);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_id
            // 
            this.tb_id.AcceptsReturn = true;
            this.tb_id.Location = new System.Drawing.Point(246, 89);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 21);
            this.tb_id.TabIndex = 1;
            this.tb_id.TextChanged += new System.EventHandler(this.tb_id_TextChanged);
            // 
            // tb_pw
            // 
            this.tb_pw.Location = new System.Drawing.Point(246, 147);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.Size = new System.Drawing.Size(100, 21);
            this.tb_pw.TabIndex = 2;
            this.tb_pw.TextChanged += new System.EventHandler(this.tb_pw_TextChanged);
            // 
            // tb_idc
            // 
            this.tb_idc.Location = new System.Drawing.Point(246, 270);
            this.tb_idc.Name = "tb_idc";
            this.tb_idc.Size = new System.Drawing.Size(100, 21);
            this.tb_idc.TabIndex = 3;
            // 
            // tb_pwc
            // 
            this.tb_pwc.Location = new System.Drawing.Point(246, 327);
            this.tb_pwc.Name = "tb_pwc";
            this.tb_pwc.Size = new System.Drawing.Size(100, 21);
            this.tb_pwc.TabIndex = 4;
            // 
            // id_lab
            // 
            this.id_lab.AutoSize = true;
            this.id_lab.Location = new System.Drawing.Point(135, 92);
            this.id_lab.Name = "id_lab";
            this.id_lab.Size = new System.Drawing.Size(16, 12);
            this.id_lab.TabIndex = 5;
            this.id_lab.Text = "ID";
            // 
            // pw_lab
            // 
            this.pw_lab.AutoSize = true;
            this.pw_lab.Location = new System.Drawing.Point(135, 150);
            this.pw_lab.Name = "pw_lab";
            this.pw_lab.Size = new System.Drawing.Size(62, 12);
            this.pw_lab.TabIndex = 6;
            this.pw_lab.Text = "Password";
            // 
            // idcon_lab
            // 
            this.idcon_lab.AutoSize = true;
            this.idcon_lab.Location = new System.Drawing.Point(135, 273);
            this.idcon_lab.Name = "idcon_lab";
            this.idcon_lab.Size = new System.Drawing.Size(64, 12);
            this.idcon_lab.TabIndex = 7;
            this.idcon_lab.Text = "ID Confirm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "PW Confirm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idcon_lab);
            this.Controls.Add(this.pw_lab);
            this.Controls.Add(this.id_lab);
            this.Controls.Add(this.tb_pwc);
            this.Controls.Add(this.tb_idc);
            this.Controls.Add(this.tb_pw);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.btn_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.TextBox tb_idc;
        private System.Windows.Forms.TextBox tb_pwc;
        private System.Windows.Forms.Label id_lab;
        private System.Windows.Forms.Label pw_lab;
        private System.Windows.Forms.Label idcon_lab;
        private System.Windows.Forms.Label label4;
    }
}

