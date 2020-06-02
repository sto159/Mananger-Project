namespace WindowsFormsApp5
{
    partial class Sign_In_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_id = new System.Windows.Forms.Label();
            this.label_PW = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(55, 50);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(16, 12);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID";
            // 
            // label_PW
            // 
            this.label_PW.AutoSize = true;
            this.label_PW.Location = new System.Drawing.Point(55, 90);
            this.label_PW.Name = "label_PW";
            this.label_PW.Size = new System.Drawing.Size(23, 12);
            this.label_PW.TabIndex = 1;
            this.label_PW.Text = "PW";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(138, 47);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 21);
            this.tb_id.TabIndex = 2;
            // 
            // tb_pw
            // 
            this.tb_pw.Location = new System.Drawing.Point(138, 81);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.Size = new System.Drawing.Size(100, 21);
            this.tb_pw.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(275, 45);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(68, 57);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(63, 127);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(258, 13);
            this.label_error.TabIndex = 5;
            this.label_error.Text = "로그인 실패. ID, PW 정확히 입력해 주세요.";
            this.label_error.Visible = false;
            // 
            // Sign_In_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 159);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_pw);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label_PW);
            this.Controls.Add(this.label_id);
            this.Name = "Sign_In_form";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_PW;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label_error;
    }
}