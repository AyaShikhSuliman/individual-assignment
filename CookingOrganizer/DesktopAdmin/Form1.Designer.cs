namespace DesktopAdmin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbRecipes = new System.Windows.Forms.ListBox();
            this.lbRecipeSuggestions = new System.Windows.Forms.ListBox();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            this.btnAcceptSuggestion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOwner = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnUploadAPicture = new System.Windows.Forms.Button();
            this.pbRecipeImage = new System.Windows.Forms.PictureBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.rtbIngredients = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeclineSuggstion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecipeImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRecipes
            // 
            this.lbRecipes.FormattingEnabled = true;
            this.lbRecipes.ItemHeight = 20;
            this.lbRecipes.Location = new System.Drawing.Point(23, 70);
            this.lbRecipes.Name = "lbRecipes";
            this.lbRecipes.Size = new System.Drawing.Size(579, 124);
            this.lbRecipes.TabIndex = 0;
            this.lbRecipes.SelectedIndexChanged += new System.EventHandler(this.lbRecipes_SelectedIndexChanged);
            // 
            // lbRecipeSuggestions
            // 
            this.lbRecipeSuggestions.FormattingEnabled = true;
            this.lbRecipeSuggestions.ItemHeight = 20;
            this.lbRecipeSuggestions.Location = new System.Drawing.Point(29, 110);
            this.lbRecipeSuggestions.Name = "lbRecipeSuggestions";
            this.lbRecipeSuggestions.Size = new System.Drawing.Size(728, 124);
            this.lbRecipeSuggestions.TabIndex = 1;
            this.lbRecipeSuggestions.SelectedIndexChanged += new System.EventHandler(this.lbRecipeSuggestions_SelectedIndexChanged);
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.Location = new System.Drawing.Point(649, 82);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(117, 78);
            this.btnDeleteRecipe.TabIndex = 3;
            this.btnDeleteRecipe.Text = "Delete recipe";
            this.btnDeleteRecipe.UseVisualStyleBackColor = true;
            this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
            // 
            // btnAcceptSuggestion
            // 
            this.btnAcceptSuggestion.Location = new System.Drawing.Point(531, 40);
            this.btnAcceptSuggestion.Name = "btnAcceptSuggestion";
            this.btnAcceptSuggestion.Size = new System.Drawing.Size(110, 48);
            this.btnAcceptSuggestion.TabIndex = 5;
            this.btnAcceptSuggestion.Text = "Accept suggestion";
            this.btnAcceptSuggestion.UseVisualStyleBackColor = true;
            this.btnAcceptSuggestion.Click += new System.EventHandler(this.btnAcceptSuggestion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAddRecipe);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbOwner);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSaveChanges);
            this.groupBox1.Controls.Add(this.btnUploadAPicture);
            this.groupBox1.Controls.Add(this.pbRecipeImage);
            this.groupBox1.Controls.Add(this.rtbDescription);
            this.groupBox1.Controls.Add(this.rtbIngredients);
            this.groupBox1.Controls.Add(this.lbRecipes);
            this.groupBox1.Controls.Add(this.btnDeleteRecipe);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 529);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit recipe";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(38, 453);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(216, 27);
            this.tbName.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Name";
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(299, 384);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(108, 54);
            this.btnAddRecipe.TabIndex = 10;
            this.btnAddRecipe.Text = "Add recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Owner";
            // 
            // tbOwner
            // 
            this.tbOwner.Location = new System.Drawing.Point(38, 371);
            this.tbOwner.Name = "tbOwner";
            this.tbOwner.Size = new System.Drawing.Size(216, 27);
            this.tbOwner.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Picture";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ingredients";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select the recipe you want to edit or type anything in the boxes to add a new one" +
    "";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(419, 384);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(105, 54);
            this.btnSaveChanges.TabIndex = 9;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnUploadAPicture
            // 
            this.btnUploadAPicture.Location = new System.Drawing.Point(676, 384);
            this.btnUploadAPicture.Name = "btnUploadAPicture";
            this.btnUploadAPicture.Size = new System.Drawing.Size(104, 54);
            this.btnUploadAPicture.TabIndex = 8;
            this.btnUploadAPicture.Text = "Upload a picture (.jpg)";
            this.btnUploadAPicture.UseVisualStyleBackColor = true;
            this.btnUploadAPicture.Click += new System.EventHandler(this.btnUploadAPicture_Click);
            // 
            // pbRecipeImage
            // 
            this.pbRecipeImage.Location = new System.Drawing.Point(561, 238);
            this.pbRecipeImage.Name = "pbRecipeImage";
            this.pbRecipeImage.Size = new System.Drawing.Size(219, 140);
            this.pbRecipeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRecipeImage.TabIndex = 7;
            this.pbRecipeImage.TabStop = false;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(299, 249);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(225, 71);
            this.rtbDescription.TabIndex = 6;
            this.rtbDescription.Text = "";
            // 
            // rtbIngredients
            // 
            this.rtbIngredients.Location = new System.Drawing.Point(38, 249);
            this.rtbIngredients.Name = "rtbIngredients";
            this.rtbIngredients.Size = new System.Drawing.Size(222, 71);
            this.rtbIngredients.TabIndex = 5;
            this.rtbIngredients.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnDeclineSuggstion);
            this.groupBox2.Controls.Add(this.btnAcceptSuggestion);
            this.groupBox2.Controls.Add(this.lbRecipeSuggestions);
            this.groupBox2.Location = new System.Drawing.Point(31, 547);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(803, 251);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recipe suggestions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Select recipe suggestion";
            // 
            // btnDeclineSuggstion
            // 
            this.btnDeclineSuggstion.Location = new System.Drawing.Point(647, 40);
            this.btnDeclineSuggstion.Name = "btnDeclineSuggstion";
            this.btnDeclineSuggstion.Size = new System.Drawing.Size(110, 48);
            this.btnDeclineSuggstion.TabIndex = 6;
            this.btnDeclineSuggstion.Text = "Decline suggestion";
            this.btnDeclineSuggstion.UseVisualStyleBackColor = true;
            this.btnDeclineSuggstion.Click += new System.EventHandler(this.btnDeclineSuggstion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 829);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecipeImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lbRecipes;
        private ListBox lbRecipeSuggestions;
        private Button btnDeleteRecipe;
        private Button btnAcceptSuggestion;
        private GroupBox groupBox1;
        private PictureBox pbRecipeImage;
        private RichTextBox rtbDescription;
        private RichTextBox rtbIngredients;
        private Button btnUploadAPicture;
        private GroupBox groupBox2;
        private Button btnDeclineSuggstion;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSaveChanges;
        private Label label5;
        private Label label6;
        private TextBox tbOwner;
        private Button btnAddRecipe;
        private TextBox tbName;
        private Label label7;
    }
}