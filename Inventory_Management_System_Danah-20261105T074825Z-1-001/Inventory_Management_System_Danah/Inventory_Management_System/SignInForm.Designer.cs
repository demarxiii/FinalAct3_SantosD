namespace Inventory_Management_System
{
    partial class SignInForm
    {
       
        private System.ComponentModel.IContainer components = null;


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
            this.signInForm_main_panel = new System.Windows.Forms.Panel();
            this.signInForm_register_linklabel = new System.Windows.Forms.LinkLabel();
            this.signIn_btn = new System.Windows.Forms.Button();
            this.signInForm_password_textbox = new System.Windows.Forms.TextBox();
            this.signInForm_username_textbox = new System.Windows.Forms.TextBox();
            this.signInForm_password_label = new System.Windows.Forms.Label();
            this.signInForm_username_label = new System.Windows.Forms.Label();
            this.signInForm_subtitle_label = new System.Windows.Forms.Label();
            this.signInForm_title_label = new System.Windows.Forms.Label();
            this.signInForm_main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // signInForm_main_panel
            // 
            this.signInForm_main_panel.BackColor = System.Drawing.Color.MistyRose;
            this.signInForm_main_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signInForm_main_panel.Controls.Add(this.signInForm_register_linklabel);
            this.signInForm_main_panel.Controls.Add(this.signIn_btn);
            this.signInForm_main_panel.Controls.Add(this.signInForm_password_textbox);
            this.signInForm_main_panel.Controls.Add(this.signInForm_username_textbox);
            this.signInForm_main_panel.Controls.Add(this.signInForm_password_label);
            this.signInForm_main_panel.Controls.Add(this.signInForm_username_label);
            this.signInForm_main_panel.Controls.Add(this.signInForm_subtitle_label);
            this.signInForm_main_panel.Controls.Add(this.signInForm_title_label);
            this.signInForm_main_panel.Location = new System.Drawing.Point(441, 172);
            this.signInForm_main_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signInForm_main_panel.Name = "signInForm_main_panel";
            this.signInForm_main_panel.Size = new System.Drawing.Size(779, 707);
            this.signInForm_main_panel.TabIndex = 0;
            // 
            // signInForm_register_linklabel
            // 
            this.signInForm_register_linklabel.LinkColor = System.Drawing.Color.Brown;
            this.signInForm_register_linklabel.Location = new System.Drawing.Point(0, 600);
            this.signInForm_register_linklabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signInForm_register_linklabel.Name = "signInForm_register_linklabel";
            this.signInForm_register_linklabel.Size = new System.Drawing.Size(777, 31);
            this.signInForm_register_linklabel.TabIndex = 7;
            this.signInForm_register_linklabel.TabStop = true;
            this.signInForm_register_linklabel.Text = "Don\'t have an account? Register here.";
            this.signInForm_register_linklabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signInForm_register_linklabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signInForm_register_linklabel_LinkClicked);
            // 
            // signIn_btn
            // 
            this.signIn_btn.BackColor = System.Drawing.Color.IndianRed;
            this.signIn_btn.ForeColor = System.Drawing.Color.White;
            this.signIn_btn.Location = new System.Drawing.Point(258, 501);
            this.signIn_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signIn_btn.Name = "signIn_btn";
            this.signIn_btn.Size = new System.Drawing.Size(254, 61);
            this.signIn_btn.TabIndex = 6;
            this.signIn_btn.Text = "Sign In";
            this.signIn_btn.UseVisualStyleBackColor = false;
            this.signIn_btn.Click += new System.EventHandler(this.signIn_btn_Click);
            // 
            // signInForm_password_textbox
            // 
            this.signInForm_password_textbox.BackColor = System.Drawing.SystemColors.Info;
            this.signInForm_password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInForm_password_textbox.Location = new System.Drawing.Point(135, 400);
            this.signInForm_password_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signInForm_password_textbox.Name = "signInForm_password_textbox";
            this.signInForm_password_textbox.Size = new System.Drawing.Size(508, 28);
            this.signInForm_password_textbox.TabIndex = 5;
            // 
            // signInForm_username_textbox
            // 
            this.signInForm_username_textbox.BackColor = System.Drawing.SystemColors.Info;
            this.signInForm_username_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInForm_username_textbox.Location = new System.Drawing.Point(135, 286);
            this.signInForm_username_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signInForm_username_textbox.Name = "signInForm_username_textbox";
            this.signInForm_username_textbox.Size = new System.Drawing.Size(508, 28);
            this.signInForm_username_textbox.TabIndex = 4;
            // 
            // signInForm_password_label
            // 
            this.signInForm_password_label.AutoSize = true;
            this.signInForm_password_label.ForeColor = System.Drawing.Color.IndianRed;
            this.signInForm_password_label.Location = new System.Drawing.Point(135, 366);
            this.signInForm_password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signInForm_password_label.Name = "signInForm_password_label";
            this.signInForm_password_label.Size = new System.Drawing.Size(78, 20);
            this.signInForm_password_label.TabIndex = 3;
            this.signInForm_password_label.Text = "Password";
            // 
            // signInForm_username_label
            // 
            this.signInForm_username_label.AutoSize = true;
            this.signInForm_username_label.ForeColor = System.Drawing.Color.IndianRed;
            this.signInForm_username_label.Location = new System.Drawing.Point(135, 252);
            this.signInForm_username_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signInForm_username_label.Name = "signInForm_username_label";
            this.signInForm_username_label.Size = new System.Drawing.Size(83, 20);
            this.signInForm_username_label.TabIndex = 2;
            this.signInForm_username_label.Text = "Username";
            // 
            // signInForm_subtitle_label
            // 
            this.signInForm_subtitle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInForm_subtitle_label.ForeColor = System.Drawing.Color.IndianRed;
            this.signInForm_subtitle_label.Location = new System.Drawing.Point(0, 155);
            this.signInForm_subtitle_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signInForm_subtitle_label.Name = "signInForm_subtitle_label";
            this.signInForm_subtitle_label.Size = new System.Drawing.Size(777, 31);
            this.signInForm_subtitle_label.TabIndex = 1;
            this.signInForm_subtitle_label.Text = "Sign in to your Account";
            this.signInForm_subtitle_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signInForm_title_label
            // 
            this.signInForm_title_label.BackColor = System.Drawing.Color.Transparent;
            this.signInForm_title_label.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInForm_title_label.ForeColor = System.Drawing.Color.IndianRed;
            this.signInForm_title_label.Location = new System.Drawing.Point(0, 98);
            this.signInForm_title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signInForm_title_label.Name = "signInForm_title_label";
            this.signInForm_title_label.Size = new System.Drawing.Size(777, 49);
            this.signInForm_title_label.TabIndex = 0;
            this.signInForm_title_label.Text = "Inventory Management System";
            this.signInForm_title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signInForm_title_label.Click += new System.EventHandler(this.signInForm_title_label_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 1050);
            this.Controls.Add(this.signInForm_main_panel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SignInForm";
            this.Text = "SANTOSD_INVENTORY MANAGEMENT SYSTEM";
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.signInForm_main_panel.ResumeLayout(false);
            this.signInForm_main_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel signInForm_main_panel;
        private System.Windows.Forms.Label signInForm_title_label;
        private System.Windows.Forms.Label signInForm_password_label;
        private System.Windows.Forms.Label signInForm_username_label;
        private System.Windows.Forms.Label signInForm_subtitle_label;
        private System.Windows.Forms.TextBox signInForm_username_textbox;
        private System.Windows.Forms.LinkLabel signInForm_register_linklabel;
        private System.Windows.Forms.Button signIn_btn;
        private System.Windows.Forms.TextBox signInForm_password_textbox;
    }
}