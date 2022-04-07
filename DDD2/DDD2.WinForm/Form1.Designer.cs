
namespace DDD2.WinForm
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)(this.ShopItemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shop";
            // 
            // ShopSelectTextBox
            // 
            this.ShopSelectTextBox.Location = new System.Drawing.Point(184, 22);
            this.ShopSelectTextBox.Name = "ShopSelectTextBox";
            this.ShopSelectTextBox.Size = new System.Drawing.Size(100, 19);
            this.ShopSelectTextBox.TabIndex = 1;
            // 
            // ShopSelectButton
            // 
            this.ShopSelectButton.Location = new System.Drawing.Point(336, 22);
            this.ShopSelectButton.Name = "ShopSelectButton";
            this.ShopSelectButton.Size = new System.Drawing.Size(75, 23);
            this.ShopSelectButton.TabIndex = 2;
            this.ShopSelectButton.Text = "button1";
            this.ShopSelectButton.UseVisualStyleBackColor = true;
            // 
            // ShopItemDataGridView
            // 
            this.ShopItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShopItemDataGridView.Location = new System.Drawing.Point(91, 77);
            this.ShopItemDataGridView.Name = "ShopItemDataGridView";
            this.ShopItemDataGridView.RowTemplate.Height = 21;
            this.ShopItemDataGridView.Size = new System.Drawing.Size(413, 233);
            this.ShopItemDataGridView.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 344);
            this.Controls.Add(this.ShopItemDataGridView);
            this.Controls.Add(this.ShopSelectButton);
            this.Controls.Add(this.ShopSelectTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
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
    }
}

