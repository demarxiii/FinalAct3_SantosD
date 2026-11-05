using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            registerForm_password_textbox.UseSystemPasswordChar = true;
            registerForm_cpassword_textbox.UseSystemPasswordChar = true;
        }

        private void registerForm_main_panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void registeForm_title_label_Click(object sender, EventArgs e)
        {
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            string fullName = registerForm_fname_textbox.Text.Trim();
            string username = registerForm_username_textbox.Text.Trim();
            string password = registerForm_password_textbox.Text;
            string cpassword = registerForm_cpassword_textbox.Text;

            if (fullName == "" || username == "" || password == "" || cpassword == "")
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != cpassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (OleDbConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = ?";
                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);
                        int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (userCount > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string query = "INSERT INTO Users (Username, PasswordHash, FullName, UserRole, IsActive) VALUES (?, ?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        string passwordHash = PasswordHelper.HashPassword(password);

                       
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@UserRole", "User");
                        cmd.Parameters.AddWithValue("@IsActive", true);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User registered successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                           
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to register user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while registering: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registerForm_signIn_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            this.Close();
        }

        private void registerForm_fname_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}