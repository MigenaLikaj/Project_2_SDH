namespace Client
{
    partial class Login
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
            this.lblUsernameL = new System.Windows.Forms.Label();
            this.lblPasswordL = new System.Windows.Forms.Label();
            this.txtUsernameL = new System.Windows.Forms.TextBox();
            this.txtPasswordL = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsernameL
            // 
            this.lblUsernameL.AutoSize = true;
            this.lblUsernameL.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameL.Location = new System.Drawing.Point(91, 289);
            this.lblUsernameL.Name = "lblUsernameL";
            this.lblUsernameL.Size = new System.Drawing.Size(106, 25);
            this.lblUsernameL.TabIndex = 1;
            this.lblUsernameL.Text = "Username:";
            // 
            // lblPasswordL
            // 
            this.lblPasswordL.AutoSize = true;
            this.lblPasswordL.Font = new System.Drawing.Font("Arial Unicode MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordL.Location = new System.Drawing.Point(94, 342);
            this.lblPasswordL.Name = "lblPasswordL";
            this.lblPasswordL.Size = new System.Drawing.Size(103, 25);
            this.lblPasswordL.TabIndex = 2;
            this.lblPasswordL.Text = "Password:";
            // 
            // txtUsernameL
            // 
            this.txtUsernameL.Location = new System.Drawing.Point(203, 292);
            this.txtUsernameL.Name = "txtUsernameL";
            this.txtUsernameL.Size = new System.Drawing.Size(236, 22);
            this.txtUsernameL.TabIndex = 3;
            // 
            // txtPasswordL
            // 
            this.txtPasswordL.Location = new System.Drawing.Point(203, 342);
            this.txtPasswordL.Name = "txtPasswordL";
            this.txtPasswordL.Size = new System.Drawing.Size(236, 22);
            this.txtPasswordL.TabIndex = 4;
            this.txtPasswordL.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogin.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(243, 396);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(137, 59);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Client.Properties.Resources.Rating;
            this.pictureBox1.Location = new System.Drawing.Point(122, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Azure;
            this.btnSignUp.Font = new System.Drawing.Font("Arial Unicode MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.Blue;
            this.btnSignUp.Location = new System.Drawing.Point(486, 541);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(120, 27);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(618, 580);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPasswordL);
            this.Controls.Add(this.txtUsernameL);
            this.Controls.Add(this.lblPasswordL);
            this.Controls.Add(this.lblUsernameL);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsernameL;
        private System.Windows.Forms.Label lblPasswordL;
        private System.Windows.Forms.TextBox txtUsernameL;
        private System.Windows.Forms.TextBox txtPasswordL;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
    }
}