namespace Inventory_Management_System
{
    partial class RegisterForm
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
            this.registerForm_main_panel = new System.Windows.Forms.Panel();
            this.registerForm_fname_textbox = new System.Windows.Forms.TextBox();
            this.registerForm_fname_label = new System.Windows.Forms.Label();
            this.registerForm_cpassword_textbox = new System.Windows.Forms.TextBox();
            this.registerForm_cpassword_label = new System.Windows.Forms.Label();
            this.registerForm_signIn_linklabel = new System.Windows.Forms.LinkLabel();
            this.register_btn = new System.Windows.Forms.Button();
            this.registerForm_password_textbox = new System.Windows.Forms.TextBox();
            this.registerForm_username_textbox = new System.Windows.Forms.TextBox();
            this.registerForm_password_label = new System.Windows.Forms.Label();
            this.registerForm_username_label = new System.Windows.Forms.Label();
            this.registerForm_subtitle_label = new System.Windows.Forms.Label();
            this.registeForm_title_label = new System.Windows.Forms.Label();
            this.registerForm_main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerForm_main_panel
            // 
            this.registerForm_main_panel.BackColor = System.Drawing.Color.MistyRose;
            this.registerForm_main_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registerForm_main_panel.Controls.Add(this.registerForm_fname_textbox);
            this.registerForm_main_panel.Controls.Add(this.registerForm_fname_label);
            this.registerForm_main_panel.Controls.Add(this.registerForm_cpassword_textbox);
            this.registerForm_main_panel.Controls.Add(this.registerForm_cpassword_label);
            this.registerForm_main_panel.Controls.Add(this.registerForm_signIn_linklabel);
            this.registerForm_main_panel.Controls.Add(this.register_btn);
            this.registerForm_main_panel.Controls.Add(this.registerForm_password_textbox);
            this.registerForm_main_panel.Controls.Add(this.registerForm_username_textbox);
            this.registerForm_main_panel.Controls.Add(this.registerForm_password_label);
            this.registerForm_main_panel.Controls.Add(this.registerForm_username_label);
            this.registerForm_main_panel.Controls.Add(this.registerForm_subtitle_label);
            this.registerForm_main_panel.Controls.Add(this.registeForm_title_label);
            this.registerForm_main_panel.Location = new System.Drawing.Point(422, 93);
            this.registerForm_main_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerForm_main_panel.Name = "registerForm_main_panel";
            this.registerForm_main_panel.Size = new System.Drawing.Size(779, 780);
            this.registerForm_main_panel.TabIndex = 1;
            this.registerForm_main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.registerForm_main_panel_Paint);
            // 
            // registerForm_fname_textbox
            // 
            this.registerForm_fname_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerForm_fname_textbox.Location = new System.Drawing.Point(135, 252);
            this.registerForm_fname_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerForm_fname_textbox.Name = "registerForm_fname_textbox";
            this.registerForm_fname_textbox.Size = new System.Drawing.Size(508, 28);
            this.registerForm_fname_textbox.TabIndex = 3;
            this.registerForm_fname_textbox.TextChanged += new System.EventHandler(this.registerForm_fname_textbox_TextChanged);
            // 
            // registerForm_fname_label
            // 
            this.registerForm_fname_label.AutoSize = true;
            this.registerForm_fname_label.ForeColor = System.Drawing.Color.IndianRed;
            this.registerForm_fname_label.Location = new System.Drawing.Point(135, 219);
            this.registerForm_fname_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerForm_fname_label.Name = "registerForm_fname_label";
            this.registerForm_fname_label.Size = new System.Drawing.Size(80, 20);
            this.registerForm_fname_label.TabIndex = 2;
            this.registerForm_fname_label.Text = "Full Name";
            // 
            // registerForm_cpassword_textbox
            // 
            this.registerForm_cpassword_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerForm_cpassword_textbox.Location = new System.Drawing.Point(135, 585);
            this.registerForm_cpassword_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerForm_cpassword_textbox.Name = "registerForm_cpassword_textbox";
            this.registerForm_cpassword_textbox.Size = new System.Drawing.Size(508, 28);
            this.registerForm_cpassword_textbox.TabIndex = 9;
            // 
            // registerForm_cpassword_label
            // 
            this.registerForm_cpassword_label.AutoSize = true;
            this.registerForm_cpassword_label.ForeColor = System.Drawing.Color.IndianRed;
            this.registerForm_cpassword_label.Location = new System.Drawing.Point(135, 551);
            this.registerForm_cpassword_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerForm_cpassword_label.Name = "registerForm_cpassword_label";
            this.registerForm_cpassword_label.Size = new System.Drawing.Size(145, 20);
            this.registerForm_cpassword_label.TabIndex = 8;
            this.registerForm_cpassword_label.Text = "Re-enter Password";
            // 
            // registerForm_signIn_linklabel
            // 
            this.registerForm_signIn_linklabel.LinkColor = System.Drawing.Color.Brown;
            this.registerForm_signIn_linklabel.Location = new System.Drawing.Point(0, 720);
            this.registerForm_signIn_linklabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerForm_signIn_linklabel.Name = "registerForm_signIn_linklabel";
            this.registerForm_signIn_linklabel.Size = new System.Drawing.Size(777, 31);
            this.registerForm_signIn_linklabel.TabIndex = 11;
            this.registerForm_signIn_linklabel.TabStop = true;
            this.registerForm_signIn_linklabel.Text = "Already have an account? Sign in here.";
            this.registerForm_signIn_linklabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registerForm_signIn_linklabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerForm_signIn_linklabel_LinkClicked);
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.IndianRed;
            this.register_btn.ForeColor = System.Drawing.Color.MistyRose;
            this.register_btn.Location = new System.Drawing.Point(246, 651);
            this.register_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(284, 61);
            this.register_btn.TabIndex = 10;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // registerForm_password_textbox
            // 
            this.registerForm_password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerForm_password_textbox.Location = new System.Drawing.Point(135, 474);
            this.registerForm_password_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerForm_password_textbox.Name = "registerForm_password_textbox";
            this.registerForm_password_textbox.Size = new System.Drawing.Size(508, 28);
            this.registerForm_password_textbox.TabIndex = 7;
            // 
            // registerForm_username_textbox
            // 
            this.registerForm_username_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerForm_username_textbox.Location = new System.Drawing.Point(135, 362);
            this.registerForm_username_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerForm_username_textbox.Name = "registerForm_username_textbox";
            this.registerForm_username_textbox.Size = new System.Drawing.Size(508, 28);
            this.registerForm_username_textbox.TabIndex = 5;
            // 
            // registerForm_password_label
            // 
            this.registerForm_password_label.AutoSize = true;
            this.registerForm_password_label.ForeColor = System.Drawing.Color.IndianRed;
            this.registerForm_password_label.Location = new System.Drawing.Point(135, 440);
            this.registerForm_password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerForm_password_label.Name = "registerForm_password_label";
            this.registerForm_password_label.Size = new System.Drawing.Size(78, 20);
            this.registerForm_password_label.TabIndex = 6;
            this.registerForm_password_label.Text = "Password";
            // 
            // registerForm_username_label
            // 
            this.registerForm_username_label.AutoSize = true;
            this.registerForm_username_label.ForeColor = System.Drawing.Color.IndianRed;
            this.registerForm_username_label.Location = new System.Drawing.Point(135, 329);
            this.registerForm_username_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerForm_username_label.Name = "registerForm_username_label";
            this.registerForm_username_label.Size = new System.Drawing.Size(83, 20);
            this.registerForm_username_label.TabIndex = 4;
            this.registerForm_username_label.Text = "Username";
            // 
            // registerForm_subtitle_label
            // 
            this.registerForm_subtitle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerForm_subtitle_label.ForeColor = System.Drawing.Color.IndianRed;
            this.registerForm_subtitle_label.Location = new System.Drawing.Point(0, 136);
            this.registerForm_subtitle_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerForm_subtitle_label.Name = "registerForm_subtitle_label";
            this.registerForm_subtitle_label.Size = new System.Drawing.Size(777, 31);
            this.registerForm_subtitle_label.TabIndex = 1;
            this.registerForm_subtitle_label.Text = "Create Your Account";
            this.registerForm_subtitle_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registeForm_title_label
            // 
            this.registeForm_title_label.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registeForm_title_label.ForeColor = System.Drawing.Color.IndianRed;
            this.registeForm_title_label.Location = new System.Drawing.Point(0, 76);
            this.registeForm_title_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registeForm_title_label.Name = "registeForm_title_label";
            this.registeForm_title_label.Size = new System.Drawing.Size(777, 38);
            this.registeForm_title_label.TabIndex = 0;
            this.registeForm_title_label.Text = "Inventory Management System";
            this.registeForm_title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 1050);
            this.Controls.Add(this.registerForm_main_panel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegisterForm";
            this.Text = "SANTOSD_INVENTORY MANAGEMENT SYSTEM";
            this.registerForm_main_panel.ResumeLayout(false);
            this.registerForm_main_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel registerForm_main_panel;
        private System.Windows.Forms.LinkLabel registerForm_signIn_linklabel;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.TextBox registerForm_password_textbox;
        private System.Windows.Forms.TextBox registerForm_username_textbox;
        private System.Windows.Forms.Label registerForm_password_label;
        private System.Windows.Forms.Label registerForm_username_label;
        private System.Windows.Forms.Label registerForm_subtitle_label;
        private System.Windows.Forms.Label registeForm_title_label;
        private System.Windows.Forms.TextBox registerForm_fname_textbox;
        private System.Windows.Forms.Label registerForm_fname_label;
        private System.Windows.Forms.TextBox registerForm_cpassword_textbox;
        private System.Windows.Forms.Label registerForm_cpassword_label;
    }
}