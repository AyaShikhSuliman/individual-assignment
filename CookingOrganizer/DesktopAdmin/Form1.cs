using LogicLayer;
namespace DesktopAdmin
{
    public partial class Form1 : Form
    {
        private readonly RecipeManager recipeManager;
        private readonly RecipeSuggestionManager recipeSuggestionManager;
        Manager manager = new Manager();
        Recipe recipeToBeEdited;
        RecipeSuggestion recipeToBeApproved;
        public Form1()
        {
            InitializeComponent();
            recipeManager = Manager.Instance.GetRecipeManager();
            recipeSuggestionManager = Manager.Instance.GetRecipeSuggstionManager();
            ClearAndLoadNewRecipes();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbRecipes.SelectedIndex != -1)
            {
                int indexOfID = lbRecipes.SelectedItem.ToString().LastIndexOf("ID: ") + 3;
                string stringID = lbRecipes.SelectedItem.ToString().Substring(indexOfID);
                int id = Convert.ToInt32(stringID);
                Recipe recipe = recipeManager.GetRecipeById(id);

                rtbIngredients.Text = recipe.Ingredients;
                rtbDescription.Text = recipe.Description;
                tbOwner.Text = recipe.Owner;
                pbRecipeImage.Image = recipe.Image;

                recipeToBeEdited = recipe;
            }
        }
        private void ClearAndLoadNewRecipes()
        {
            lbRecipes.ClearSelected();
            lbRecipeSuggestions.ClearSelected();
            lbRecipeSuggestions.Items.Clear();
            rtbDescription.Clear();
            rtbIngredients.Clear();
            tbOwner.Clear();
            lbRecipes.Items.Clear();
            pbRecipeImage.Image = null;
            foreach (Recipe recipe in recipeManager.ShowRecipes())
            {
                lbRecipes.Items.Add(recipe.GetInfoForDesktop());
            }
            foreach (RecipeSuggestion recipeSuggestion in recipeSuggestionManager.ShowRecipes())
            {
                lbRecipeSuggestions.Items.Add(recipeSuggestion.GetInfoForDesktop());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (recipeToBeEdited == null)
            {
                MessageBox.Show("Please select recipe from the list and change anything about it");
            }
            else
            {
                recipeToBeEdited.Owner = tbOwner.Text;
                recipeToBeEdited.Ingredients = rtbIngredients.Text;
                recipeToBeEdited.Description = rtbDescription.Text;
                recipeToBeEdited.Image = pbRecipeImage.Image;
                if (recipeManager.UpdateRecipe(recipeToBeEdited))
                {
                    MessageBox.Show("Recipe updated successfully!");
                    ClearAndLoadNewRecipes();
                }
                else
                {
                    MessageBox.Show("Something went wrong and the recipe was not updated");
                    ClearAndLoadNewRecipes();
                }
            }
        }

        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            if (recipeToBeEdited == null)
            {
                MessageBox.Show("Please select a recipe from the list first");
            }
            else
            {
                if (!recipeManager.DeleteRecipe(recipeToBeEdited))
                {
                    MessageBox.Show("Recipe was not deleted due to an error");
                }
                else
                {
                    MessageBox.Show("Recipe deleted successfully");
                }
                ClearAndLoadNewRecipes();
            }
        }

        private void btnUploadAPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "icon";
            ofd.Filter = "icon(*.png;*.jpg;)| *.png; *.jpg";
            ofd.ShowDialog();
            pbRecipeImage.Image = new Bitmap(ofd.FileName);
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            
            if (!recipeManager.CreateRecipe(rtbIngredients.Text, tbOwner.Text, rtbDescription.Text, pbRecipeImage.Image, tbName.Text) )
            {
                MessageBox.Show("Recipe was not created due to an error");
            }
            else
            {
                MessageBox.Show("Recipe was created successfully");
                ClearAndLoadNewRecipes();
            }
        }

        private void lbRecipeSuggestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbRecipeSuggestions.SelectedIndex != -1)
            {
                int indexOfID = lbRecipeSuggestions.SelectedItem.ToString().LastIndexOf("ID: ") + 3;
                string stringID = lbRecipeSuggestions.SelectedItem.ToString().Substring(indexOfID);
                int id = Convert.ToInt32(stringID);
                RecipeSuggestion recipe = recipeSuggestionManager.GetRecipeById(id);

                rtbIngredients.Text = recipe.Ingredients;
                rtbDescription.Text = recipe.Description;
                tbOwner.Text = recipe.Owner;

                recipeToBeApproved = recipe;
            }
        }

        private void btnAcceptSuggestion_Click(object sender, EventArgs e)
        {
            if (recipeToBeApproved != null)
            {

                if (!recipeManager.CreateRecipe(recipeToBeApproved.Ingredients, recipeToBeApproved.Owner, recipeToBeApproved.Description, null, recipeToBeApproved.Name))
                {
                    MessageBox.Show("Recipe was not created due to an error");
                }
                else
                {
                    MessageBox.Show("Recipe was created successfully");
                    recipeSuggestionManager.DeleteRecipe(recipeToBeApproved);
                    recipeToBeApproved = null;
                    ClearAndLoadNewRecipes();
                }

            }
        }

        private void btnDeclineSuggstion_Click(object sender, EventArgs e)
        {
            if (recipeToBeApproved != null)
            {
                if (!recipeSuggestionManager.DeleteRecipe(recipeToBeApproved))
                {
                    MessageBox.Show("Recipe suggestion was not deleted due to an error");
                }
                else
                {
                    MessageBox.Show("Recipe suggestion was deleted successfully");
                    ClearAndLoadNewRecipes();
                }
            }
        }
    }
}