namespace MegaDesk_Tuttle
{
    partial class viewForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.quoteContainer = new System.Windows.Forms.Label();
            this.quoteClosetButton = new System.Windows.Forms.Button();
            this.allQuotesTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quotes";
            // 
            // quoteContainer
            // 
            this.quoteContainer.AutoSize = true;
            this.quoteContainer.Location = new System.Drawing.Point(0, 100);
            this.quoteContainer.Name = "quoteContainer";
            this.quoteContainer.Size = new System.Drawing.Size(0, 13);
            this.quoteContainer.TabIndex = 1;
            // 
            // quoteClosetButton
            // 
            this.quoteClosetButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.quoteClosetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteClosetButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quoteClosetButton.Location = new System.Drawing.Point(12, 12);
            this.quoteClosetButton.Name = "quoteClosetButton";
            this.quoteClosetButton.Size = new System.Drawing.Size(87, 38);
            this.quoteClosetButton.TabIndex = 8;
            this.quoteClosetButton.Text = "Close";
            this.quoteClosetButton.UseVisualStyleBackColor = false;
            this.quoteClosetButton.Click += new System.EventHandler(this.quoteClosetButton_Click);
            // 
            // allQuotesTextBox
            // 
            this.allQuotesTextBox.Location = new System.Drawing.Point(40, 100);
            this.allQuotesTextBox.Multiline = true;
            this.allQuotesTextBox.Name = "allQuotesTextBox";
            this.allQuotesTextBox.Size = new System.Drawing.Size(516, 229);
            this.allQuotesTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(189, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Get Quotes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.allQuotesTextBox);
            this.Controls.Add(this.quoteClosetButton);
            this.Controls.Add(this.quoteContainer);
            this.Controls.Add(this.label1);
            this.Name = "viewForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label quoteContainer;
        private System.Windows.Forms.Button quoteClosetButton;
        private System.Windows.Forms.TextBox allQuotesTextBox;
        private System.Windows.Forms.Button button1;
    }
}