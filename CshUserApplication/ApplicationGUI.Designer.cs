
namespace CshApplication
{
	partial class ApplicationGUI
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
            this.m_MathCalcualtor = new MathCalcualtorCtrl.MathCalculatorCtrl();
            this.SuspendLayout();
            // 
            // m_MathCalcualtor
            // 
            this.m_MathCalcualtor.AutoSize = true;
            this.m_MathCalcualtor.Location = new System.Drawing.Point(12, 12);
            this.m_MathCalcualtor.Name = "m_MathCalcualtor";
            this.m_MathCalcualtor.Size = new System.Drawing.Size(330, 139);
            this.m_MathCalcualtor.TabIndex = 9;
            // 
            // ApplicationGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 156);
            this.Controls.Add(this.m_MathCalcualtor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ApplicationGUI";
            this.Text = "ApplicationGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private MathCalcualtorCtrl.MathCalculatorCtrl m_MathCalcualtor;
    }
}