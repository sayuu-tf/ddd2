
namespace DDD2.WinForm
{
    partial class ShopItemListView
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ShopSelectTextBox = new System.Windows.Forms.TextBox();
            this.ShopSelectButton = new System.Windows.Forms.Button();
            this.ShopItemDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ShopNameTextLabel = new System.Windows.Forms.Label();
            this.ItemNameTextLabel = new System.Windows.Forms.Label();
            this.ItemPriceTextLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShopItemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ShopId";
            // 
            // ShopSelectTextBox
            // 
            this.ShopSelectTextBox.Location = new System.Drawing.Point(72, 26);
            this.ShopSelectTextBox.Name = "ShopSelectTextBox";
            this.ShopSelectTextBox.Size = new System.Drawing.Size(100, 19);
            this.ShopSelectTextBox.TabIndex = 1;
            // 
            // ShopSelectButton
            // 
            this.ShopSelectButton.Location = new System.Drawing.Point(187, 27);
            this.ShopSelectButton.Name = "ShopSelectButton";
            this.ShopSelectButton.Size = new System.Drawing.Size(75, 23);
            this.ShopSelectButton.TabIndex = 2;
            this.ShopSelectButton.Text = "ショップ選択";
            this.ShopSelectButton.UseVisualStyleBackColor = true;
            this.ShopSelectButton.Click += new System.EventHandler(this.ShopSelectButton_Click);
            // 
            // ShopItemDataGridView
            // 
            this.ShopItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShopItemDataGridView.Location = new System.Drawing.Point(207, 83);
            this.ShopItemDataGridView.Name = "ShopItemDataGridView";
            this.ShopItemDataGridView.RowTemplate.Height = 21;
            this.ShopItemDataGridView.Size = new System.Drawing.Size(413, 233);
            this.ShopItemDataGridView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "ShopName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "ItemName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "ItemPrice";
            // 
            // ShopNameTextLabel
            // 
            this.ShopNameTextLabel.AutoSize = true;
            this.ShopNameTextLabel.Location = new System.Drawing.Point(89, 83);
            this.ShopNameTextLabel.Name = "ShopNameTextLabel";
            this.ShopNameTextLabel.Size = new System.Drawing.Size(82, 12);
            this.ShopNameTextLabel.TabIndex = 7;
            this.ShopNameTextLabel.Text = "ShopNameText";
            // 
            // ItemNameTextLabel
            // 
            this.ItemNameTextLabel.AutoSize = true;
            this.ItemNameTextLabel.Location = new System.Drawing.Point(90, 125);
            this.ItemNameTextLabel.Name = "ItemNameTextLabel";
            this.ItemNameTextLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ItemNameTextLabel.Size = new System.Drawing.Size(79, 12);
            this.ItemNameTextLabel.TabIndex = 8;
            this.ItemNameTextLabel.Text = "ItemNameText";
            // 
            // ItemPriceTextLabel
            // 
            this.ItemPriceTextLabel.AutoSize = true;
            this.ItemPriceTextLabel.Location = new System.Drawing.Point(89, 167);
            this.ItemPriceTextLabel.Name = "ItemPriceTextLabel";
            this.ItemPriceTextLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ItemPriceTextLabel.Size = new System.Drawing.Size(76, 12);
            this.ItemPriceTextLabel.TabIndex = 9;
            this.ItemPriceTextLabel.Text = "ItemPriceText";
            // 
            // ShopItemListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 341);
            this.Controls.Add(this.ItemPriceTextLabel);
            this.Controls.Add(this.ItemNameTextLabel);
            this.Controls.Add(this.ShopNameTextLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShopItemDataGridView);
            this.Controls.Add(this.ShopSelectButton);
            this.Controls.Add(this.ShopSelectTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ShopItemListView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ShopItemDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ShopSelectTextBox;
        private System.Windows.Forms.Button ShopSelectButton;
        private System.Windows.Forms.DataGridView ShopItemDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ShopNameTextLabel;
        private System.Windows.Forms.Label ItemNameTextLabel;
        private System.Windows.Forms.Label ItemPriceTextLabel;
    }
}

