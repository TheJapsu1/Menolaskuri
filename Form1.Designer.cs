
namespace Menolaskuri
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
            this.addButton = new System.Windows.Forms.Button();
            this.moneyInput = new System.Windows.Forms.TextBox();
            this.explanationInput = new System.Windows.Forms.TextBox();
            this.categorySelection = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(345, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Lisää meno";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // moneyInput
            // 
            this.moneyInput.Location = new System.Drawing.Point(118, 12);
            this.moneyInput.Name = "moneyInput";
            this.moneyInput.PlaceholderText = "Mennyt raha";
            this.moneyInput.Size = new System.Drawing.Size(100, 23);
            this.moneyInput.TabIndex = 1;
            // 
            // explanationInput
            // 
            this.explanationInput.Location = new System.Drawing.Point(224, 12);
            this.explanationInput.Name = "explanationInput";
            this.explanationInput.PlaceholderText = "Selitys";
            this.explanationInput.Size = new System.Drawing.Size(100, 23);
            this.explanationInput.TabIndex = 2;
            // 
            // categorySelection
            // 
            this.categorySelection.FormattingEnabled = true;
            this.categorySelection.Location = new System.Drawing.Point(12, 12);
            this.categorySelection.Name = "categorySelection";
            this.categorySelection.Size = new System.Drawing.Size(100, 23);
            this.categorySelection.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 41);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(408, 246);
            this.dataGridView.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 301);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.categorySelection);
            this.Controls.Add(this.explanationInput);
            this.Controls.Add(this.moneyInput);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Menolaskuri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox moneyInput;
        private System.Windows.Forms.TextBox explanationInput;
        private System.Windows.Forms.ComboBox categorySelection;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

