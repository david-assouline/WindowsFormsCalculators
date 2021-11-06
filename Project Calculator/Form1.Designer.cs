
namespace Project_Calculator
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
            this.initialInvestmentLabel = new System.Windows.Forms.Label();
            this.yearlyRevenueLabel = new System.Windows.Forms.Label();
            this.yearlyExpensesLabel = new System.Windows.Forms.Label();
            this.initialInvestmentTB = new System.Windows.Forms.TextBox();
            this.yearlyRevenueTB = new System.Windows.Forms.TextBox();
            this.yearlyExpensesTB = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.breakEvenLabel = new System.Windows.Forms.Label();
            this.breakEvenYearTB = new System.Windows.Forms.TextBox();
            this.calculateForDoubleButton = new System.Windows.Forms.Button();
            this.cumulativeProfitLabel = new System.Windows.Forms.Label();
            this.doubleBreakEvenTB = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // initialInvestmentLabel
            // 
            this.initialInvestmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialInvestmentLabel.Location = new System.Drawing.Point(33, 40);
            this.initialInvestmentLabel.Name = "initialInvestmentLabel";
            this.initialInvestmentLabel.Size = new System.Drawing.Size(193, 30);
            this.initialInvestmentLabel.TabIndex = 0;
            this.initialInvestmentLabel.Text = "Initial Investment";
            // 
            // yearlyRevenueLabel
            // 
            this.yearlyRevenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyRevenueLabel.Location = new System.Drawing.Point(33, 85);
            this.yearlyRevenueLabel.Name = "yearlyRevenueLabel";
            this.yearlyRevenueLabel.Size = new System.Drawing.Size(193, 30);
            this.yearlyRevenueLabel.TabIndex = 1;
            this.yearlyRevenueLabel.Text = "Yearly Revenue";
            // 
            // yearlyExpensesLabel
            // 
            this.yearlyExpensesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyExpensesLabel.Location = new System.Drawing.Point(33, 130);
            this.yearlyExpensesLabel.Name = "yearlyExpensesLabel";
            this.yearlyExpensesLabel.Size = new System.Drawing.Size(193, 30);
            this.yearlyExpensesLabel.TabIndex = 2;
            this.yearlyExpensesLabel.Text = "Yearly Expenses";
            // 
            // initialInvestmentTB
            // 
            this.initialInvestmentTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialInvestmentTB.Location = new System.Drawing.Point(232, 40);
            this.initialInvestmentTB.Multiline = true;
            this.initialInvestmentTB.Name = "initialInvestmentTB";
            this.initialInvestmentTB.Size = new System.Drawing.Size(150, 30);
            this.initialInvestmentTB.TabIndex = 3;
            // 
            // yearlyRevenueTB
            // 
            this.yearlyRevenueTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyRevenueTB.Location = new System.Drawing.Point(232, 85);
            this.yearlyRevenueTB.Multiline = true;
            this.yearlyRevenueTB.Name = "yearlyRevenueTB";
            this.yearlyRevenueTB.Size = new System.Drawing.Size(150, 30);
            this.yearlyRevenueTB.TabIndex = 4;
            // 
            // yearlyExpensesTB
            // 
            this.yearlyExpensesTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyExpensesTB.Location = new System.Drawing.Point(232, 130);
            this.yearlyExpensesTB.Multiline = true;
            this.yearlyExpensesTB.Name = "yearlyExpensesTB";
            this.yearlyExpensesTB.Size = new System.Drawing.Size(150, 30);
            this.yearlyExpensesTB.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(38, 183);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(139, 38);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // breakEvenLabel
            // 
            this.breakEvenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakEvenLabel.Location = new System.Drawing.Point(33, 241);
            this.breakEvenLabel.Name = "breakEvenLabel";
            this.breakEvenLabel.Size = new System.Drawing.Size(184, 30);
            this.breakEvenLabel.TabIndex = 7;
            this.breakEvenLabel.Text = "Break Even Year";
            // 
            // breakEvenYearTB
            // 
            this.breakEvenYearTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakEvenYearTB.Location = new System.Drawing.Point(232, 241);
            this.breakEvenYearTB.Multiline = true;
            this.breakEvenYearTB.Name = "breakEvenYearTB";
            this.breakEvenYearTB.Size = new System.Drawing.Size(150, 30);
            this.breakEvenYearTB.TabIndex = 8;
            // 
            // calculateForDoubleButton
            // 
            this.calculateForDoubleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateForDoubleButton.Location = new System.Drawing.Point(38, 297);
            this.calculateForDoubleButton.Name = "calculateForDoubleButton";
            this.calculateForDoubleButton.Size = new System.Drawing.Size(139, 92);
            this.calculateForDoubleButton.TabIndex = 9;
            this.calculateForDoubleButton.Text = "Calculate for double BE years";
            this.calculateForDoubleButton.UseVisualStyleBackColor = true;
            this.calculateForDoubleButton.Click += new System.EventHandler(this.calculateForDoubleButton_Click);
            // 
            // cumulativeProfitLabel
            // 
            this.cumulativeProfitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cumulativeProfitLabel.Location = new System.Drawing.Point(223, 297);
            this.cumulativeProfitLabel.Name = "cumulativeProfitLabel";
            this.cumulativeProfitLabel.Size = new System.Drawing.Size(188, 30);
            this.cumulativeProfitLabel.TabIndex = 10;
            this.cumulativeProfitLabel.Text = "Cumulative Profit";
            // 
            // doubleBreakEvenTB
            // 
            this.doubleBreakEvenTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doubleBreakEvenTB.Location = new System.Drawing.Point(229, 339);
            this.doubleBreakEvenTB.Multiline = true;
            this.doubleBreakEvenTB.Name = "doubleBreakEvenTB";
            this.doubleBreakEvenTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.doubleBreakEvenTB.Size = new System.Drawing.Size(182, 207);
            this.doubleBreakEvenTB.TabIndex = 11;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(38, 455);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 38);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 575);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.doubleBreakEvenTB);
            this.Controls.Add(this.cumulativeProfitLabel);
            this.Controls.Add(this.calculateForDoubleButton);
            this.Controls.Add(this.breakEvenYearTB);
            this.Controls.Add(this.breakEvenLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.yearlyExpensesTB);
            this.Controls.Add(this.yearlyRevenueTB);
            this.Controls.Add(this.initialInvestmentTB);
            this.Controls.Add(this.yearlyExpensesLabel);
            this.Controls.Add(this.yearlyRevenueLabel);
            this.Controls.Add(this.initialInvestmentLabel);
            this.Name = "Form1";
            this.Text = "Project Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label initialInvestmentLabel;
        private System.Windows.Forms.Label yearlyRevenueLabel;
        private System.Windows.Forms.Label yearlyExpensesLabel;
        private System.Windows.Forms.TextBox initialInvestmentTB;
        private System.Windows.Forms.TextBox yearlyRevenueTB;
        private System.Windows.Forms.TextBox yearlyExpensesTB;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label breakEvenLabel;
        private System.Windows.Forms.TextBox breakEvenYearTB;
        private System.Windows.Forms.Button calculateForDoubleButton;
        private System.Windows.Forms.Label cumulativeProfitLabel;
        private System.Windows.Forms.TextBox doubleBreakEvenTB;
        private System.Windows.Forms.Button exitButton;
    }
}

