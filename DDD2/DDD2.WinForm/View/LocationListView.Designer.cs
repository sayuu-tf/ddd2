
namespace DDD2.WinForm.View
{
    partial class LocationListView
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
            this.LocationDataGrid = new System.Windows.Forms.DataGridView();
            this.LocationIdTextBox = new System.Windows.Forms.TextBox();
            this.LocationNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LocationAddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LocationDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LocationDataGrid
            // 
            this.LocationDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocationDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.LocationDataGrid.Location = new System.Drawing.Point(0, 0);
            this.LocationDataGrid.Name = "LocationDataGrid";
            this.LocationDataGrid.RowTemplate.Height = 21;
            this.LocationDataGrid.Size = new System.Drawing.Size(800, 382);
            this.LocationDataGrid.TabIndex = 0;
            // 
            // LocationIdTextBox
            // 
            this.LocationIdTextBox.Location = new System.Drawing.Point(92, 405);
            this.LocationIdTextBox.Name = "LocationIdTextBox";
            this.LocationIdTextBox.Size = new System.Drawing.Size(100, 19);
            this.LocationIdTextBox.TabIndex = 1;
            // 
            // LocationNameTextBox
            // 
            this.LocationNameTextBox.Location = new System.Drawing.Point(294, 405);
            this.LocationNameTextBox.Name = "LocationNameTextBox";
            this.LocationNameTextBox.Size = new System.Drawing.Size(100, 19);
            this.LocationNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "LocationId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "LocationName";
            // 
            // LocationAddButton
            // 
            this.LocationAddButton.Location = new System.Drawing.Point(429, 403);
            this.LocationAddButton.Name = "LocationAddButton";
            this.LocationAddButton.Size = new System.Drawing.Size(75, 23);
            this.LocationAddButton.TabIndex = 5;
            this.LocationAddButton.Text = "追加";
            this.LocationAddButton.UseVisualStyleBackColor = true;
            this.LocationAddButton.Click += new System.EventHandler(this.LocationAddButton_Click);
            // 
            // LocationListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LocationAddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LocationNameTextBox);
            this.Controls.Add(this.LocationIdTextBox);
            this.Controls.Add(this.LocationDataGrid);
            this.Name = "LocationListView";
            this.Text = "LocationListView";
            ((System.ComponentModel.ISupportInitialize)(this.LocationDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LocationDataGrid;
        private System.Windows.Forms.TextBox LocationIdTextBox;
        private System.Windows.Forms.TextBox LocationNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LocationAddButton;
    }
}