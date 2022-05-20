
namespace DDD2.WinForm.View
{
    partial class ShopListView
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
            this.ShopDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ShopDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ShopDataGrid
            // 
            this.ShopDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShopDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShopDataGrid.Location = new System.Drawing.Point(0, 0);
            this.ShopDataGrid.Name = "ShopDataGrid";
            this.ShopDataGrid.RowTemplate.Height = 21;
            this.ShopDataGrid.Size = new System.Drawing.Size(800, 450);
            this.ShopDataGrid.TabIndex = 0;
            // 
            // ShopListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShopDataGrid);
            this.Name = "ShopListView";
            this.Text = "ShopListView";
            ((System.ComponentModel.ISupportInitialize)(this.ShopDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ShopDataGrid;
    }
}