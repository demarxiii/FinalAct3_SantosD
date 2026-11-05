using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
            signInForm_password_textbox.UseSystemPasswordChar = true;
        }

        private void signInForm_main_panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void signIn_btn_Click(object sender, EventArgs e)
        {
            string username = signInForm_username_textbox.Text.Trim();
            string password = signInForm_password_textbox.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string fullName;
                string role;
                int userId;

                using (OleDbConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT UserID, PasswordHash, FullName, UserRole, IsActive FROM Users WHERE Username = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            string storedHash = reader["PasswordHash"].ToString();
                            fullName = reader["FullName"].ToString();
                            role = reader["UserRole"].ToString();
                            bool isActive = Convert.ToBoolean(reader["IsActive"]);
                            userId = Convert.ToInt32(reader["UserID"]);

                            if (!PasswordHelper.VerifyPassword(password, storedHash))
                            {
                                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            if (!isActive)
                            {
                                MessageBox.Show("Your account is inactive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }

                MessageBox.Show($"Welcome, {fullName}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                signInForm_password_textbox.Clear();

                DashboardForm dashboard = new DashboardForm();

                dashboard.FormClosed += (s, args) => this.Close();
                dashboard.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while signing in: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signInForm_register_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.FormClosed += (s, args) => this.Show();
            register.Show();
            this.Hide();
        }

        private void signInForm_title_label_Click(object sender, EventArgs e)
        {

        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }
    }
}