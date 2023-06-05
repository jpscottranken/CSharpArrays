namespace ArrayGUI
{
    partial class frmArrayFun
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
            this.lstNumber = new System.Windows.Forms.ListBox();
            this.btnNewNumbers = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSortAscending = new System.Windows.Forms.Button();
            this.btnSortDescending = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRange = new System.Windows.Forms.Button();
            this.btnMedian = new System.Windows.Forms.Button();
            this.btnHighest = new System.Windows.Forms.Button();
            this.btnLowest = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNumber
            // 
            this.lstNumber.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNumber.FormattingEnabled = true;
            this.lstNumber.ItemHeight = 23;
            this.lstNumber.Location = new System.Drawing.Point(40, 33);
            this.lstNumber.Name = "lstNumber";
            this.lstNumber.Size = new System.Drawing.Size(53, 671);
            this.lstNumber.TabIndex = 12;
            // 
            // btnNewNumbers
            // 
            this.btnNewNumbers.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewNumbers.Location = new System.Drawing.Point(145, 33);
            this.btnNewNumbers.Name = "btnNewNumbers";
            this.btnNewNumbers.Size = new System.Drawing.Size(154, 49);
            this.btnNewNumbers.TabIndex = 0;
            this.btnNewNumbers.Text = "New #s";
            this.btnNewNumbers.UseVisualStyleBackColor = true;
            this.btnNewNumbers.Click += new System.EventHandler(this.btnNewNumbers_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(145, 168);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 49);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSortAscending
            // 
            this.btnSortAscending.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortAscending.Location = new System.Drawing.Point(145, 284);
            this.btnSortAscending.Name = "btnSortAscending";
            this.btnSortAscending.Size = new System.Drawing.Size(154, 49);
            this.btnSortAscending.TabIndex = 4;
            this.btnSortAscending.Text = "Sort Asc";
            this.btnSortAscending.UseVisualStyleBackColor = true;
            this.btnSortAscending.Click += new System.EventHandler(this.btnSortAscending_Click);
            // 
            // btnSortDescending
            // 
            this.btnSortDescending.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortDescending.Location = new System.Drawing.Point(145, 393);
            this.btnSortDescending.Name = "btnSortDescending";
            this.btnSortDescending.Size = new System.Drawing.Size(154, 49);
            this.btnSortDescending.TabIndex = 6;
            this.btnSortDescending.Text = "Sort Desc";
            this.btnSortDescending.UseVisualStyleBackColor = true;
            this.btnSortDescending.Click += new System.EventHandler(this.btnSortDescending_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(145, 521);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(154, 49);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(145, 658);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 49);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRange
            // 
            this.btnRange.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRange.Location = new System.Drawing.Point(368, 658);
            this.btnRange.Name = "btnRange";
            this.btnRange.Size = new System.Drawing.Size(154, 49);
            this.btnRange.TabIndex = 11;
            this.btnRange.Text = "Range";
            this.btnRange.UseVisualStyleBackColor = true;
            this.btnRange.Click += new System.EventHandler(this.btnRange_Click);
            // 
            // btnMedian
            // 
            this.btnMedian.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedian.Location = new System.Drawing.Point(368, 521);
            this.btnMedian.Name = "btnMedian";
            this.btnMedian.Size = new System.Drawing.Size(154, 49);
            this.btnMedian.TabIndex = 9;
            this.btnMedian.Text = "Median";
            this.btnMedian.UseVisualStyleBackColor = true;
            this.btnMedian.Click += new System.EventHandler(this.btnMedian_Click);
            // 
            // btnHighest
            // 
            this.btnHighest.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighest.Location = new System.Drawing.Point(368, 393);
            this.btnHighest.Name = "btnHighest";
            this.btnHighest.Size = new System.Drawing.Size(154, 49);
            this.btnHighest.TabIndex = 7;
            this.btnHighest.Text = "Highest";
            this.btnHighest.UseVisualStyleBackColor = true;
            this.btnHighest.Click += new System.EventHandler(this.btnHighest_Click);
            // 
            // btnLowest
            // 
            this.btnLowest.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLowest.Location = new System.Drawing.Point(368, 284);
            this.btnLowest.Name = "btnLowest";
            this.btnLowest.Size = new System.Drawing.Size(154, 49);
            this.btnLowest.TabIndex = 5;
            this.btnLowest.Text = "Lowest";
            this.btnLowest.UseVisualStyleBackColor = true;
            this.btnLowest.Click += new System.EventHandler(this.btnLowest_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAverage.Location = new System.Drawing.Point(368, 168);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(154, 49);
            this.btnAverage.TabIndex = 3;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.Location = new System.Drawing.Point(368, 33);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(154, 49);
            this.btnSum.TabIndex = 1;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSum;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(610, 754);
            this.Controls.Add(this.btnRange);
            this.Controls.Add(this.btnMedian);
            this.Controls.Add(this.btnHighest);
            this.Controls.Add(this.btnLowest);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSortDescending);
            this.Controls.Add(this.btnSortAscending);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNewNumbers);
            this.Controls.Add(this.lstNumber);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumber;
        private System.Windows.Forms.Button btnNewNumbers;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSortAscending;
        private System.Windows.Forms.Button btnSortDescending;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRange;
        private System.Windows.Forms.Button btnMedian;
        private System.Windows.Forms.Button btnHighest;
        private System.Windows.Forms.Button btnLowest;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnSum;
    }
}

