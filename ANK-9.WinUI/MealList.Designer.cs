namespace ANK_9.WinUI
{
    partial class MealList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealList));
            this.lst_mealList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_createMeal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Meal = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_mealList
            // 
            this.lst_mealList.Dock = System.Windows.Forms.DockStyle.Left;
            this.lst_mealList.FormattingEnabled = true;
            this.lst_mealList.ItemHeight = 20;
            this.lst_mealList.Location = new System.Drawing.Point(0, 0);
            this.lst_mealList.Name = "lst_mealList";
            this.lst_mealList.Size = new System.Drawing.Size(150, 450);
            this.lst_mealList.TabIndex = 0;
            this.lst_mealList.SelectedIndexChanged += new System.EventHandler(this.lst_mealList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Meal Name:";
            // 
            // txt_createMeal
            // 
            this.txt_createMeal.Location = new System.Drawing.Point(345, 12);
            this.txt_createMeal.Name = "txt_createMeal";
            this.txt_createMeal.Size = new System.Drawing.Size(166, 27);
            this.txt_createMeal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meal Name:";
            // 
            // txt_Meal
            // 
            this.txt_Meal.Location = new System.Drawing.Point(345, 65);
            this.txt_Meal.Name = "txt_Meal";
            this.txt_Meal.Size = new System.Drawing.Size(166, 27);
            this.txt_Meal.TabIndex = 2;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(517, 11);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(181, 29);
            this.btn_create.TabIndex = 3;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(391, 137);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(181, 29);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(180, 137);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(181, 29);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // MealList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.txt_Meal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_createMeal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_mealList);
            this.Name = "MealList";
            this.Text = "MealList";
            this.Load += new System.EventHandler(this.MealList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lst_mealList;
        private Label label1;
        private TextBox txt_createMeal;
        private Label label2;
        private TextBox txt_Meal;
        private Button btn_create;
        private Button btn_delete;
        private Button btn_update;
    }
}