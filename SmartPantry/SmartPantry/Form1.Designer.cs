﻿
namespace SmartPantry
{
    partial class Form1
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
            this.cookedButton = new System.Windows.Forms.Button();
            this.ateButton = new System.Windows.Forms.Button();
            this.shoppingButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.allFoodTab = new System.Windows.Forms.TabPage();
            this.allFoodLB = new System.Windows.Forms.ListBox();
            this.pantryTab = new System.Windows.Forms.TabPage();
            this.pantryLB = new System.Windows.Forms.ListBox();
            this.refrigeratorTab = new System.Windows.Forms.TabPage();
            this.refrigeratorLB = new System.Windows.Forms.ListBox();
            this.freezerTab = new System.Windows.Forms.TabPage();
            this.freezerLB = new System.Windows.Forms.ListBox();
            this.recipesTab = new System.Windows.Forms.TabPage();
            this.recipesLB = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.allFoodTab.SuspendLayout();
            this.pantryTab.SuspendLayout();
            this.refrigeratorTab.SuspendLayout();
            this.freezerTab.SuspendLayout();
            this.recipesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // cookedButton
            // 
            this.cookedButton.Location = new System.Drawing.Point(28, 46);
            this.cookedButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cookedButton.Name = "cookedButton";
            this.cookedButton.Size = new System.Drawing.Size(406, 398);
            this.cookedButton.TabIndex = 0;
            this.cookedButton.Text = "I Cooked Something!";
            this.cookedButton.UseVisualStyleBackColor = true;
            this.cookedButton.Click += new System.EventHandler(this.cookedButton_Click);
            // 
            // ateButton
            // 
            this.ateButton.Location = new System.Drawing.Point(28, 512);
            this.ateButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ateButton.Name = "ateButton";
            this.ateButton.Size = new System.Drawing.Size(404, 363);
            this.ateButton.TabIndex = 5;
            this.ateButton.Text = "I Ate Something!";
            this.ateButton.UseVisualStyleBackColor = true;
            this.ateButton.Click += new System.EventHandler(this.ateButton_Click);
            // 
            // shoppingButton
            // 
            this.shoppingButton.Location = new System.Drawing.Point(1358, 46);
            this.shoppingButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.shoppingButton.Name = "shoppingButton";
            this.shoppingButton.Size = new System.Drawing.Size(312, 827);
            this.shoppingButton.TabIndex = 7;
            this.shoppingButton.Text = "Shopping List";
            this.shoppingButton.UseVisualStyleBackColor = true;
            this.shoppingButton.Click += new System.EventHandler(this.shoppingButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.allFoodTab);
            this.tabControl.Controls.Add(this.pantryTab);
            this.tabControl.Controls.Add(this.refrigeratorTab);
            this.tabControl.Controls.Add(this.freezerTab);
            this.tabControl.Controls.Add(this.recipesTab);
            this.tabControl.Location = new System.Drawing.Point(510, 46);
            this.tabControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(734, 829);
            this.tabControl.TabIndex = 8;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // allFoodTab
            // 
            this.allFoodTab.Controls.Add(this.allFoodLB);
            this.allFoodTab.Location = new System.Drawing.Point(8, 39);
            this.allFoodTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.allFoodTab.Name = "allFoodTab";
            this.allFoodTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.allFoodTab.Size = new System.Drawing.Size(718, 782);
            this.allFoodTab.TabIndex = 0;
            this.allFoodTab.Text = "All Food";
            this.allFoodTab.UseVisualStyleBackColor = true;
            // 
            // allFoodLB
            // 
            this.allFoodLB.FormattingEnabled = true;
            this.allFoodLB.ItemHeight = 25;
            this.allFoodLB.Location = new System.Drawing.Point(6, 4);
            this.allFoodLB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.allFoodLB.Name = "allFoodLB";
            this.allFoodLB.Size = new System.Drawing.Size(698, 754);
            this.allFoodLB.TabIndex = 0;
            this.allFoodLB.SelectedIndexChanged += new System.EventHandler(this.allFoodLB_SelectedIndexChanged);
            // 
            // pantryTab
            // 
            this.pantryTab.Controls.Add(this.pantryLB);
            this.pantryTab.Location = new System.Drawing.Point(8, 39);
            this.pantryTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pantryTab.Name = "pantryTab";
            this.pantryTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pantryTab.Size = new System.Drawing.Size(718, 782);
            this.pantryTab.TabIndex = 1;
            this.pantryTab.Text = "Pantry";
            this.pantryTab.UseVisualStyleBackColor = true;
            // 
            // pantryLB
            // 
            this.pantryLB.FormattingEnabled = true;
            this.pantryLB.ItemHeight = 25;
            this.pantryLB.Location = new System.Drawing.Point(10, 10);
            this.pantryLB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pantryLB.Name = "pantryLB";
            this.pantryLB.Size = new System.Drawing.Size(698, 754);
            this.pantryLB.TabIndex = 1;
            this.pantryLB.SelectedIndexChanged += new System.EventHandler(this.pantryLB_SelectedIndexChanged);
            // 
            // refrigeratorTab
            // 
            this.refrigeratorTab.Controls.Add(this.refrigeratorLB);
            this.refrigeratorTab.Location = new System.Drawing.Point(8, 39);
            this.refrigeratorTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.refrigeratorTab.Name = "refrigeratorTab";
            this.refrigeratorTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.refrigeratorTab.Size = new System.Drawing.Size(718, 782);
            this.refrigeratorTab.TabIndex = 2;
            this.refrigeratorTab.Text = "Refrigerator";
            this.refrigeratorTab.UseVisualStyleBackColor = true;
            // 
            // refrigeratorLB
            // 
            this.refrigeratorLB.FormattingEnabled = true;
            this.refrigeratorLB.ItemHeight = 25;
            this.refrigeratorLB.Location = new System.Drawing.Point(10, 10);
            this.refrigeratorLB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.refrigeratorLB.Name = "refrigeratorLB";
            this.refrigeratorLB.Size = new System.Drawing.Size(698, 754);
            this.refrigeratorLB.TabIndex = 1;
            this.refrigeratorLB.SelectedIndexChanged += new System.EventHandler(this.refrigeratorLB_SelectedIndexChanged);
            // 
            // freezerTab
            // 
            this.freezerTab.Controls.Add(this.freezerLB);
            this.freezerTab.Location = new System.Drawing.Point(8, 39);
            this.freezerTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.freezerTab.Name = "freezerTab";
            this.freezerTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.freezerTab.Size = new System.Drawing.Size(718, 782);
            this.freezerTab.TabIndex = 3;
            this.freezerTab.Text = "Freezer";
            this.freezerTab.UseVisualStyleBackColor = true;
            // 
            // freezerLB
            // 
            this.freezerLB.FormattingEnabled = true;
            this.freezerLB.ItemHeight = 25;
            this.freezerLB.Location = new System.Drawing.Point(10, 10);
            this.freezerLB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.freezerLB.Name = "freezerLB";
            this.freezerLB.Size = new System.Drawing.Size(698, 754);
            this.freezerLB.TabIndex = 1;
            this.freezerLB.SelectedIndexChanged += new System.EventHandler(this.freezerLB_SelectedIndexChanged);
            // 
            // recipesTab
            // 
            this.recipesTab.Controls.Add(this.recipesLB);
            this.recipesTab.Location = new System.Drawing.Point(8, 39);
            this.recipesTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.recipesTab.Name = "recipesTab";
            this.recipesTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.recipesTab.Size = new System.Drawing.Size(718, 782);
            this.recipesTab.TabIndex = 4;
            this.recipesTab.Text = "Recipes";
            this.recipesTab.UseVisualStyleBackColor = true;
            // 
            // recipesLB
            // 
            this.recipesLB.FormattingEnabled = true;
            this.recipesLB.ItemHeight = 25;
            this.recipesLB.Location = new System.Drawing.Point(10, 10);
            this.recipesLB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.recipesLB.Name = "recipesLB";
            this.recipesLB.Size = new System.Drawing.Size(698, 754);
            this.recipesLB.TabIndex = 1;
            this.recipesLB.SelectedIndexChanged += new System.EventHandler(this.recipesLB_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 965);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.shoppingButton);
            this.Controls.Add(this.ateButton);
            this.Controls.Add(this.cookedButton);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.allFoodTab.ResumeLayout(false);
            this.pantryTab.ResumeLayout(false);
            this.refrigeratorTab.ResumeLayout(false);
            this.freezerTab.ResumeLayout(false);
            this.recipesTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cookedButton;
        private System.Windows.Forms.Button ateButton;
        private System.Windows.Forms.Button shoppingButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage allFoodTab;
        private System.Windows.Forms.TabPage pantryTab;
        private System.Windows.Forms.TabPage refrigeratorTab;
        private System.Windows.Forms.TabPage freezerTab;
        private System.Windows.Forms.TabPage recipesTab;
        private System.Windows.Forms.ListBox allFoodLB;
        private System.Windows.Forms.ListBox pantryLB;
        private System.Windows.Forms.ListBox refrigeratorLB;
        private System.Windows.Forms.ListBox freezerLB;
        private System.Windows.Forms.ListBox recipesLB;
    }
}

