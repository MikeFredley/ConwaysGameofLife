namespace Fredley_GOL
{
    partial class GOLBoard
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
            this.panGrid = new System.Windows.Forms.Panel();
            this.btnShowGrid = new System.Windows.Forms.Button();
            this.btGenRandom = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblAlive = new System.Windows.Forms.Label();
            this.lblDead = new System.Windows.Forms.Label();
            this.lstTest = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblYellow = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblMagenta = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblCoordinates = new System.Windows.Forms.Label();
            this.lblCoord = new System.Windows.Forms.Label();
            this.lblGeneration = new System.Windows.Forms.Label();
            this.btnBeacon = new System.Windows.Forms.Button();
            this.btnGrowth = new System.Windows.Forms.Button();
            this.btnPulsar = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panGrid
            // 
            this.panGrid.Location = new System.Drawing.Point(0, 0);
            this.panGrid.Name = "panGrid";
            this.panGrid.Size = new System.Drawing.Size(1241, 841);
            this.panGrid.TabIndex = 0;
            this.panGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panGrid_MouseMove);
            // 
            // btnShowGrid
            // 
            this.btnShowGrid.Location = new System.Drawing.Point(1264, 238);
            this.btnShowGrid.Name = "btnShowGrid";
            this.btnShowGrid.Size = new System.Drawing.Size(99, 50);
            this.btnShowGrid.TabIndex = 1;
            this.btnShowGrid.Text = "Generate Grid";
            this.btnShowGrid.UseVisualStyleBackColor = true;
            this.btnShowGrid.Click += new System.EventHandler(this.btnShowGrid_Click);
            // 
            // btGenRandom
            // 
            this.btGenRandom.Location = new System.Drawing.Point(1264, 294);
            this.btGenRandom.Name = "btGenRandom";
            this.btGenRandom.Size = new System.Drawing.Size(99, 50);
            this.btGenRandom.TabIndex = 0;
            this.btGenRandom.Text = "Generate Random";
            this.btGenRandom.UseVisualStyleBackColor = true;
            this.btGenRandom.Click += new System.EventHandler(this.btGenRandom_Click);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(1338, 9);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(25, 13);
            this.lblKey.TabIndex = 2;
            this.lblKey.Text = "Key";
            // 
            // lblAlive
            // 
            this.lblAlive.AutoSize = true;
            this.lblAlive.Location = new System.Drawing.Point(1337, 33);
            this.lblAlive.Name = "lblAlive";
            this.lblAlive.Size = new System.Drawing.Size(42, 13);
            this.lblAlive.TabIndex = 3;
            this.lblAlive.Text = "Alive: 0";
            // 
            // lblDead
            // 
            this.lblDead.AutoSize = true;
            this.lblDead.Location = new System.Drawing.Point(1334, 166);
            this.lblDead.Name = "lblDead";
            this.lblDead.Size = new System.Drawing.Size(45, 13);
            this.lblDead.TabIndex = 4;
            this.lblDead.Text = "Dead: 0";
            // 
            // lstTest
            // 
            this.lstTest.FormattingEnabled = true;
            this.lstTest.Location = new System.Drawing.Point(1264, 616);
            this.lstTest.Name = "lstTest";
            this.lstTest.Size = new System.Drawing.Size(234, 225);
            this.lstTest.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(1369, 238);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 50);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Location = new System.Drawing.Point(1369, 294);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(96, 20);
            this.txtTime.TabIndex = 6;
            // 
            // lblYellow
            // 
            this.lblYellow.AutoSize = true;
            this.lblYellow.Location = new System.Drawing.Point(1304, 55);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(75, 13);
            this.lblYellow.TabIndex = 7;
            this.lblYellow.Text = "Yellow Cells: 0";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(1306, 77);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(73, 13);
            this.lblGreen.TabIndex = 8;
            this.lblGreen.Text = "Green Cells: 0";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(1314, 99);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(65, 13);
            this.lblBlue.TabIndex = 9;
            this.lblBlue.Text = "Blue Cells: 0";
            // 
            // lblMagenta
            // 
            this.lblMagenta.AutoSize = true;
            this.lblMagenta.Location = new System.Drawing.Point(1293, 121);
            this.lblMagenta.Name = "lblMagenta";
            this.lblMagenta.Size = new System.Drawing.Size(86, 13);
            this.lblMagenta.TabIndex = 10;
            this.lblMagenta.Text = "Magenta Cells: 0";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(1315, 144);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(64, 13);
            this.lblRed.TabIndex = 11;
            this.lblRed.Text = "Red Cells: 0";
            // 
            // lblCoordinates
            // 
            this.lblCoordinates.AutoSize = true;
            this.lblCoordinates.Location = new System.Drawing.Point(1261, 210);
            this.lblCoordinates.Name = "lblCoordinates";
            this.lblCoordinates.Size = new System.Drawing.Size(111, 13);
            this.lblCoordinates.TabIndex = 13;
            this.lblCoordinates.Text = "Coordinates of Cursor:";
            // 
            // lblCoord
            // 
            this.lblCoord.AutoSize = true;
            this.lblCoord.Location = new System.Drawing.Point(1378, 210);
            this.lblCoord.Name = "lblCoord";
            this.lblCoord.Size = new System.Drawing.Size(25, 13);
            this.lblCoord.TabIndex = 14;
            this.lblCoord.Text = "0, 0";
            // 
            // lblGeneration
            // 
            this.lblGeneration.AutoSize = true;
            this.lblGeneration.Location = new System.Drawing.Point(1308, 188);
            this.lblGeneration.Name = "lblGeneration";
            this.lblGeneration.Size = new System.Drawing.Size(71, 13);
            this.lblGeneration.TabIndex = 15;
            this.lblGeneration.Text = "Generation: 0";
            // 
            // btnBeacon
            // 
            this.btnBeacon.Location = new System.Drawing.Point(1369, 350);
            this.btnBeacon.Name = "btnBeacon";
            this.btnBeacon.Size = new System.Drawing.Size(99, 50);
            this.btnBeacon.TabIndex = 21;
            this.btnBeacon.Text = "Insert Beacon";
            this.btnBeacon.UseVisualStyleBackColor = true;
            this.btnBeacon.Click += new System.EventHandler(this.btnBeacon_Click);
            // 
            // btnGrowth
            // 
            this.btnGrowth.Location = new System.Drawing.Point(1264, 406);
            this.btnGrowth.Name = "btnGrowth";
            this.btnGrowth.Size = new System.Drawing.Size(99, 50);
            this.btnGrowth.TabIndex = 20;
            this.btnGrowth.Text = "Insert Infinite Growth";
            this.btnGrowth.UseVisualStyleBackColor = true;
            this.btnGrowth.Click += new System.EventHandler(this.btnGrowth_Click);
            // 
            // btnPulsar
            // 
            this.btnPulsar.Location = new System.Drawing.Point(1264, 350);
            this.btnPulsar.Name = "btnPulsar";
            this.btnPulsar.Size = new System.Drawing.Size(99, 50);
            this.btnPulsar.TabIndex = 19;
            this.btnPulsar.Text = "Insert Pulsar";
            this.btnPulsar.UseVisualStyleBackColor = true;
            this.btnPulsar.Click += new System.EventHandler(this.btnPulsar_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(1369, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 50);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1369, 462);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(99, 50);
            this.btnLoad.TabIndex = 23;
            this.btnLoad.Text = "Load File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // GOLBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBeacon);
            this.Controls.Add(this.btnGrowth);
            this.Controls.Add(this.btnPulsar);
            this.Controls.Add(this.lblGeneration);
            this.Controls.Add(this.lblCoord);
            this.Controls.Add(this.lblCoordinates);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblMagenta);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblYellow);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lstTest);
            this.Controls.Add(this.lblDead);
            this.Controls.Add(this.lblAlive);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.btGenRandom);
            this.Controls.Add(this.btnShowGrid);
            this.Controls.Add(this.panGrid);
            this.Name = "GOLBoard";
            this.Text = "The Game Of Life";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panGrid;
        private System.Windows.Forms.Button btnShowGrid;
        private System.Windows.Forms.Button btGenRandom;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblAlive;
        private System.Windows.Forms.Label lblDead;
        private System.Windows.Forms.ListBox lstTest;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblMagenta;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblCoordinates;
        private System.Windows.Forms.Label lblCoord;
        private System.Windows.Forms.Label lblGeneration;
        private System.Windows.Forms.Button btnBeacon;
        private System.Windows.Forms.Button btnGrowth;
        private System.Windows.Forms.Button btnPulsar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}

