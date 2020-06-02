namespace WindowsFormsApp5
{
    partial class Sign_up_form
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
            this.label_si_up = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_pw = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.rbtn_male = new System.Windows.Forms.RadioButton();
            this.rbtn_female = new System.Windows.Forms.RadioButton();
            this.label_gen = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label_error = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_si_up
            // 
            this.label_si_up.AutoSize = true;
            this.label_si_up.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_si_up.Location = new System.Drawing.Point(86, 41);
            this.label_si_up.Name = "label_si_up";
            this.label_si_up.Size = new System.Drawing.Size(144, 35);
            this.label_si_up.TabIndex = 0;
            this.label_si_up.Text = "Sign Up";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(32, 112);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(16, 12);
            this.label_id.TabIndex = 1;
            this.label_id.Text = "ID";
            // 
            // label_pw
            // 
            this.label_pw.AutoSize = true;
            this.label_pw.Location = new System.Drawing.Point(32, 146);
            this.label_pw.Name = "label_pw";
            this.label_pw.Size = new System.Drawing.Size(23, 12);
            this.label_pw.TabIndex = 2;
            this.label_pw.Text = "PW";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(32, 182);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(39, 12);
            this.label_Name.TabIndex = 3;
            this.label_Name.Text = "Name";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Location = new System.Drawing.Point(32, 216);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(27, 12);
            this.label_age.TabIndex = 4;
            this.label_age.Text = "Age";
            // 
            // rbtn_male
            // 
            this.rbtn_male.AutoSize = true;
            this.rbtn_male.Location = new System.Drawing.Point(85, 314);
            this.rbtn_male.Name = "rbtn_male";
            this.rbtn_male.Size = new System.Drawing.Size(35, 16);
            this.rbtn_male.TabIndex = 5;
            this.rbtn_male.TabStop = true;
            this.rbtn_male.Text = "남";
            this.rbtn_male.UseVisualStyleBackColor = true;
            // 
            // rbtn_female
            // 
            this.rbtn_female.AutoSize = true;
            this.rbtn_female.Location = new System.Drawing.Point(212, 314);
            this.rbtn_female.Name = "rbtn_female";
            this.rbtn_female.Size = new System.Drawing.Size(35, 16);
            this.rbtn_female.TabIndex = 6;
            this.rbtn_female.TabStop = true;
            this.rbtn_female.Text = "여";
            this.rbtn_female.UseVisualStyleBackColor = true;
            // 
            // label_gen
            // 
            this.label_gen.AutoSize = true;
            this.label_gen.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gen.Location = new System.Drawing.Point(124, 278);
            this.label_gen.Name = "label_gen";
            this.label_gen.Size = new System.Drawing.Size(67, 19);
            this.label_gen.TabIndex = 7;
            this.label_gen.Text = "Gender";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(63, 450);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 8;
            this.btn_confirm.Text = "확인";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(197, 450);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "취소";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(107, 382);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(115, 13);
            this.label_error.TabIndex = 10;
            this.label_error.Text = "모두 기입해주세요";
            this.label_error.Visible = false;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(110, 103);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 21);
            this.tb_id.TabIndex = 11;
            // 
            // tb_pw
            // 
            this.tb_pw.Location = new System.Drawing.Point(110, 137);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.Size = new System.Drawing.Size(100, 21);
            this.tb_pw.TabIndex = 12;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(110, 173);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 21);
            this.tb_name.TabIndex = 13;
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(110, 207);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(100, 21);
            this.tb_age.TabIndex = 14;
            // 
            // Sign_up_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 530);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_pw);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.label_gen);
            this.Controls.Add(this.rbtn_female);
            this.Controls.Add(this.rbtn_male);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_pw);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_si_up);
            this.Name = "Sign_up_form";
            this.Text = "Sign_up_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_si_up;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_pw;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.RadioButton rbtn_male;
        private System.Windows.Forms.RadioButton rbtn_female;
        private System.Windows.Forms.Label label_gen;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_age;
    }
}