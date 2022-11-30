namespace ANK_9.WinUI
{
    partial class CreateMeal
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
            this.btn_save = new System.Windows.Forms.Button();
            this.cb_meal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nub_Portion = new System.Windows.Forms.NumericUpDown();
            this.dgv_foodList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nub_Portion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_foodList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(603, 21);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(144, 38);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cb_meal
            // 
            this.cb_meal.FormattingEnabled = true;
            this.cb_meal.Location = new System.Drawing.Point(137, 27);
            this.cb_meal.Name = "cb_meal";
            this.cb_meal.Size = new System.Drawing.Size(151, 28);
            this.cb_meal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Meal Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Portion";
            // 
            // nub_Portion
            // 
            this.nub_Portion.Location = new System.Drawing.Point(385, 27);
            this.nub_Portion.Name = "nub_Portion";
            this.nub_Portion.Size = new System.Drawing.Size(189, 27);
            this.nub_Portion.TabIndex = 4;
            // 
            // dgv_foodList
            // 
            this.dgv_foodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_foodList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_foodList.Location = new System.Drawing.Point(0, 107);
            this.dgv_foodList.Name = "dgv_foodList";
            this.dgv_foodList.RowHeadersWidth = 51;
            this.dgv_foodList.RowTemplate.Height = 29;
            this.dgv_foodList.Size = new System.Drawing.Size(800, 343);
            this.dgv_foodList.TabIndex = 5;
            this.dgv_foodList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_foodList_CellMouseClick);
            // 
            // CreateMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_foodList);
            this.Controls.Add(this.nub_Portion);
            this.Controls.Add(this.cb_meal);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateMeal";
            this.Text = "CreateMeal";
            this.Load += new System.EventHandler(this.CreateMeal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nub_Portion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_foodList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_save;
        private ComboBox cb_meal;
        private Label label2;
        private Label label3;
        private NumericUpDown nub_Portion;
        private DataGridView dgv_foodList;
    }
}