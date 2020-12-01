namespace Audiospatial
{
    partial class Initial
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
            this.labLuda = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labLuda
            // 
            this.labLuda.AutoSize = true;
            this.labLuda.BackColor = System.Drawing.Color.Transparent;
            this.labLuda.Font = new System.Drawing.Font("Snap ITC", 90F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLuda.ForeColor = System.Drawing.Color.Green;
            this.labLuda.Location = new System.Drawing.Point(35, 102);
            this.labLuda.Margin = new System.Windows.Forms.Padding(3);
            this.labLuda.Name = "labLuda";
            this.labLuda.Size = new System.Drawing.Size(1129, 155);
            this.labLuda.TabIndex = 1;
            this.labLuda.Text = "IL BUCO NERO";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(780, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "INIZIA!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labLuda);
            this.Name = "Initial";
            this.Size = new System.Drawing.Size(984, 524);
            this.Load += new System.EventHandler(this.Initial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLuda;
        private System.Windows.Forms.Button button1;
    }
}
