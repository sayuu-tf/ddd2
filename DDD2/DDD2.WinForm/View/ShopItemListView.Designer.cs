
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ProfitText = new System.Windows.Forms.Label();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.LocationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ShopId";
            // 
            // ShopSelectTextBox
            // 
            this.ShopSelectTextBox.Location = new System.Drawing.Point(117, 104);
            this.ShopSelectTextBox.Name = "ShopSelectTextBox";
            this.ShopSelectTextBox.Size = new System.Drawing.Size(100, 19);
            this.ShopSelectTextBox.TabIndex = 1;
            // 
            // ShopSelectButton
            // 
            this.ShopSelectButton.Location = new System.Drawing.Point(232, 105);
            this.ShopSelectButton.Name = "ShopSelectButton";
            this.ShopSelectButton.Size = new System.Drawing.Size(75, 23);
            this.ShopSelectButton.TabIndex = 2;
            this.ShopSelectButton.Text = "ショップ選択";
            this.ShopSelectButton.UseVisualStyleBackColor = true;
            this.ShopSelectButton.Click += new System.EventHandler(this.ShopSelectButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "ShopName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Location";
            // 
            // ShopNameText
            // 
            this.ShopNameText.AutoSize = true;
            this.ShopNameText.Location = new System.Drawing.Point(142, 151);
            this.ShopNameText.Name = "ShopNameText";
            this.ShopNameText.Size = new System.Drawing.Size(82, 12);
            this.ShopNameText.TabIndex = 5;
            this.ShopNameText.Text = "ShopNameText";
            // 
            // LocationText
            // 
            this.LocationText.AutoSize = true;
            this.LocationText.Location = new System.Drawing.Point(142, 188);
            this.LocationText.Name = "LocationText";
            this.LocationText.Size = new System.Drawing.Size(71, 12);
            this.LocationText.TabIndex = 6;
            this.LocationText.Text = "LocationText";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "ショップList";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Profit";
            // 
            // ProfitText
            // 
            this.ProfitText.AutoSize = true;
            this.ProfitText.Location = new System.Drawing.Point(142, 226);
            this.ProfitText.Name = "ProfitText";
            this.ProfitText.Size = new System.Drawing.Size(56, 12);
            this.ProfitText.TabIndex = 9;
            this.ProfitText.Text = "ProfitText";
            // 
            // LocationComboBox
            // 
            this.LocationComboBox.FormattingEnabled = true;
            this.LocationComboBox.Location = new System.Drawing.Point(103, 55);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(121, 20);
            this.LocationComboBox.TabIndex = 10;
            // 
            // LocationButton
            // 
            this.LocationButton.Location = new System.Drawing.Point(247, 53);
            this.LocationButton.Name = "LocationButton";
            this.LocationButton.Size = new System.Drawing.Size(75, 23);
            this.LocationButton.TabIndex = 11;
            this.LocationButton.Text = "場所選択";
            this.LocationButton.UseVisualStyleBackColor = true;
            // 
            // ShopItemListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 341);
            this.Controls.Add(this.LocationButton);
            this.Controls.Add(this.LocationComboBox);
            this.Controls.Add(this.ProfitText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ProfitText;
        private System.Windows.Forms.ComboBox LocationComboBox;
        private System.Windows.Forms.Button LocationButton;
    }
}

