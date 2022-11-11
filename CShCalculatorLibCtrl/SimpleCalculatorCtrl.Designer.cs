namespace CalcualtorCtrl
{
    partial class MathCalculatorCtrl 
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultText = new System.Windows.Forms.RichTextBox();
            this.Number1Text = new System.Windows.Forms.RichTextBox();
            this.Number2Text = new System.Windows.Forms.RichTextBox();
            this.Multiply = new System.Windows.Forms.Button();
            this.Operator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(195, 86);
            this.Add.Margin = new System.Windows.Forms.Padding(4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 28);
            this.Add.TabIndex = 14;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "=";
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(68, 58);
            this.ResultText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultText.Name = "ResultText";
            this.ResultText.ReadOnly = true;
            this.ResultText.Size = new System.Drawing.Size(227, 22);
            this.ResultText.TabIndex = 12;
            this.ResultText.Text = "";
            // 
            // Number1Text
            // 
            this.Number1Text.Location = new System.Drawing.Point(13, 19);
            this.Number1Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Number1Text.Name = "Number1Text";
            this.Number1Text.Size = new System.Drawing.Size(119, 25);
            this.Number1Text.TabIndex = 11;
            this.Number1Text.Text = "";
            // 
            // Number2Text
            // 
            this.Number2Text.Location = new System.Drawing.Point(221, 19);
            this.Number2Text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Number2Text.Name = "Number2Text";
            this.Number2Text.Size = new System.Drawing.Size(105, 25);
            this.Number2Text.TabIndex = 10;
            this.Number2Text.Text = "";
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(92, 86);
            this.Multiply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(95, 30);
            this.Multiply.TabIndex = 9;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Operator
            // 
            this.Operator.AutoSize = true;
            this.Operator.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Operator.Location = new System.Drawing.Point(158, 7);
            this.Operator.Name = "Operator";
            this.Operator.Size = new System.Drawing.Size(29, 37);
            this.Operator.TabIndex = 15;
            this.Operator.Text = "?";
            // 
            // MathCalculatorCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.Operator);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.Number1Text);
            this.Controls.Add(this.Number2Text);
            this.Controls.Add(this.Multiply);
            this.Name = "MathCalculatorCtrl";
            this.Size = new System.Drawing.Size(345, 132);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox ResultText;
        private System.Windows.Forms.RichTextBox Number1Text;
        private System.Windows.Forms.RichTextBox Number2Text;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Label Operator;
    }
}
