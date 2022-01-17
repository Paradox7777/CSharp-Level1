namespace guessNumber
{
    partial class Form2
    {
       
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tboxAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            this.tboxAnswer.Location = new System.Drawing.Point(27, 12);
            this.tboxAnswer.Name = "tboxAnswer";
            this.tboxAnswer.Size = new System.Drawing.Size(117, 20);
            this.tboxAnswer.TabIndex = 0;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 44);
            this.Controls.Add(this.tboxAnswer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxAnswer;
    }
}