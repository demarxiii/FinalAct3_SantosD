namespace Inventory_Management_System
{
    partial class DashboardForm
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

    
        private void InitializeComponent()
        {
            this.dashboard_welcome_label = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dashboard_welcome_label
            // 
            this.dashboard_welcome_label.AutoSize = true;
            this.dashboard_welcome_label.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_welcome_label.ForeColor = System.Drawing.Color.IndianRed;
            this.dashboard_welcome_label.Location = new System.Drawing.Point(134, 88);
            this.dashboard_welcome_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dashboard_welcome_label.Name = "dashboard_welcome_label";
            this.dashboard_welcome_label.Size = new System.Drawing.Size(149, 39);
            this.dashboard_welcome_label.TabIndex = 0;
            this.dashboard_welcome_label.Text = "Welcome!";
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.IndianRed;
            this.logout_btn.ForeColor = System.Drawing.Color.MistyRose;
            this.logout_btn.Location = new System.Drawing.Point(165, 210);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(140, 51);
            this.logout_btn.TabIndex = 1;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 1050);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.dashboard_welcome_label);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DashboardForm";
            this.Text = "S";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dashboard_welcome_label;
        private System.Windows.Forms.Button logout_btn;
    }
}