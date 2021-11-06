
namespace Savings_Calculator
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
            this.monthlySavingsTB = new System.Windows.Forms.TextBox();
            this.monthlySavingsLabel = new System.Windows.Forms.Label();
            this.annualInterestLabel = new System.Windows.Forms.Label();
            this.numberOfMonthsTB = new System.Windows.Forms.TextBox();
            this.balanceTB = new System.Windows.Forms.TextBox();
            this.numberOfMonthsLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.nextMonthButton = new System.Windows.Forms.Button();
            this.annualInterestTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthlySavingsTB
            // 
            this.monthlySavingsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlySavingsTB.Location = new System.Drawing.Point(277, 57);
            this.monthlySavingsTB.Multiline = true;
            this.monthlySavingsTB.Name = "monthlySavingsTB";
            this.monthlySavingsTB.Size = new System.Drawing.Size(150, 30);
            this.monthlySavingsTB.TabIndex = 0;
            // 
            // monthlySavingsLabel
            // 
            this.monthlySavingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlySavingsLabel.Location = new System.Drawing.Point(42, 57);
            this.monthlySavingsLabel.Name = "monthlySavingsLabel";
            this.monthlySavingsLabel.Size = new System.Drawing.Size(216, 30);
            this.monthlySavingsLabel.TabIndex = 1;
            this.monthlySavingsLabel.Text = "Monthly Savings:";
            // 
            // annualInterestLabel
            // 
            this.annualInterestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annualInterestLabel.Location = new System.Drawing.Point(42, 124);
            this.annualInterestLabel.Name = "annualInterestLabel";
            this.annualInterestLabel.Size = new System.Drawing.Size(216, 30);
            this.annualInterestLabel.TabIndex = 3;
            this.annualInterestLabel.Text = "Annual Interest (%):";
            // 
            // numberOfMonthsTB
            // 
            this.numberOfMonthsTB.BackColor = System.Drawing.SystemColors.Menu;
            this.numberOfMonthsTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numberOfMonthsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfMonthsTB.Location = new System.Drawing.Point(277, 269);
            this.numberOfMonthsTB.Multiline = true;
            this.numberOfMonthsTB.Name = "numberOfMonthsTB";
            this.numberOfMonthsTB.ReadOnly = true;
            this.numberOfMonthsTB.Size = new System.Drawing.Size(150, 30);
            this.numberOfMonthsTB.TabIndex = 3;
            // 
            // balanceTB
            // 
            this.balanceTB.BackColor = System.Drawing.SystemColors.Menu;
            this.balanceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceTB.Location = new System.Drawing.Point(277, 336);
            this.balanceTB.Multiline = true;
            this.balanceTB.Name = "balanceTB";
            this.balanceTB.ReadOnly = true;
            this.balanceTB.Size = new System.Drawing.Size(150, 30);
            this.balanceTB.TabIndex = 4;
            // 
            // numberOfMonthsLabel
            // 
            this.numberOfMonthsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfMonthsLabel.Location = new System.Drawing.Point(42, 269);
            this.numberOfMonthsLabel.Name = "numberOfMonthsLabel";
            this.numberOfMonthsLabel.Size = new System.Drawing.Size(216, 30);
            this.numberOfMonthsLabel.TabIndex = 6;
            this.numberOfMonthsLabel.Text = "Number of Months:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(42, 336);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(216, 30);
            this.balanceLabel.TabIndex = 7;
            this.balanceLabel.Text = "Balance:";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(47, 471);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(147, 50);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // nextMonthButton
            // 
            this.nextMonthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextMonthButton.Location = new System.Drawing.Point(256, 471);
            this.nextMonthButton.Name = "nextMonthButton";
            this.nextMonthButton.Size = new System.Drawing.Size(155, 50);
            this.nextMonthButton.TabIndex = 6;
            this.nextMonthButton.Text = "Next Month";
            this.nextMonthButton.UseVisualStyleBackColor = true;
            this.nextMonthButton.Click += new System.EventHandler(this.nextMonthButton_Click);
            // 
            // annualInterestTB
            // 
            this.annualInterestTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annualInterestTB.Location = new System.Drawing.Point(277, 124);
            this.annualInterestTB.Multiline = true;
            this.annualInterestTB.Name = "annualInterestTB";
            this.annualInterestTB.Size = new System.Drawing.Size(150, 30);
            this.annualInterestTB.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 578);
            this.Controls.Add(this.annualInterestTB);
            this.Controls.Add(this.nextMonthButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.numberOfMonthsLabel);
            this.Controls.Add(this.balanceTB);
            this.Controls.Add(this.numberOfMonthsTB);
            this.Controls.Add(this.annualInterestLabel);
            this.Controls.Add(this.monthlySavingsLabel);
            this.Controls.Add(this.monthlySavingsTB);
            this.Name = "Form1";
            this.Text = "Savings Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox monthlySavingsTB;
        private System.Windows.Forms.Label monthlySavingsLabel;
        private System.Windows.Forms.Label annualInterestLabel;
        private System.Windows.Forms.TextBox numberOfMonthsTB;
        private System.Windows.Forms.TextBox balanceTB;
        private System.Windows.Forms.Label numberOfMonthsLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button nextMonthButton;
        private System.Windows.Forms.TextBox annualInterestTB;
    }
}

