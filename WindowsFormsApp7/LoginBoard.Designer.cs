namespace WindowsFormsApp7
{
    partial class FormLogin
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
            this.labelUpmost = new System.Windows.Forms.Label();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUpmost
            // 
            this.labelUpmost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUpmost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpmost.Location = new System.Drawing.Point(0, 0);
            this.labelUpmost.Name = "labelUpmost";
            this.labelUpmost.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.labelUpmost.Size = new System.Drawing.Size(493, 315);
            this.labelUpmost.TabIndex = 0;
            this.labelUpmost.Text = "Đăng nhập";
            this.labelUpmost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelUpmost.Click += new System.EventHandler(this.labelUpmost_Click);
            // 
            // UsernameInput
            // 
            this.UsernameInput.ForeColor = System.Drawing.Color.Gray;
            this.UsernameInput.Location = new System.Drawing.Point(159, 99);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(169, 20);
            this.UsernameInput.TabIndex = 1;
            this.UsernameInput.Text = "Tên đăng nhập";
            this.UsernameInput.Enter += new System.EventHandler(this.UsernameInput_Enter);
            this.UsernameInput.Leave += new System.EventHandler(this.UsernameInput_Leave);
            // 
            // PasswordInput
            // 
            this.PasswordInput.ForeColor = System.Drawing.Color.Gray;
            this.PasswordInput.Location = new System.Drawing.Point(159, 142);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(169, 20);
            this.PasswordInput.TabIndex = 2;
            this.PasswordInput.Text = "Mật khẩu";
            this.PasswordInput.Enter += new System.EventHandler(this.PasswordInput_Enter);
            this.PasswordInput.Leave += new System.EventHandler(this.PasswordInput_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(150, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 315);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.labelUpmost);
            this.Name = "FormLogin";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUpmost;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Button button1;
    }
}

