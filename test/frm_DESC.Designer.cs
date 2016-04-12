namespace test
{
    partial class frm_DESC
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
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.txt_Decrypt = new System.Windows.Forms.TextBox();
            this.txt_Enctry = new System.Windows.Forms.TextBox();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_MD5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(415, 188);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Encrypt.TabIndex = 0;
            this.btn_Encrypt.Text = "加   密";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // txt_Decrypt
            // 
            this.txt_Decrypt.Location = new System.Drawing.Point(603, 69);
            this.txt_Decrypt.Multiline = true;
            this.txt_Decrypt.Name = "txt_Decrypt";
            this.txt_Decrypt.Size = new System.Drawing.Size(362, 91);
            this.txt_Decrypt.TabIndex = 1;
            // 
            // txt_Enctry
            // 
            this.txt_Enctry.Location = new System.Drawing.Point(282, 69);
            this.txt_Enctry.Multiline = true;
            this.txt_Enctry.Name = "txt_Enctry";
            this.txt_Enctry.Size = new System.Drawing.Size(249, 91);
            this.txt_Enctry.TabIndex = 2;
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(811, 188);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Decrypt.TabIndex = 3;
            this.btn_Decrypt.Text = "解  密";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(279, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "明文密码 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(600, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "密 文";
            // 
            // btn_MD5
            // 
            this.btn_MD5.Location = new System.Drawing.Point(101, 188);
            this.btn_MD5.Name = "btn_MD5";
            this.btn_MD5.Size = new System.Drawing.Size(75, 23);
            this.btn_MD5.TabIndex = 6;
            this.btn_MD5.Text = "MD5加密";
            this.btn_MD5.UseVisualStyleBackColor = true;
            this.btn_MD5.Click += new System.EventHandler(this.btn_MD5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(18, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "账  号";
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(12, 69);
            this.txt_Number.Multiline = true;
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(249, 91);
            this.txt_Number.TabIndex = 7;
            // 
            // frm_DESC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 343);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Number);
            this.Controls.Add(this.btn_MD5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.txt_Enctry);
            this.Controls.Add(this.txt_Decrypt);
            this.Controls.Add(this.btn_Encrypt);
            this.Name = "frm_DESC";
            this.Text = "DESC加密解密";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.TextBox txt_Decrypt;
        private System.Windows.Forms.TextBox txt_Enctry;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_MD5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Number;
    }
}

