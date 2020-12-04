namespace Audiospatial
{
    partial class ucSpeaker
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
            this.cmbCom = new System.Windows.Forms.ComboBox();
            this.btSetCom = new System.Windows.Forms.Button();
            this.lbCom = new System.Windows.Forms.Label();
            this.btNorth = new System.Windows.Forms.Button();
            this.lbNorthConnected = new System.Windows.Forms.Label();
            this.txtFront = new System.Windows.Forms.TextBox();
            this.btWest = new System.Windows.Forms.Button();
            this.lbWestConnected = new System.Windows.Forms.Label();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.btEast = new System.Windows.Forms.Button();
            this.lbEastConnected = new System.Windows.Forms.Label();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.btUpdateBatteries = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCom
            // 
            this.cmbCom.FormattingEnabled = true;
            this.cmbCom.Location = new System.Drawing.Point(38, 50);
            this.cmbCom.Name = "cmbCom";
            this.cmbCom.Size = new System.Drawing.Size(75, 21);
            this.cmbCom.TabIndex = 10;
            this.cmbCom.SelectedIndexChanged += new System.EventHandler(this.cmbCom_SelectedIndexChanged);
            // 
            // btSetCom
            // 
            this.btSetCom.Location = new System.Drawing.Point(119, 50);
            this.btSetCom.Name = "btSetCom";
            this.btSetCom.Size = new System.Drawing.Size(35, 21);
            this.btSetCom.TabIndex = 13;
            this.btSetCom.Text = "set";
            this.btSetCom.UseVisualStyleBackColor = true;
            this.btSetCom.Click += new System.EventHandler(this.btSetCom_Click);
            // 
            // lbCom
            // 
            this.lbCom.AutoSize = true;
            this.lbCom.Location = new System.Drawing.Point(35, 34);
            this.lbCom.Name = "lbCom";
            this.lbCom.Size = new System.Drawing.Size(59, 13);
            this.lbCom.TabIndex = 14;
            this.lbCom.Text = "Porta COM";
            // 
            // btNorth
            // 
            this.btNorth.Location = new System.Drawing.Point(230, 16);
            this.btNorth.Name = "btNorth";
            this.btNorth.Size = new System.Drawing.Size(75, 49);
            this.btNorth.TabIndex = 15;
            this.btNorth.Text = "Front";
            this.btNorth.UseVisualStyleBackColor = true;
            this.btNorth.Click += new System.EventHandler(this.btNorth_Click);
            // 
            // lbNorthConnected
            // 
            this.lbNorthConnected.AutoSize = true;
            this.lbNorthConnected.Location = new System.Drawing.Point(227, 0);
            this.lbNorthConnected.Name = "lbNorthConnected";
            this.lbNorthConnected.Size = new System.Drawing.Size(71, 13);
            this.lbNorthConnected.TabIndex = 16;
            this.lbNorthConnected.Text = "disconnected";
            // 
            // txtFront
            // 
            this.txtFront.Location = new System.Drawing.Point(230, 71);
            this.txtFront.Name = "txtFront";
            this.txtFront.Size = new System.Drawing.Size(75, 20);
            this.txtFront.TabIndex = 17;
            // 
            // btWest
            // 
            this.btWest.Location = new System.Drawing.Point(79, 103);
            this.btWest.Name = "btWest";
            this.btWest.Size = new System.Drawing.Size(75, 49);
            this.btWest.TabIndex = 18;
            this.btWest.Text = "Left";
            this.btWest.UseVisualStyleBackColor = true;
            this.btWest.Click += new System.EventHandler(this.btWest_Click);
            // 
            // lbWestConnected
            // 
            this.lbWestConnected.AutoSize = true;
            this.lbWestConnected.Location = new System.Drawing.Point(76, 87);
            this.lbWestConnected.Name = "lbWestConnected";
            this.lbWestConnected.Size = new System.Drawing.Size(71, 13);
            this.lbWestConnected.TabIndex = 19;
            this.lbWestConnected.Text = "disconnected";
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(79, 158);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(75, 20);
            this.txtLeft.TabIndex = 20;
            // 
            // btEast
            // 
            this.btEast.Location = new System.Drawing.Point(363, 103);
            this.btEast.Name = "btEast";
            this.btEast.Size = new System.Drawing.Size(75, 49);
            this.btEast.TabIndex = 21;
            this.btEast.Text = "Right";
            this.btEast.UseVisualStyleBackColor = true;
            this.btEast.Click += new System.EventHandler(this.btEast_Click);
            // 
            // lbEastConnected
            // 
            this.lbEastConnected.AutoSize = true;
            this.lbEastConnected.Location = new System.Drawing.Point(367, 87);
            this.lbEastConnected.Name = "lbEastConnected";
            this.lbEastConnected.Size = new System.Drawing.Size(71, 13);
            this.lbEastConnected.TabIndex = 22;
            this.lbEastConnected.Text = "disconnected";
            // 
            // txtRight
            // 
            this.txtRight.Location = new System.Drawing.Point(363, 158);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(75, 20);
            this.txtRight.TabIndex = 23;
            // 
            // btUpdateBatteries
            // 
            this.btUpdateBatteries.Location = new System.Drawing.Point(310, 210);
            this.btUpdateBatteries.Name = "btUpdateBatteries";
            this.btUpdateBatteries.Size = new System.Drawing.Size(195, 35);
            this.btUpdateBatteries.TabIndex = 24;
            this.btUpdateBatteries.Text = "UPDATE INFO";
            this.btUpdateBatteries.UseVisualStyleBackColor = true;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(103, 210);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(195, 35);
            this.btReset.TabIndex = 25;
            this.btReset.Text = "RESET SPEAKERS";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(103, 251);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(402, 35);
            this.btClose.TabIndex = 26;
            this.btClose.Text = "CLOSE";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btAll
            // 
            this.btAll.Location = new System.Drawing.Point(230, 115);
            this.btAll.Name = "btAll";
            this.btAll.Size = new System.Drawing.Size(75, 49);
            this.btAll.TabIndex = 27;
            this.btAll.Text = "all";
            this.btAll.UseVisualStyleBackColor = true;
            this.btAll.Click += new System.EventHandler(this.btAll_Click);
            // 
            // ucSpeaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btAll);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btUpdateBatteries);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.lbEastConnected);
            this.Controls.Add(this.btEast);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.lbWestConnected);
            this.Controls.Add(this.btWest);
            this.Controls.Add(this.txtFront);
            this.Controls.Add(this.lbNorthConnected);
            this.Controls.Add(this.btNorth);
            this.Controls.Add(this.lbCom);
            this.Controls.Add(this.btSetCom);
            this.Controls.Add(this.cmbCom);
            this.Name = "ucSpeaker";
            this.Size = new System.Drawing.Size(551, 347);
            this.Load += new System.EventHandler(this.ucSpeaker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCom;
        private System.Windows.Forms.Button btSetCom;
        private System.Windows.Forms.Label lbCom;
        private System.Windows.Forms.Button btNorth;
        private System.Windows.Forms.Label lbNorthConnected;
        private System.Windows.Forms.TextBox txtFront;
        private System.Windows.Forms.Button btWest;
        private System.Windows.Forms.Label lbWestConnected;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.Button btEast;
        private System.Windows.Forms.Label lbEastConnected;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.Button btUpdateBatteries;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btAll;
    }
}
