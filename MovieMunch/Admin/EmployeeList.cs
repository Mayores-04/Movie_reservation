using MongoDB.Bson;
using MovieMunch.Backend.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MovieMunch.Admin
{
    public partial class EmployeeList : Form
    {
        private readonly EmployeesService _employees;
        public EmployeeList()
        {
            InitializeComponent();
            _employees = new EmployeesService();
            LoadEmployeeInCinemaData();

            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Update",
                Text = "Update",
                UseColumnTextForButtonValue = true,
                Name = "UpdateButton"
            };
            EmployeeListTable.Columns.Add(updateButtonColumn);

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Name = "DeleteButton"
            };
            EmployeeListTable.Columns.Add(deleteButtonColumn);

            DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "View",
                Text = "View Profile",
                UseColumnTextForButtonValue = true,
                Name = "ViewButton"
            };
            EmployeeListTable.Columns.Add(viewButtonColumn);

            EmployeeListTable.CellContentClick += EmployeeListTable_CellContentClick;
        }

        private void ViewProfilePic(string csoonID)
        {
            viewEmployeePanel.Visible = true;
            var csoon = _employees.GetEmployeeById(new ObjectId(csoonID));

            if (csoon != null)
            {
                try
                {
                    viewEmployeeBox.BackgroundImage = Image.FromFile(csoon.employeeProfilePic);
                    viewEmployeeBox.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Movie not found.");
            }
        }


        private void LoadEmployeeInCinemaData()
        {
            List<AdminAccount> employees = _employees.GetEmployees();
            EmployeeListTable.Rows.Clear();

            foreach (var employee in employees)
            {
                EmployeeListTable.Rows.Add(employee.Id, employee.employeeName, employee.employeeEmail, employee.employeePassword, employee.employeeProfilePic);
            }
        }

        private void EmployeeListTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string employeeID = EmployeeListTable.Rows[e.RowIndex].Cells["employeeId"].Value.ToString();

                if (EmployeeListTable.Columns[e.ColumnIndex].Name == "UpdateButton")
                {
                    UpdateEmployee(employeeID);
                }
                else if (EmployeeListTable.Columns[e.ColumnIndex].Name == "DeleteButton")
                {
                    DeleteEmployee(employeeID);
                }
                else if (EmployeeListTable.Columns[e.ColumnIndex].Name == "ViewButton")
                {
                    ViewProfilePic(employeeID);
                }
            }
        }

        private void UpdateEmployee(string movieID)
        {
            if (ObjectId.TryParse(movieID, out var objectId))
            {
                var employee = _employees.GetEmployeeById(objectId);

                if (employee != null)
                {
                    var currentRow = EmployeeListTable.Rows[EmployeeListTable.CurrentCell.RowIndex];
                    employee.employeeName = currentRow.Cells["employeeName"].Value.ToString();
                    employee.employeeEmail = currentRow.Cells["employeeEmail"].Value.ToString();
                    employee.employeePassword = currentRow.Cells["employeePassword"].Value.ToString();
                    employee.employeeProfilePic = currentRow.Cells["employeeProfile"].Value.ToString();

                    _employees.UpdateEmployee(employee);
                    MessageBox.Show("Employee updated successfully.");
                    LoadEmployeeInCinemaData();
                }
                else
                {
                    MessageBox.Show("Employee not found.");
                }
            }
            else
            {
                MessageBox.Show("Invalid ID format.");
            }
        }

        private void DeleteEmployee(string movieID)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this Employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                if (ObjectId.TryParse(movieID, out var objectId))
                {
                    bool isDeleted = _employees.DeleteEmployeeById(objectId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Coming soon movie successfully deleted.");
                        LoadEmployeeInCinemaData();
                    }
                    else
                    {
                        MessageBox.Show("Coming soon movie could not be deleted.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID format.");
                }
            }
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            string employeeName = RemoveSurroundingQuotes(employeeNameInput.Text);
            string employeeEmail = RemoveSurroundingQuotes(employeeEmailInput.Text);
            string employeePassword = RemoveSurroundingQuotes(employeePasswordInput.Text);
            string employeeImagePath = RemoveSurroundingQuotes(employeeImagePathInput.Text);

            if (string.IsNullOrEmpty(employeeName) || string.IsNullOrEmpty(employeeEmail) || string.IsNullOrEmpty(employeePassword) || string.IsNullOrEmpty(employeeImagePath))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Hash the password before storing it
            string hashedPassword = PasswordHelper.HashPassword(employeePassword);

            var newEmployee = new AdminAccount
            {
                employeeName = employeeName,
                employeeEmail = employeeEmail,
                employeePassword = hashedPassword, // Store hashed password
                employeeProfilePic = employeeImagePath
            };

            _employees.AddEmployee(newEmployee);
            MessageBox.Show("Employee saved successfully.");
            LoadEmployeeInCinemaData();
            ClearAdminInput();
        }

        private string RemoveSurroundingQuotes(string input)
        {
            if (!string.IsNullOrEmpty(input) && input.StartsWith("\"") && input.EndsWith("\""))
            {
                return input.Substring(1, input.Length - 2);
            }
            return input;
        }

        private void ClearAdminInput()
        {
            employeeNameInput.Clear();
            employeeEmailInput.Clear();
            employeePasswordInput.Clear();
            employeeImagePathInput.Clear();
        }

        private void closeImageBtn_Click_1(object sender, EventArgs e)
        {
            viewEmployeePanel.Visible = false;
        }

        private void backComingSoonBtn_Click_1(object sender, EventArgs e)
        {
            MainAdmin mainAdminForm = new MainAdmin();
            mainAdminForm.Visible = true;
            this.Close();
        }
    }
}
