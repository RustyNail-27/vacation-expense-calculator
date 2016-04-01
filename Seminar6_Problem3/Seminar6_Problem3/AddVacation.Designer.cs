namespace Seminar6_Problem3
{
    partial class AddVacation
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
            this.newCostLabel = new System.Windows.Forms.Label();
            this.newLenghlLabel = new System.Windows.Forms.Label();
            this.newLocLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.newLocationTextBox = new System.Windows.Forms.TextBox();
            this.newLengthTextBox = new System.Windows.Forms.TextBox();
            this.newCostTextBox = new System.Windows.Forms.TextBox();
            this.newVacationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newCostLabel
            // 
            this.newCostLabel.AutoSize = true;
            this.newCostLabel.Location = new System.Drawing.Point(52, 125);
            this.newCostLabel.Name = "newCostLabel";
            this.newCostLabel.Size = new System.Drawing.Size(31, 13);
            this.newCostLabel.TabIndex = 0;
            this.newCostLabel.Text = "Cost:";
            this.newCostLabel.Click += new System.EventHandler(this.newCostLabel_Click);
            // 
            // newLenghlLabel
            // 
            this.newLenghlLabel.AutoSize = true;
            this.newLenghlLabel.Location = new System.Drawing.Point(7, 87);
            this.newLenghlLabel.Name = "newLenghlLabel";
            this.newLenghlLabel.Size = new System.Drawing.Size(108, 13);
            this.newLenghlLabel.TabIndex = 1;
            this.newLenghlLabel.Text = "Length of trip in days:";
            // 
            // newLocLabel
            // 
            this.newLocLabel.AutoSize = true;
            this.newLocLabel.Location = new System.Drawing.Point(32, 48);
            this.newLocLabel.Name = "newLocLabel";
            this.newLocLabel.Size = new System.Drawing.Size(51, 13);
            this.newLocLabel.TabIndex = 2;
            this.newLocLabel.Text = "Location:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(113, 165);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(23, 165);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // newLocationTextBox
            // 
            this.newLocationTextBox.Location = new System.Drawing.Point(88, 45);
            this.newLocationTextBox.Name = "newLocationTextBox";
            this.newLocationTextBox.Size = new System.Drawing.Size(100, 20);
            this.newLocationTextBox.TabIndex = 5;
            // 
            // newLengthTextBox
            // 
            this.newLengthTextBox.Location = new System.Drawing.Point(121, 84);
            this.newLengthTextBox.Name = "newLengthTextBox";
            this.newLengthTextBox.Size = new System.Drawing.Size(67, 20);
            this.newLengthTextBox.TabIndex = 6;
            // 
            // newCostTextBox
            // 
            this.newCostTextBox.Location = new System.Drawing.Point(88, 122);
            this.newCostTextBox.Name = "newCostTextBox";
            this.newCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.newCostTextBox.TabIndex = 7;
            // 
            // newVacationLabel
            // 
            this.newVacationLabel.AutoSize = true;
            this.newVacationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newVacationLabel.Location = new System.Drawing.Point(31, 9);
            this.newVacationLabel.Name = "newVacationLabel";
            this.newVacationLabel.Size = new System.Drawing.Size(150, 20);
            this.newVacationLabel.TabIndex = 8;
            this.newVacationLabel.Text = "Enter New Vacation";
            // 
            // AddVacation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 215);
            this.Controls.Add(this.newVacationLabel);
            this.Controls.Add(this.newCostTextBox);
            this.Controls.Add(this.newLengthTextBox);
            this.Controls.Add(this.newLocationTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.newLocLabel);
            this.Controls.Add(this.newLenghlLabel);
            this.Controls.Add(this.newCostLabel);
            this.Name = "AddVacation";
            this.Text = "AddVacation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newCostLabel;
        private System.Windows.Forms.Label newLenghlLabel;
        private System.Windows.Forms.Label newLocLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox newLocationTextBox;
        private System.Windows.Forms.TextBox newLengthTextBox;
        private System.Windows.Forms.TextBox newCostTextBox;
        private System.Windows.Forms.Label newVacationLabel;
    }
}