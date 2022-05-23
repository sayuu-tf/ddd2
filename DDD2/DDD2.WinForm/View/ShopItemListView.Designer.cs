
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ShopNameText = new System.Windows.Forms.Label();
            this.LocationText = new System.Windows.Forms.Label();
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "ShopName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Location";
            // 
            // ShopNameText
            // 
            this.ShopNameText.AutoSize = true;
            this.ShopNameText.Location = new System.Drawing.Point(97, 73);
            this.ShopNameText.Name = "ShopNameText";
            this.ShopNameText.Size = new System.Drawing.Size(82, 12);
            this.ShopNameText.TabIndex = 5;
            this.ShopNameText.Text = "ShopNameText";
            // 
            // LocationText
            // 
            this.LocationText.AutoSize = true;
            this.LocationText.Location = new System.Drawing.Point(97, 110);
            this.LocationText.Name = "LocationText";
            this.LocationText.Size = new System.Drawing.Size(71, 12);
            this.LocationText.TabIndex = 6;
            this.LocationText.Text = "LocationText";
            // 
            // ShopItemListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 341);
            this.Controls.Add(this.LocationText);
            this.Controls.Add(this.ShopNameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShopSelectButton);
            this.Controls.Add(this.ShopSelectTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ShopItemListView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ShopSelectTextBox;
        private System.Windows.Forms.Button ShopSelectButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ShopNameText;
        private System.Windows.Forms.Label LocationText;
    }
}

