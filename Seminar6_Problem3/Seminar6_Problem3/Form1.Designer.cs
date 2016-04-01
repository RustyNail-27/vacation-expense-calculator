namespace Seminar6_Problem3
{
    partial class MainForm
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
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.addVacationButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(12, 18);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(109, 13);
            this.locationLabel.TabIndex = 0;
            this.locationLabel.Text = "Choose a destination:";
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.Location = new System.Drawing.Point(15, 34);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(121, 95);
            this.locationListBox.TabIndex = 1;
            this.locationListBox.SelectedIndexChanged += new System.EventHandler(this.locationListBox_SelectedIndexChanged);
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(153, 34);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(72, 13);
            this.lengthLabel.TabIndex = 2;
            this.lengthLabel.Text = "Length of trip:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(153, 93);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(31, 13);
            this.costLabel.TabIndex = 3;
            this.costLabel.Text = "Cost:";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(156, 50);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(80, 20);
            this.lengthTextBox.TabIndex = 4;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(156, 109);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(80, 20);
            this.costTextBox.TabIndex = 5;
            // 
            // addVacationButton
            // 
            this.addVacationButton.Location = new System.Drawing.Point(34, 158);
            this.addVacationButton.Name = "addVacationButton";
            this.addVacationButton.Size = new System.Drawing.Size(75, 46);
            this.addVacationButton.TabIndex = 13;
            this.addVacationButton.Text = "Add Another Vacation";
            this.addVacationButton.UseVisualStyleBackColor = true;
            this.addVacationButton.Click += new System.EventHandler(this.addVacationButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(150, 158);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 46);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 244);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addVacationButton);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.locationListBox);
            this.Controls.Add(this.locationLabel);
            this.Name = "MainForm";
            this.Text = "Vacations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Button addVacationButton;
        private System.Windows.Forms.Button exitButton;
    }
}

