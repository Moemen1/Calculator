namespace Calculator
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.calculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.number1NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.operationComboBox = new System.Windows.Forms.ComboBox();
            this.number2NumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.number1NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number2NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(103, 76);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(67, 28);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "=";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultLabel.Location = new System.Drawing.Point(238, 36);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(16, 17);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "0";
            // 
            // number1NumericUpDown
            // 
            this.number1NumericUpDown.DecimalPlaces = 2;
            this.number1NumericUpDown.Location = new System.Drawing.Point(30, 37);
            this.number1NumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.number1NumericUpDown.Name = "number1NumericUpDown";
            this.number1NumericUpDown.Size = new System.Drawing.Size(61, 20);
            this.number1NumericUpDown.TabIndex = 3;
            // 
            // operationComboBox
            // 
            this.operationComboBox.FormattingEnabled = true;
            this.operationComboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.operationComboBox.Location = new System.Drawing.Point(109, 36);
            this.operationComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.operationComboBox.Name = "operationComboBox";
            this.operationComboBox.Size = new System.Drawing.Size(29, 21);
            this.operationComboBox.TabIndex = 4;
            // 
            // number2NumericUpDown
            // 
            this.number2NumericUpDown.DecimalPlaces = 2;
            this.number2NumericUpDown.Location = new System.Drawing.Point(151, 37);
            this.number2NumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.number2NumericUpDown.Name = "number2NumericUpDown";
            this.number2NumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.number2NumericUpDown.TabIndex = 5;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 113);
            this.Controls.Add(this.number2NumericUpDown);
            this.Controls.Add(this.operationComboBox);
            this.Controls.Add(this.number1NumericUpDown);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.number1NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number2NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.NumericUpDown number1NumericUpDown;
        private System.Windows.Forms.ComboBox operationComboBox;
        private System.Windows.Forms.NumericUpDown number2NumericUpDown;
    }
}

