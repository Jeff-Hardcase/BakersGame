namespace BakersGame
{
    partial class BakersGameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BakersGameForm));
            this.btnNewDeal = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.panelReserve0 = new System.Windows.Forms.Panel();
            this.panelReserve1 = new System.Windows.Forms.Panel();
            this.panelReserve2 = new System.Windows.Forms.Panel();
            this.panelReserve3 = new System.Windows.Forms.Panel();
            this.panelHome3 = new System.Windows.Forms.Panel();
            this.panelHome2 = new System.Windows.Forms.Panel();
            this.panelHome1 = new System.Windows.Forms.Panel();
            this.panelHome0 = new System.Windows.Forms.Panel();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.mainStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewDeal
            // 
            this.btnNewDeal.Location = new System.Drawing.Point(12, 12);
            this.btnNewDeal.Name = "btnNewDeal";
            this.btnNewDeal.Size = new System.Drawing.Size(75, 23);
            this.btnNewDeal.TabIndex = 0;
            this.btnNewDeal.Text = "New Deal";
            this.btnNewDeal.UseVisualStyleBackColor = true;
            this.btnNewDeal.Click += new System.EventHandler(this.btnNewDeal_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(12, 51);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 1;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // panelReserve0
            // 
            this.panelReserve0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelReserve0.Location = new System.Drawing.Point(119, 12);
            this.panelReserve0.Name = "panelReserve0";
            this.panelReserve0.Size = new System.Drawing.Size(88, 137);
            this.panelReserve0.TabIndex = 2;
            // 
            // panelReserve1
            // 
            this.panelReserve1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelReserve1.Location = new System.Drawing.Point(222, 12);
            this.panelReserve1.Name = "panelReserve1";
            this.panelReserve1.Size = new System.Drawing.Size(88, 137);
            this.panelReserve1.TabIndex = 3;
            // 
            // panelReserve2
            // 
            this.panelReserve2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelReserve2.Location = new System.Drawing.Point(328, 12);
            this.panelReserve2.Name = "panelReserve2";
            this.panelReserve2.Size = new System.Drawing.Size(88, 137);
            this.panelReserve2.TabIndex = 4;
            // 
            // panelReserve3
            // 
            this.panelReserve3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelReserve3.Location = new System.Drawing.Point(433, 12);
            this.panelReserve3.Name = "panelReserve3";
            this.panelReserve3.Size = new System.Drawing.Size(88, 137);
            this.panelReserve3.TabIndex = 5;
            // 
            // panelHome3
            // 
            this.panelHome3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHome3.Location = new System.Drawing.Point(965, 12);
            this.panelHome3.Name = "panelHome3";
            this.panelHome3.Size = new System.Drawing.Size(88, 137);
            this.panelHome3.TabIndex = 9;
            // 
            // panelHome2
            // 
            this.panelHome2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHome2.Location = new System.Drawing.Point(860, 12);
            this.panelHome2.Name = "panelHome2";
            this.panelHome2.Size = new System.Drawing.Size(88, 137);
            this.panelHome2.TabIndex = 8;
            // 
            // panelHome1
            // 
            this.panelHome1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHome1.Location = new System.Drawing.Point(754, 12);
            this.panelHome1.Name = "panelHome1";
            this.panelHome1.Size = new System.Drawing.Size(88, 137);
            this.panelHome1.TabIndex = 7;
            // 
            // panelHome0
            // 
            this.panelHome0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHome0.Location = new System.Drawing.Point(651, 12);
            this.panelHome0.Name = "panelHome0";
            this.panelHome0.Size = new System.Drawing.Size(88, 137);
            this.panelHome0.TabIndex = 6;
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 627);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(1079, 22);
            this.mainStatusStrip.TabIndex = 10;
            // 
            // mainStatusLabel
            // 
            this.mainStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.mainStatusLabel.Name = "mainStatusLabel";
            this.mainStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // BakersGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1079, 649);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.panelHome3);
            this.Controls.Add(this.panelHome2);
            this.Controls.Add(this.panelHome1);
            this.Controls.Add(this.panelHome0);
            this.Controls.Add(this.panelReserve3);
            this.Controls.Add(this.panelReserve2);
            this.Controls.Add(this.panelReserve1);
            this.Controls.Add(this.panelReserve0);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnNewDeal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BakersGameForm";
            this.Text = "Bakers Game";
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNewDeal;
        private Button btnLoadFile;
        private Panel panelReserve0;
        private Panel panelReserve1;
        private Panel panelReserve2;
        private Panel panelReserve3;
        private Panel panelHome3;
        private Panel panelHome2;
        private Panel panelHome1;
        private Panel panelHome0;
        private StatusStrip mainStatusStrip;
        private ToolStripStatusLabel mainStatusLabel;
    }
}