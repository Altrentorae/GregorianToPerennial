namespace GregorianToPerennial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateIN = new System.Windows.Forms.DateTimePicker();
            this.outputBX = new System.Windows.Forms.Label();
            this.sundayStrtTRUE = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dateIN
            // 
            this.dateIN.Location = new System.Drawing.Point(12, 12);
            this.dateIN.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateIN.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateIN.Name = "dateIN";
            this.dateIN.Size = new System.Drawing.Size(200, 20);
            this.dateIN.TabIndex = 0;
            this.dateIN.TabStop = false;
            this.dateIN.Value = new System.DateTime(2017, 3, 13, 15, 49, 38, 0);
            this.dateIN.ValueChanged += new System.EventHandler(this.dateIN_ValueChanged);
            // 
            // outputBX
            // 
            this.outputBX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputBX.Location = new System.Drawing.Point(12, 72);
            this.outputBX.Name = "outputBX";
            this.outputBX.Size = new System.Drawing.Size(199, 49);
            this.outputBX.TabIndex = 1;
            this.outputBX.Text = "Output";
            this.outputBX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sundayStrtTRUE
            // 
            this.sundayStrtTRUE.AutoSize = true;
            this.sundayStrtTRUE.Location = new System.Drawing.Point(12, 38);
            this.sundayStrtTRUE.Name = "sundayStrtTRUE";
            this.sundayStrtTRUE.Size = new System.Drawing.Size(136, 17);
            this.sundayStrtTRUE.TabIndex = 2;
            this.sundayStrtTRUE.Text = "Week Start on Monday\r\n";
            this.sundayStrtTRUE.UseVisualStyleBackColor = true;
            this.sundayStrtTRUE.CheckedChanged += new System.EventHandler(this.sundayStrtTRUE_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(229, 130);
            this.Controls.Add(this.sundayStrtTRUE);
            this.Controls.Add(this.outputBX);
            this.Controls.Add(this.dateIN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gregorian to IFC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateIN;
        private System.Windows.Forms.Label outputBX;
        private System.Windows.Forms.CheckBox sundayStrtTRUE;
    }
}

