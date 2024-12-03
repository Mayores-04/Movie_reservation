using MongoDB.Bson;
using MovieMunch.Backend.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MovieMunch.Backend.Models;
using MovieMunch.Admin.FilmsInCinema;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
namespace MovieMunch.Admin
{
    public partial class CinemaFoodDeals : Form
    {
        private readonly FoodServices _foodServices;
        private readonly FoodServices _snackFoodServices;

        public CinemaFoodDeals(string userName, string profilePic)
        {
            InitializeComponent();
            _foodServices = new FoodServices();
            _snackFoodServices = new FoodServices();
            LoadSnacksInCinemaData();
            LoadRegularInCinemaData();
            formOptionsPanel.BringToFront();

            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Update",
                Text = "Update",
                UseColumnTextForButtonValue = true,
                Name = "UpdateButton"
            };
            SnacksTable.Columns.Add(updateButtonColumn);

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Name = "DeleteButton"
            };
            SnacksTable.Columns.Add(deleteButtonColumn);

            DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "View",
                Text = "View Snacks",
                UseColumnTextForButtonValue = true,
                Name = "ViewButton"
            };
            SnacksTable.Columns.Add(viewButtonColumn);




            DataGridViewButtonColumn updateRegularButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Update",
                Text = "Update",
                UseColumnTextForButtonValue = true,
                Name = "UpdateButton"
            };
            RegularTable.Columns.Add(updateRegularButtonColumn);

            DataGridViewButtonColumn deleteRegularButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Name = "DeleteButton"
            };
            RegularTable.Columns.Add(deleteRegularButtonColumn);

            DataGridViewButtonColumn viewRegularButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "View",
                Text = "View Regular Food",
                UseColumnTextForButtonValue = true,
                Name = "ViewButton"
            };
            RegularTable.Columns.Add(viewRegularButtonColumn);

            SnacksTable.CellContentClick += SnacksTable_CellContentClick;
            SnacksTable.CellPainting += MoviesToShowTable_CellPainting;


            RegularTable.CellContentClick += RegularTable_CellContentClick;
            RegularTable.CellPainting += MoviesToShowTable_CellPainting;

            _userName = userName;
            _profilePic = profilePic;
            MainAdmin mainAdmin = new MainAdmin();
            mainAdmin.SetUserNamme(_userName, _profilePic);
        }

        private void MoviesToShowTable_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == SnacksTable.Columns["UpdateButton"].Index ||
                                    e.ColumnIndex == SnacksTable.Columns["DeleteButton"].Index ||
                                    e.ColumnIndex == SnacksTable.Columns["ViewButton"].Index))
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.Background | DataGridViewPaintParts.Border);

                Color buttonColor = Color.Transparent;
                Color borderColor = Color.Black;
                if (e.ColumnIndex == SnacksTable.Columns["UpdateButton"].Index)
                {
                    buttonColor = Color.LightBlue;
                    borderColor = Color.DarkBlue;
                }
                else if (e.ColumnIndex == SnacksTable.Columns["DeleteButton"].Index)
                {
                    buttonColor = Color.IndianRed;
                    borderColor = Color.DarkRed;
                }
                else if (e.ColumnIndex == SnacksTable.Columns["ViewButton"].Index)
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


        private string _userName;
        private string _profilePic;
        private void ViewSnack(string snackId)
        {
            viewSnacksPanel.Visible = true;
            var snack = _snackFoodServices.GetSnackFoodById(new ObjectId(snackId));

            if (snack != null)
            {
                try
                {
                    viewSnacksBox.BackgroundImage = Image.FromFile(snack.SFoodImagePath);
                    viewSnacksBox.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Snack not found.");
            }
        }

        private void ViewRegular(string snackId)
        {
            regularPanelBox.Visible = true;
            var reg = _foodServices.GetFoodById(new ObjectId(snackId));

            if (reg != null)
            {
                try
                {
                    regularPictureBox.BackgroundImage = Image.FromFile(reg.FoodImagePath);
                    regularPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Snack not found.");
            }
        }

        private void LoadSnacksInCinemaData()
        {
            List <SnackDeals> snacks = _snackFoodServices.GetSnackFoodsCollection();
            SnacksTable.Rows.Clear();

            foreach (var snack in snacks)
            {
                SnacksTable.Rows.Add(snack.Id.ToString(), snack.SFoodName, snack.SFoodPrice, snack.SFoodImagePath);
            }
        }

        private void LoadRegularInCinemaData()
        {
            List<RegularDeals> snacks = _foodServices.GetFoodsInCollection();
            RegularTable.Rows.Clear();

            foreach (var snack in snacks)
            {
                RegularTable.Rows.Add(snack.Id.ToString(), snack.FoodName, snack.FoodPrice, snack.FoodImagePath);
            }
        }

        private void SnacksTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            string snackId = SnacksTable.Rows[e.RowIndex].Cells["SnacksId"].Value.ToString();

            if (SnacksTable.Columns[e.ColumnIndex].Name == "UpdateButton")
            {
                UpdateSnacks(snackId);
            }
            else if (SnacksTable.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                DeleteSnacks(snackId);
            }
            else if (SnacksTable.Columns[e.ColumnIndex].Name == "ViewButton")
            {
                ViewSnack(snackId);
            }
        }

        private void RegularTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string snackId = RegularTable.Rows[e.RowIndex].Cells["regularId"].Value.ToString();

                if (RegularTable.Columns[e.ColumnIndex].Name == "UpdateButton")
                {
                    UpdateRegular(snackId);
                }
                else if (RegularTable.Columns[e.ColumnIndex].Name == "DeleteButton")
                {
                    DeleteRegular(snackId);
                }
                else if (RegularTable.Columns[e.ColumnIndex].Name == "ViewButton")
                {
                    ViewRegular(snackId);
                }
            }
        }

        private void UpdateSnacks(string snacksID)
        {
            if (ObjectId.TryParse(snacksID, out var objectId))
            {
                var snack = _snackFoodServices.GetSnackFoodById(objectId);

                if (snack != null)
                {
                    var currentRow = SnacksTable.Rows[SnacksTable.CurrentCell.RowIndex];
                    snack.SFoodName = currentRow.Cells[1].Value.ToString();
                    snack.SFoodPrice = Convert.ToDecimal(currentRow.Cells[2].Value);

                    // Apply regex sanitization to the image path
                    snack.SFoodImagePath = SanitizeImagePath(currentRow.Cells[3].Value.ToString());

                    _snackFoodServices.UpdateSnackFood(snack);
                    MessageBox.Show("Snack updated successfully.");
                    LoadSnacksInCinemaData();
                }
                else
                {
                    MessageBox.Show("Snack not found.");
                }
            }
            else
            {
                MessageBox.Show("Invalid ID format.");
            }
        }

        private void UpdateRegular(string snacksID)
        {
            if (ObjectId.TryParse(snacksID, out var objectId))
            {
                var snack = _foodServices.GetFoodById(objectId);

                if (snack != null)
                {
                    var currentRow = RegularTable.Rows[RegularTable.CurrentCell.RowIndex];
                    snack.FoodName = currentRow.Cells[1].Value.ToString();
                    snack.FoodPrice = Convert.ToDecimal(currentRow.Cells[2].Value);

                    snack.FoodImagePath = SanitizeImagePath(currentRow.Cells[3].Value.ToString());

                    _foodServices.UpdateFood(snack);
                    MessageBox.Show("Snack updated successfully.");
                    LoadSnacksInCinemaData();
                }
                else
                {
                    MessageBox.Show("Snack not found.");
                }
            }
            else
            {
                MessageBox.Show("Invalid ID format.");
            }
        }

        private void DeleteSnacks(string snacksID)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this snack?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                if (ObjectId.TryParse(snacksID, out var objectId))
                {
                    bool isDeleted = _foodServices.DeleteFoodById(objectId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Snack successfully deleted.");
                        LoadRegularInCinemaData();
                    }
                    else
                    {
                        MessageBox.Show("Snack could not be deleted.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID format.");
                }
            }
        }

        private void DeleteRegular(string snacksID)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this snack?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                if (ObjectId.TryParse(snacksID, out var objectId))
                {
                    bool isDeleted = _snackFoodServices.DeleteSnackFoodById(objectId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Snack successfully deleted.");
                        LoadSnacksInCinemaData();
                    }
                    else
                    {
                        MessageBox.Show("Snack could not be deleted.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID format.");
                }
            }
        }
        private string SanitizeImagePath(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            // Remove surrounding quotes
            input = RemoveSurroundingQuotes(input);

            // Regex to allow only valid characters in file paths
            string pattern = @"[^a-zA-Z0-9_\\:/.]";
            return Regex.Replace(input, pattern, string.Empty);
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
            SnacksTitleInput.Clear();
            SnacksPriceInput.Clear();
            SnacksDirectoryInput.Clear();
        }

        private void closeImageBtn_Click(object sender, EventArgs e)
        {
            viewSnacksPanel.Visible = false;
        }

        private void addRegularFoodsBtn_Click(object sender, EventArgs e)
        {
            string regulaFoodName = RemoveSurroundingQuotes(regularFoodNameDealsInput.Text);
            string regularFoodImagePath = RemoveSurroundingQuotes(regularImagePathInput.Text);

            if (!decimal.TryParse(regularPriceInput.Text, out decimal foodPrice))
            {
                MessageBox.Show("Invalid price format. Please enter a valid decimal number.");
                return;
            }

            if (string.IsNullOrEmpty(regulaFoodName) || string.IsNullOrEmpty(regularFoodImagePath))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            var newFood = new RegularDeals
            {
                FoodName = regulaFoodName,
                FoodPrice = foodPrice,
                FoodImagePath = regularFoodImagePath
            };

            _foodServices.AddFood(newFood);
            MessageBox.Show("Regular food saved successfully.");
            LoadRegularInCinemaData();
            ClearAdminInput();
        }

        private void AddSnacksDealsButton_Click(object sender, EventArgs e)
        {
            string snackFoodName = RemoveSurroundingQuotes(SnacksTitleInput.Text);
            string snackFoodImagePath = RemoveSurroundingQuotes(SnacksDirectoryInput.Text);

            if (!decimal.TryParse(SnacksPriceInput.Text, out decimal foodPrice))
            {
                MessageBox.Show("Invalid price format. Please enter a valid decimal number.");
                return;
            }

            if (string.IsNullOrEmpty(snackFoodName) || string.IsNullOrEmpty(snackFoodImagePath))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            var newFood = new SnackDeals
            {
                SFoodName = snackFoodName,
                SFoodPrice = foodPrice,
                SFoodImagePath = snackFoodImagePath
            };

            _snackFoodServices.AddSnackFood(newFood);
            MessageBox.Show("Snack saved successfully.");
            LoadSnacksInCinemaData();
            ClearAdminInput();
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

        private void backCsoonBtn_Click(object sender, EventArgs e)
        {
            MainAdmin mainAdminForm = new MainAdmin();
            mainAdminForm.SetUserNamme(_userName, _profilePic);
            mainAdminForm.Visible = true;
            this.Close();
        }

        private void showingBtn_Click(object sender, EventArgs e)
        {
            Showing showing = new Showing(_userName, _profilePic);
            showing.Show();
            this.Close();
        }

        private void filmsBtn_Click(object sender, EventArgs e)
        {
            FilmsInCinemaForm films = new FilmsInCinemaForm(_userName, _profilePic);
            films.Show();
            this.Close();
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            EmployeesManagementForm employee = new EmployeesManagementForm(_userName, _profilePic);
            employee.Show();
            this.Close();
        }

        private void comingSoonBtn_Click(object sender, EventArgs e)
        {
            ComingSoonMoviesForm comingSoonMoviesForm = new ComingSoonMoviesForm(_userName, _profilePic);
            comingSoonMoviesForm.Show();
            this.Close();
        }

        private void regularDealsBtn_Click(object sender, EventArgs e)
        {
            regularPanel.Visible = true;
            regularDealsBtn.FillColor = Color.FromArgb(255, 186, 8);

            snacksPanel.Visible = false;
            snackDealsBtn.FillColor = Color.FromArgb(199, 44, 65);
        }

        private void snackDealsBtn_Click(object sender, EventArgs e)
        {
            if (snackDealsBtn.FillColor == Color.FromArgb(199, 44, 65))
            {
                snacksPanel.Visible = true;
                snackDealsBtn.FillColor = Color.FromArgb(255, 186, 8); 
                regularPanel.Visible = false;  
                regularDealsBtn.FillColor = Color.FromArgb(199, 44, 65);  
            }
            else
            {
                snacksPanel.Visible = false;
                snackDealsBtn.FillColor = Color.FromArgb(199, 44, 65);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            regularPanelBox.Visible = false;
        }
    }
}
