
namespace ChildrenControl
{
    partial class DangNhap
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
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTaoTK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.Location = new System.Drawing.Point(289, 141);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(232, 20);
            this.textBoxMatKhau.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập mật khẩu";
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangNhap.Location = new System.Drawing.Point(356, 181);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(85, 31);
            this.buttonDangNhap.TabIndex = 4;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = true;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đăng nhập";
            // 
            // buttonTaoTK
            // 
            this.buttonTaoTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaoTK.Location = new System.Drawing.Point(340, 267);
            this.buttonTaoTK.Name = "buttonTaoTK";
            this.buttonTaoTK.Size = new System.Drawing.Size(124, 33);
            this.buttonTaoTK.TabIndex = 6;
            this.buttonTaoTK.Text = "Tạo tài khoản";
            this.buttonTaoTK.UseVisualStyleBackColor = true;
            this.buttonTaoTK.Click += new System.EventHandler(this.buttonTaoTK_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTaoTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDangNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMatKhau);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTaoTK;
    }
}

