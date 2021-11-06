
namespace Income_Tax___Pension_Calculator
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
            this.catAButton = new System.Windows.Forms.RadioButton();
            this.catBButton = new System.Windows.Forms.RadioButton();
            this.selectCategoryLabel = new System.Windows.Forms.Label();
            this.yearsOfServiceLabel = new System.Windows.Forms.Label();
            this.yearsOfServiceTB = new System.Windows.Forms.TextBox();
            this.pensionLabel = new System.Windows.Forms.Label();
            this.rb0Percent = new System.Windows.Forms.RadioButton();
            this.rb5Percent = new System.Windows.Forms.RadioButton();
            this.rb3Percent = new System.Windows.Forms.RadioButton();
            this.resultsTB = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // catAButton
            // 
            this.catAButton.AutoSize = true;
            this.catAButton.Checked = true;
            this.catAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catAButton.Location = new System.Drawing.Point(8, 18);
            this.catAButton.Name = "catAButton";
            this.catAButton.Size = new System.Drawing.Size(132, 29);
            this.catAButton.TabIndex = 0;
            this.catAButton.TabStop = true;
            this.catAButton.Text = "Category A";
            this.catAButton.UseVisualStyleBackColor = true;
            // 
            // catBButton
            // 
            this.catBButton.AutoSize = true;
            this.catBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catBButton.Location = new System.Drawing.Point(187, 18);
            this.catBButton.Name = "catBButton";
            this.catBButton.Size = new System.Drawing.Size(131, 29);
            this.catBButton.TabIndex = 1;
            this.catBButton.TabStop = true;
            this.catBButton.Text = "Category B";
            this.catBButton.UseVisualStyleBackColor = true;
            // 
            // selectCategoryLabel
            // 
            this.selectCategoryLabel.AutoSize = true;
            this.selectCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCategoryLabel.Location = new System.Drawing.Point(51, 38);
            this.selectCategoryLabel.Name = "selectCategoryLabel";
            this.selectCategoryLabel.Size = new System.Drawing.Size(250, 25);
            this.selectCategoryLabel.TabIndex = 2;
            this.selectCategoryLabel.Text = "Select Employee Category:";
            // 
            // yearsOfServiceLabel
            // 
            this.yearsOfServiceLabel.AutoSize = true;
            this.yearsOfServiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsOfServiceLabel.Location = new System.Drawing.Point(51, 105);
            this.yearsOfServiceLabel.Name = "yearsOfServiceLabel";
            this.yearsOfServiceLabel.Size = new System.Drawing.Size(212, 25);
            this.yearsOfServiceLabel.TabIndex = 3;
            this.yearsOfServiceLabel.Text = "Enter Years of Service:";
            // 
            // yearsOfServiceTB
            // 
            this.yearsOfServiceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsOfServiceTB.Location = new System.Drawing.Point(360, 105);
            this.yearsOfServiceTB.Multiline = true;
            this.yearsOfServiceTB.Name = "yearsOfServiceTB";
            this.yearsOfServiceTB.Size = new System.Drawing.Size(150, 30);
            this.yearsOfServiceTB.TabIndex = 4;
            // 
            // pensionLabel
            // 
            this.pensionLabel.AutoSize = true;
            this.pensionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pensionLabel.Location = new System.Drawing.Point(51, 168);
            this.pensionLabel.Name = "pensionLabel";
            this.pensionLabel.Size = new System.Drawing.Size(269, 25);
            this.pensionLabel.TabIndex = 5;
            this.pensionLabel.Text = "Select Pension Savings Plan:";
            // 
            // rb0Percent
            // 
            this.rb0Percent.AutoSize = true;
            this.rb0Percent.Checked = true;
            this.rb0Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb0Percent.Location = new System.Drawing.Point(9, 15);
            this.rb0Percent.Name = "rb0Percent";
            this.rb0Percent.Size = new System.Drawing.Size(62, 29);
            this.rb0Percent.TabIndex = 6;
            this.rb0Percent.TabStop = true;
            this.rb0Percent.Text = "0%";
            this.rb0Percent.UseVisualStyleBackColor = true;
            // 
            // rb5Percent
            // 
            this.rb5Percent.AutoSize = true;
            this.rb5Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb5Percent.Location = new System.Drawing.Point(257, 15);
            this.rb5Percent.Name = "rb5Percent";
            this.rb5Percent.Size = new System.Drawing.Size(62, 29);
            this.rb5Percent.TabIndex = 7;
            this.rb5Percent.TabStop = true;
            this.rb5Percent.Text = "5%";
            this.rb5Percent.UseVisualStyleBackColor = true;
            // 
            // rb3Percent
            // 
            this.rb3Percent.AutoSize = true;
            this.rb3Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3Percent.Location = new System.Drawing.Point(133, 15);
            this.rb3Percent.Name = "rb3Percent";
            this.rb3Percent.Size = new System.Drawing.Size(62, 29);
            this.rb3Percent.TabIndex = 8;
            this.rb3Percent.TabStop = true;
            this.rb3Percent.Text = "3%";
            this.rb3Percent.UseVisualStyleBackColor = true;
            // 
            // resultsTB
            // 
            this.resultsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsTB.Location = new System.Drawing.Point(116, 299);
            this.resultsTB.Multiline = true;
            this.resultsTB.Name = "resultsTB";
            this.resultsTB.Size = new System.Drawing.Size(458, 153);
            this.resultsTB.TabIndex = 9;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(240, 248);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(182, 45);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(240, 458);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(182, 45);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb5Percent);
            this.groupBox1.Controls.Add(this.rb3Percent);
            this.groupBox1.Controls.Add(this.rb0Percent);
            this.groupBox1.Location = new System.Drawing.Point(351, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 58);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.catAButton);
            this.groupBox2.Controls.Add(this.catBButton);
            this.groupBox2.Location = new System.Drawing.Point(351, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 58);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 530);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultsTB);
            this.Controls.Add(this.pensionLabel);
            this.Controls.Add(this.yearsOfServiceTB);
            this.Controls.Add(this.yearsOfServiceLabel);
            this.Controls.Add(this.selectCategoryLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Net Pay Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton catAButton;
        private System.Windows.Forms.RadioButton catBButton;
        private System.Windows.Forms.Label selectCategoryLabel;
        private System.Windows.Forms.Label yearsOfServiceLabel;
        private System.Windows.Forms.TextBox yearsOfServiceTB;
        private System.Windows.Forms.Label pensionLabel;
        private System.Windows.Forms.RadioButton rb0Percent;
        private System.Windows.Forms.RadioButton rb5Percent;
        private System.Windows.Forms.RadioButton rb3Percent;
        private System.Windows.Forms.TextBox resultsTB;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

