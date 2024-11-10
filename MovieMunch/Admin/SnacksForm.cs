using MongoDB.Bson;
using MovieMunch.Backend.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MovieMunch.Admin
{
    public partial class SnacksForm : Form
    {
        private readonly FoodServices _foodServices;

        public SnacksForm()
        {
            InitializeComponent();
            _foodServices = new FoodServices();
            LoadSnacksInCinemaData();

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

            SnacksTable.CellContentClick += SnacksTable_CellContentClick;
        }

        private void ViewSnack(string snackId)
        {
            viewSnacksPanel.Visible = true;
            var snack = _foodServices.GetFoodById(new ObjectId(snackId));

            if (snack != null)
            {
                try
                {
                    viewSnacksBox.BackgroundImage = Image.FromFile(snack.FoodImagePath);
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

        private void LoadSnacksInCinemaData()
        {
            List<MovieMunch.Backend.Models.Foods> snacks = _foodServices.GetFoodsInCollection();
            SnacksTable.Rows.Clear();

            foreach (var snack in snacks)
            {
                SnacksTable.Rows.Add(snack.Id.ToString(), snack.FoodName, snack.FoodPrice, snack.FoodImagePath);
            }
        }

        private void SnacksTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string snackId = SnacksTable.Rows[e.RowIndex].Cells[0].Value.ToString();

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
        }

        private void UpdateSnacks(string snacksID)
        {
            if (ObjectId.TryParse(snacksID, out var objectId))
            {
                var snack = _foodServices.GetFoodById(objectId);

                if (snack != null)
                {
                    var currentRow = SnacksTable.Rows[SnacksTable.CurrentCell.RowIndex];
                    snack.FoodName = currentRow.Cells[1].Value.ToString(); 
                    snack.FoodPrice = Convert.ToDecimal(currentRow.Cells[2].Value); 
                    snack.FoodImagePath = currentRow.Cells[3].Value.ToString();

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

        private void AddSnacksButton_Click(object sender, EventArgs e)
        {
            string foodName = RemoveSurroundingQuotes(SnacksTitleInput.Text);
            string foodImagePath = RemoveSurroundingQuotes(SnacksDirectoryInput.Text);

            if (!decimal.TryParse(SnacksDescriptionInput.Text, out decimal foodPrice))
            {
                MessageBox.Show("Invalid price format. Please enter a valid decimal number.");
                return;
            }

            if (string.IsNullOrEmpty(foodName) || string.IsNullOrEmpty(foodImagePath))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            var newFood = new MovieMunch.Backend.Models.Foods
            {
                FoodName = foodName,
                FoodPrice = foodPrice,
                FoodImagePath = foodImagePath
            };

            _foodServices.AddFood(newFood);
            MessageBox.Show("Snack saved successfully.");
            LoadSnacksInCinemaData();
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
            SnacksTitleInput.Clear();
            SnacksDescriptionInput.Clear();
            SnacksDirectoryInput.Clear();
        }

        private void closeImageBtn_Click(object sender, EventArgs e)
        {
            viewSnacksPanel.Visible = false;
        }

        private void backSnacksBtn_Click(object sender, EventArgs e)
        {
            MainAdmin mainAdminForm = new MainAdmin();
            mainAdminForm.Visible = true;
            this.Close();
        }
    }
}
