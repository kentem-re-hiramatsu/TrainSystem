namespace TrainSystem
{
    partial class MainForm
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
            this.TrainListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.ReservationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TrainListView
            // 
            this.TrainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.TrainListView.HideSelection = false;
            this.TrainListView.Location = new System.Drawing.Point(12, 12);
            this.TrainListView.Name = "TrainListView";
            this.TrainListView.Size = new System.Drawing.Size(415, 256);
            this.TrainListView.TabIndex = 0;
            this.TrainListView.UseCompatibleStateImageBehavior = false;
            this.TrainListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名前";
            this.columnHeader1.Width = 81;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "大人";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "子供";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "電車";
            this.columnHeader4.Width = 89;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "シート";
            this.columnHeader5.Width = 83;
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.TotalPriceLabel.Location = new System.Drawing.Point(336, 283);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(91, 14);
            this.TotalPriceLabel.TabIndex = 1;
            this.TotalPriceLabel.Text = "合計金額：0円";
            // 
            // ReservationButton
            // 
            this.ReservationButton.Location = new System.Drawing.Point(13, 275);
            this.ReservationButton.Name = "ReservationButton";
            this.ReservationButton.Size = new System.Drawing.Size(80, 31);
            this.ReservationButton.TabIndex = 2;
            this.ReservationButton.Text = "予約";
            this.ReservationButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 320);
            this.Controls.Add(this.ReservationButton);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.TrainListView);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView TrainListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Button ReservationButton;
    }
}

