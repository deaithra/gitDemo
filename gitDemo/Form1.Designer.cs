namespace gitDemo
{
    partial class Form1
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
            this.txt_sampleButton = new System.Windows.Forms.Button();
            this.lblSampleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_sampleButton
            // 
            this.txt_sampleButton.Location = new System.Drawing.Point(111, 86);
            this.txt_sampleButton.Name = "txt_sampleButton";
            this.txt_sampleButton.Size = new System.Drawing.Size(75, 23);
            this.txt_sampleButton.TabIndex = 0;
            this.txt_sampleButton.Text = "sample button";
            this.txt_sampleButton.UseVisualStyleBackColor = true;
            // 
            // lblSampleLabel
            // 
            this.lblSampleLabel.AutoSize = true;
            this.lblSampleLabel.Location = new System.Drawing.Point(149, 160);
            this.lblSampleLabel.Name = "lblSampleLabel";
            this.lblSampleLabel.Size = new System.Drawing.Size(65, 13);
            this.lblSampleLabel.TabIndex = 1;
            this.lblSampleLabel.Text = "sample label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblSampleLabel);
            this.Controls.Add(this.txt_sampleButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txt_sampleButton;
        private System.Windows.Forms.Label lblSampleLabel;
    }
}

