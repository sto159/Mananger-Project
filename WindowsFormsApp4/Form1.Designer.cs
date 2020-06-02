namespace WindowsFormsApp4
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
            this.tbb = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lb_data = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbb
            // 
            this.tbb.Location = new System.Drawing.Point(89, 67);
            this.tbb.Name = "tbb";
            this.tbb.Size = new System.Drawing.Size(100, 21);
            this.tbb.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(231, 67);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add DATA";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lb_data
            // 
            this.lb_data.FormattingEnabled = true;
            this.lb_data.ItemHeight = 12;
            this.lb_data.Location = new System.Drawing.Point(89, 118);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(217, 232);
            this.lb_data.TabIndex = 2;
            this.lb_data.DoubleClick += new System.EventHandler(this.lb_data_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 441);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tbb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbb;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox lb_data;
    }
}

