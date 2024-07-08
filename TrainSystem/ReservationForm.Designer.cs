namespace TrainSystem
{
    partial class ReservationForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.大人 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TrainComboBox = new System.Windows.Forms.ComboBox();
            this.SeatComboBox = new System.Windows.Forms.ComboBox();
            this.AdultNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ChildrenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdultNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildrenNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(45, 82);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 12);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "お名前";
            // 
            // 大人
            // 
            this.大人.AutoSize = true;
            this.大人.Location = new System.Drawing.Point(45, 110);
            this.大人.Name = "大人";
            this.大人.Size = new System.Drawing.Size(29, 12);
            this.大人.TabIndex = 1;
            this.大人.Text = "大人";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "子供";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "電車";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "シート";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(114, 79);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(120, 19);
            this.NameTextBox.TabIndex = 5;
            // 
            // TrainComboBox
            // 
            this.TrainComboBox.FormattingEnabled = true;
            this.TrainComboBox.Location = new System.Drawing.Point(114, 171);
            this.TrainComboBox.Name = "TrainComboBox";
            this.TrainComboBox.Size = new System.Drawing.Size(120, 20);
            this.TrainComboBox.TabIndex = 6;
            // 
            // SeatComboBox
            // 
            this.SeatComboBox.FormattingEnabled = true;
            this.SeatComboBox.Location = new System.Drawing.Point(114, 199);
            this.SeatComboBox.Name = "SeatComboBox";
            this.SeatComboBox.Size = new System.Drawing.Size(120, 20);
            this.SeatComboBox.TabIndex = 7;
            // 
            // AdultNumericUpDown
            // 
            this.AdultNumericUpDown.Location = new System.Drawing.Point(114, 108);
            this.AdultNumericUpDown.Name = "AdultNumericUpDown";
            this.AdultNumericUpDown.Size = new System.Drawing.Size(120, 19);
            this.AdultNumericUpDown.TabIndex = 8;
            this.AdultNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ChildrenNumericUpDown
            // 
            this.ChildrenNumericUpDown.Location = new System.Drawing.Point(114, 138);
            this.ChildrenNumericUpDown.Name = "ChildrenNumericUpDown";
            this.ChildrenNumericUpDown.Size = new System.Drawing.Size(120, 19);
            this.ChildrenNumericUpDown.TabIndex = 9;
            this.ChildrenNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(159, 248);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 10;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(47, 248);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 303);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ChildrenNumericUpDown);
            this.Controls.Add(this.AdultNumericUpDown);
            this.Controls.Add(this.SeatComboBox);
            this.Controls.Add(this.TrainComboBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.大人);
            this.Controls.Add(this.NameLabel);
            this.Name = "ReservationForm";
            this.Text = "予約";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdultNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildrenNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label 大人;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox TrainComboBox;
        private System.Windows.Forms.ComboBox SeatComboBox;
        private System.Windows.Forms.NumericUpDown AdultNumericUpDown;
        private System.Windows.Forms.NumericUpDown ChildrenNumericUpDown;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}

