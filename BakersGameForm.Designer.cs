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
            btnNewDeal = new Button();
            btnLoadFile = new Button();
            panelReserve0 = new Panel();
            panelReserve1 = new Panel();
            panelReserve2 = new Panel();
            panelReserve3 = new Panel();
            panelHome3 = new Panel();
            panelHome2 = new Panel();
            panelHome1 = new Panel();
            panelHome0 = new Panel();
            mainStatusStrip = new StatusStrip();
            mainStatusLabel = new ToolStripStatusLabel();
            mainStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // btnNewDeal
            // 
            btnNewDeal.Location = new Point(12, 12);
            btnNewDeal.Name = "btnNewDeal";
            btnNewDeal.Size = new Size(75, 23);
            btnNewDeal.TabIndex = 0;
            btnNewDeal.Text = "New Deal";
            btnNewDeal.UseVisualStyleBackColor = true;
            btnNewDeal.Click += btnNewDeal_Click;
            // 
            // btnLoadFile
            // 
            btnLoadFile.Location = new Point(12, 51);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(75, 23);
            btnLoadFile.TabIndex = 1;
            btnLoadFile.Text = "Load File";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // panelReserve0
            // 
            panelReserve0.BorderStyle = BorderStyle.Fixed3D;
            panelReserve0.Location = new Point(120, 12);
            panelReserve0.Name = "panelReserve0";
            panelReserve0.Size = new Size(176, 274);
            panelReserve0.TabIndex = 2;
            // 
            // panelReserve1
            // 
            panelReserve1.BorderStyle = BorderStyle.Fixed3D;
            panelReserve1.Location = new Point(325, 12);
            panelReserve1.Name = "panelReserve1";
            panelReserve1.Size = new Size(176, 274);
            panelReserve1.TabIndex = 3;
            // 
            // panelReserve2
            // 
            panelReserve2.BorderStyle = BorderStyle.Fixed3D;
            panelReserve2.Location = new Point(530, 12);
            panelReserve2.Name = "panelReserve2";
            panelReserve2.Size = new Size(176, 274);
            panelReserve2.TabIndex = 4;
            // 
            // panelReserve3
            // 
            panelReserve3.BorderStyle = BorderStyle.Fixed3D;
            panelReserve3.Location = new Point(735, 12);
            panelReserve3.Name = "panelReserve3";
            panelReserve3.Size = new Size(176, 274);
            panelReserve3.TabIndex = 5;
            // 
            // panelHome3
            // 
            panelHome3.BorderStyle = BorderStyle.Fixed3D;
            panelHome3.Location = new Point(1765, 12);
            panelHome3.Name = "panelHome3";
            panelHome3.Size = new Size(176, 274);
            panelHome3.TabIndex = 9;
            // 
            // panelHome2
            // 
            panelHome2.BorderStyle = BorderStyle.Fixed3D;
            panelHome2.Location = new Point(1560, 12);
            panelHome2.Name = "panelHome2";
            panelHome2.Size = new Size(176, 274);
            panelHome2.TabIndex = 8;
            // 
            // panelHome1
            // 
            panelHome1.BorderStyle = BorderStyle.Fixed3D;
            panelHome1.Location = new Point(1355, 12);
            panelHome1.Name = "panelHome1";
            panelHome1.Size = new Size(176, 274);
            panelHome1.TabIndex = 7;
            // 
            // panelHome0
            // 
            panelHome0.BorderStyle = BorderStyle.Fixed3D;
            panelHome0.Location = new Point(1150, 12);
            panelHome0.Name = "panelHome0";
            panelHome0.Size = new Size(176, 274);
            panelHome0.TabIndex = 6;
            // 
            // mainStatusStrip
            // 
            mainStatusStrip.Items.AddRange(new ToolStripItem[] { mainStatusLabel });
            mainStatusStrip.Location = new Point(0, 1122);
            mainStatusStrip.Name = "mainStatusStrip";
            mainStatusStrip.Size = new Size(2020, 22);
            mainStatusStrip.TabIndex = 10;
            // 
            // mainStatusLabel
            // 
            mainStatusLabel.BackColor = SystemColors.Control;
            mainStatusLabel.Name = "mainStatusLabel";
            mainStatusLabel.Size = new Size(0, 17);
            // 
            // BakersGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(2020, 1144);
            Controls.Add(mainStatusStrip);
            Controls.Add(panelHome3);
            Controls.Add(panelHome2);
            Controls.Add(panelHome1);
            Controls.Add(panelHome0);
            Controls.Add(panelReserve3);
            Controls.Add(panelReserve2);
            Controls.Add(panelReserve1);
            Controls.Add(panelReserve0);
            Controls.Add(btnLoadFile);
            Controls.Add(btnNewDeal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BakersGameForm";
            Text = "Bakers Game";
            mainStatusStrip.ResumeLayout(false);
            mainStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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