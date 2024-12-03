using MongoDB.Bson;
using MovieMunch.Admin.FilmsInCinema;
using MovieMunch.Backend.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MovieMunch.Admin
{
    public partial class EmployeesManagementForm : Form
    {

        private EmployeesService _employees;
        public EmployeesManagementForm(string userName, string profilePic)
        {
            _userName = userName;
            _profilePic = profilePic;
            MainAdmin mainAdmin = new MainAdmin();
            mainAdmin.SetUserNamme(userName, profilePic);
            InitializeComponent();
            _employees = new EmployeesService();
            LoadEmployeeInCinemaData();
            formOptionsPanel.BringToFront();

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
            EmployeeListTable.CellPainting += MoviesToShowTable_CellPainting;
        }

        private void MoviesToShowTable_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == EmployeeListTable.Columns["UpdateButton"].Index ||
                                    e.ColumnIndex == EmployeeListTable.Columns["DeleteButton"].Index ||
                                    e.ColumnIndex == EmployeeListTable.Columns["ViewButton"].Index))
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);

                Color buttonColor = Color.Transparent;
                Color borderColor = Color.Black;
                if (e.ColumnIndex == EmployeeListTable.Columns["UpdateButton"].Index)
                {
                    buttonColor = Color.LightBlue;
                    borderColor = Color.DarkBlue;
                }
                else if (e.ColumnIndex == EmployeeListTable.Columns["DeleteButton"].Index)
                {
                    buttonColor = Color.IndianRed;
                    borderColor = Color.DarkRed;
                }
                else if (e.ColumnIndex == EmployeeListTable.Columns["ViewButton"].Index)
                {
                    buttonColor = Color.LightGreen;
                    borderColor = Color.DarkGreen;
                }

                Rectangle rect = new Rectangle(e.CellBounds.X + 2, e.CellBounds.Y + 2, e.CellBounds.Width - 4, e.CellBounds.Height - 4);
                GraphicsPath path = new GraphicsPath();
                path.AddArc(rect.X, rect.Y, 10, 10, 180, 90);
                path.AddArc(rect.Right - 10, rect.Y, 10, 10, 270, 90);
                path.AddArc(rect.Right - 10, rect.Bottom - 10, 10, 10, 0, 90);
                path.AddArc(rect.X, rect.Bottom - 10, 10, 10, 90, 90);
                path.CloseFigure();

                using (Brush brush = new SolidBrush(buttonColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                using (Pen pen = new Pen(borderColor, 2))
                {
                    e.Graphics.DrawPath(pen, path);
                }

                TextRenderer.DrawText(
                    e.Graphics,
                    (string)e.FormattedValue,
                    e.CellStyle.Font,
                    rect,
                    e.CellStyle.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );

                e.Handled = true;
            }
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

        private void addEmployeeBtn_Click_1(object sender, EventArgs e)
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

            string hashedPassword = PasswordHelper.HashPassword(employeePassword);

            var newEmployee = new AdminAccount
            {
                employeeName = employeeName,
                employeeEmail = employeeEmail,
                employeePassword = hashedPassword,
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

        private void backCsoonBtn_Click(object sender, EventArgs e)
        {
            MainAdmin mainAdminForm = new MainAdmin();
            mainAdminForm.SetUserNamme(_userName, _profilePic);
            mainAdminForm.Visible = true;
            this.Close();
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            if (formOptionsPanel.Visible == true)
            {
                formOptionsPanel.Visible = false;
            }
            else
            {
                formOptionsPanel.Visible = true;
            }
        }

        private void closeShowingImageBtn_Click(object sender, EventArgs e)
        {
            viewEmployeePanel.Visible = false;
        }

        private void showingBtn_Click_1(object sender, EventArgs e)
        {
            Showing showing = new Showing(_userName, _profilePic);
            showing.Show();
            this.Close();
        }

        private void filmsBtn_Click_1(object sender, EventArgs e)
        {
            FilmsInCinemaForm films = new FilmsInCinemaForm(_userName, _profilePic);
            films.Show();
            this.Close();
        }

        private void comingSoonBtn_Click_1(object sender, EventArgs e)
        {
            ComingSoonMoviesForm coming = new ComingSoonMoviesForm(_userName, _profilePic);
            coming.Show();
            this.Close();
        }

        private string _userName;
        private string _profilePic;
        private void foodsBtn_Click_1(object sender, EventArgs e)
        {
            CinemaFoodDeals foods = new CinemaFoodDeals(_userName, _profilePic);
            foods.Show();
            this.Close();
        }
    }
}
