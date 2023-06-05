namespace ArrayGUI01
{
    partial class frmGrades
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
            this.lblNumberGrade = new System.Windows.Forms.Label();
            this.txtNumberGrade = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtLetterGrade = new System.Windows.Forms.TextBox();
            this.lblLetterGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumberGrade
            // 
            this.lblNumberGrade.BackColor = System.Drawing.Color.Red;
            this.lblNumberGrade.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberGrade.ForeColor = System.Drawing.Color.White;
            this.lblNumberGrade.Location = new System.Drawing.Point(135, 85);
            this.lblNumberGrade.Name = "lblNumberGrade";
            this.lblNumberGrade.Size = new System.Drawing.Size(215, 47);
            this.lblNumberGrade.TabIndex = 5;
            this.lblNumberGrade.Text = "Number Grade:";
            // 
            // txtNumberGrade
            // 
            this.txtNumberGrade.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberGrade.Location = new System.Drawing.Point(368, 88);
            this.txtNumberGrade.Name = "txtNumberGrade";
            this.txtNumberGrade.Size = new System.Drawing.Size(298, 44);
            this.txtNumberGrade.TabIndex = 0;
            this.txtNumberGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(112, 323);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(163, 58);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(311, 323);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 58);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(509, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 58);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtLetterGrade
            // 
            this.txtLetterGrade.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetterGrade.Location = new System.Drawing.Point(368, 205);
            this.txtLetterGrade.Name = "txtLetterGrade";
            this.txtLetterGrade.ReadOnly = true;
            this.txtLetterGrade.Size = new System.Drawing.Size(298, 44);
            this.txtLetterGrade.TabIndex = 4;
            this.txtLetterGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLetterGrade
            // 
            this.lblLetterGrade.BackColor = System.Drawing.Color.Red;
            this.lblLetterGrade.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetterGrade.ForeColor = System.Drawing.Color.White;
            this.lblLetterGrade.Location = new System.Drawing.Point(135, 202);
            this.lblLetterGrade.Name = "lblLetterGrade";
            this.lblLetterGrade.Size = new System.Drawing.Size(215, 47);
            this.lblLetterGrade.TabIndex = 6;
            this.lblLetterGrade.Text = "Letter Grade:";
            // 
            // frmGrades
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLetterGrade);
            this.Controls.Add(this.lblLetterGrade);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNumberGrade);
            this.Controls.Add(this.lblNumberGrade);
            this.Name = "frmGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AWD11100 - C# Grade Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberGrade;
        private System.Windows.Forms.TextBox txtNumberGrade;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtLetterGrade;
        private System.Windows.Forms.Label lblLetterGrade;
    }
}

