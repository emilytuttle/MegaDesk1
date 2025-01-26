namespace MegaDesk_Tuttle
{
    partial class NewQuoteForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.quoteClosetButton = new System.Windows.Forms.Button();
            this.deskWidthInput = new System.Windows.Forms.NumericUpDown();
            this.deskDepthInput = new System.Windows.Forms.NumericUpDown();
            this.numberDrawersInput = new System.Windows.Forms.NumericUpDown();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.surfaceInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.calculatedCost = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rushInputField = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.deskWidthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberDrawersInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rushInputField)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(184, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Quote";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desk Width (24-96 in)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Desk Depth (12-48 in)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of Drawers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(128, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Desktop Surface";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(173, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rush Order";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // quoteClosetButton
            // 
            this.quoteClosetButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.quoteClosetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteClosetButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quoteClosetButton.Location = new System.Drawing.Point(12, 12);
            this.quoteClosetButton.Name = "quoteClosetButton";
            this.quoteClosetButton.Size = new System.Drawing.Size(87, 38);
            this.quoteClosetButton.TabIndex = 7;
            this.quoteClosetButton.Text = "Close";
            this.quoteClosetButton.UseVisualStyleBackColor = false;
            this.quoteClosetButton.Click += new System.EventHandler(this.quoteSubmitButton_Click);
            // 
            // deskWidthInput
            // 
            this.deskWidthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.deskWidthInput.Location = new System.Drawing.Point(313, 101);
            this.deskWidthInput.Name = "deskWidthInput";
            this.deskWidthInput.Size = new System.Drawing.Size(120, 30);
            this.deskWidthInput.TabIndex = 8;
            this.deskWidthInput.ValueChanged += new System.EventHandler(this.deskWidthInput_ValueChanged);
            // 
            // deskDepthInput
            // 
            this.deskDepthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.deskDepthInput.Location = new System.Drawing.Point(313, 142);
            this.deskDepthInput.Name = "deskDepthInput";
            this.deskDepthInput.Size = new System.Drawing.Size(120, 30);
            this.deskDepthInput.TabIndex = 9;
            this.deskDepthInput.ValueChanged += new System.EventHandler(this.deskDepthInput_ValueChanged);
            // 
            // numberDrawersInput
            // 
            this.numberDrawersInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numberDrawersInput.Location = new System.Drawing.Point(313, 183);
            this.numberDrawersInput.Name = "numberDrawersInput";
            this.numberDrawersInput.Size = new System.Drawing.Size(120, 30);
            this.numberDrawersInput.TabIndex = 10;
            this.numberDrawersInput.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nameInput.Location = new System.Drawing.Point(313, 57);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(180, 30);
            this.nameInput.TabIndex = 11;
            this.nameInput.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            // 
            // surfaceInput
            // 
            this.surfaceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.surfaceInput.Location = new System.Drawing.Point(313, 219);
            this.surfaceInput.Name = "surfaceInput";
            this.surfaceInput.Size = new System.Drawing.Size(180, 30);
            this.surfaceInput.TabIndex = 12;
            this.surfaceInput.TextChanged += new System.EventHandler(this.surfaceInput_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(136, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calculatedCost
            // 
            this.calculatedCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.calculatedCost.Location = new System.Drawing.Point(313, 309);
            this.calculatedCost.Name = "calculatedCost";
            this.calculatedCost.Size = new System.Drawing.Size(180, 30);
            this.calculatedCost.TabIndex = 15;
            // 
            // rushInputField
            // 
            this.rushInputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rushInputField.Location = new System.Drawing.Point(313, 266);
            this.rushInputField.Name = "rushInputField";
            this.rushInputField.Size = new System.Drawing.Size(120, 30);
            this.rushInputField.TabIndex = 16;
            // 
            // NewQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.rushInputField);
            this.Controls.Add(this.calculatedCost);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.surfaceInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.numberDrawersInput);
            this.Controls.Add(this.deskDepthInput);
            this.Controls.Add(this.deskWidthInput);
            this.Controls.Add(this.quoteClosetButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewQuoteForm";
            this.Text = "NewQuoteForm";
            ((System.ComponentModel.ISupportInitialize)(this.deskWidthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberDrawersInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rushInputField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button quoteClosetButton;
        private System.Windows.Forms.NumericUpDown deskWidthInput;
        private System.Windows.Forms.NumericUpDown deskDepthInput;
        private System.Windows.Forms.NumericUpDown numberDrawersInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox surfaceInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox calculatedCost;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.NumericUpDown rushInputField;
    }
}