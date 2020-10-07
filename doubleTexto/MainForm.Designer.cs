namespace doubleTexto
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.cdrNumer = new System.Windows.Forms.TextBox();
            this.cdrTexto = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblTxt = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cdrNumer
            // 
            this.cdrNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdrNumer.Location = new System.Drawing.Point(83, 15);
            this.cdrNumer.Margin = new System.Windows.Forms.Padding(4);
            this.cdrNumer.Name = "cdrNumer";
            this.cdrNumer.Size = new System.Drawing.Size(344, 23);
            this.cdrNumer.TabIndex = 0;
            // 
            // cdrTexto
            // 
            this.cdrTexto.AcceptsReturn = true;
            this.cdrTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdrTexto.Location = new System.Drawing.Point(83, 48);
            this.cdrTexto.Margin = new System.Windows.Forms.Padding(4);
            this.cdrTexto.Multiline = true;
            this.cdrTexto.Name = "cdrTexto";
            this.cdrTexto.Size = new System.Drawing.Size(455, 114);
            this.cdrTexto.TabIndex = 1;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(16, 18);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(58, 17);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "Numero";
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.Location = new System.Drawing.Point(16, 52);
            this.lblTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(43, 17);
            this.lblTxt.TabIndex = 3;
            this.lblTxt.Text = "Texto";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(436, 11);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 28);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convertir";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 188);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblTxt);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.cdrTexto);
            this.Controls.Add(this.cdrNumer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "doubleTexto";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button btnConvert;
		private System.Windows.Forms.TextBox cdrTexto;
		 
		private	System.Windows.Forms.Label lblTxt;
		private System.Windows.Forms.Label lblNum;
		
			private System.Windows.Forms.TextBox cdrNumer;
    }
}
