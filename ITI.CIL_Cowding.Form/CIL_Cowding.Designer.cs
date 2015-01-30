﻿namespace ITI.CIL_Cowding
{
    partial class Cil_Cowding
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cil_Cowding));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._richTextBox = new System.Windows.Forms.RichTextBox();
            this._panelNum = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._pictureBox2 = new System.Windows.Forms.PictureBox();
            this._groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this._pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this._butStepByStep = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this._butContinue = new System.Windows.Forms.Button();
            this._butStop = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this._butStartAll = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this._buttonBreak = new System.Windows.Forms.Button();
            this._buttonContinueRun = new System.Windows.Forms.Button();
            this._currentLineTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox2)).BeginInit();
            this._groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1143, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // _fileToolStripMenuItem
            // 
            this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.quitToolStripMenuItem});
            this._fileToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
            this._fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this._fileToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this._fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadToolStripMenuItem.Image = global::ITI.Properties.Resources.ouvrir;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToolStripMenuItem.Image = global::ITI.Properties.Resources.enregistrer;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitToolStripMenuItem.Image = global::ITI.Properties.Resources.fermer;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(8, 23);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1131, 709);
            this.splitContainer1.SplitterDistance = 464;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._currentLineTextBox);
            this.groupBox1.Controls.Add(this._richTextBox);
            this.groupBox1.Controls.Add(this._panelNum);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 705);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source Code";
            // 
            // _richTextBox
            // 
            this._richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._richTextBox.BackColor = System.Drawing.Color.White;
            this._richTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._richTextBox.ForeColor = System.Drawing.Color.Black;
            this._richTextBox.Location = new System.Drawing.Point(44, 13);
            this._richTextBox.Name = "_richTextBox";
            this._richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this._richTextBox.Size = new System.Drawing.Size(415, 688);
            this._richTextBox.TabIndex = 3;
            this._richTextBox.Text = "";
            // 
            // _panelNum
            // 
            this._panelNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._panelNum.Location = new System.Drawing.Point(4, 13);
            this._panelNum.Name = "_panelNum";
            this._panelNum.Size = new System.Drawing.Size(38, 688);
            this._panelNum.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this._groupBox3);
            this.splitContainer2.Panel2.Controls.Add(this.textBox2);
            this.splitContainer2.Size = new System.Drawing.Size(663, 709);
            this.splitContainer2.SplitterDistance = 289;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this._pictureBox2);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 281);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Canvas";
            // 
            // _pictureBox2
            // 
            this._pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this._pictureBox2.Location = new System.Drawing.Point(0, 21);
            this._pictureBox2.Name = "_pictureBox2";
            this._pictureBox2.Size = new System.Drawing.Size(656, 260);
            this._pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._pictureBox2.TabIndex = 0;
            this._pictureBox2.TabStop = false;
            this._pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this._pictureBox2_Paint);
            // 
            // _groupBox3
            // 
            this._groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._groupBox3.Controls.Add(this.panel1);
            this._groupBox3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._groupBox3.Location = new System.Drawing.Point(2, 3);
            this._groupBox3.Name = "_groupBox3";
            this._groupBox3.Size = new System.Drawing.Size(656, 412);
            this._groupBox3.TabIndex = 1;
            this._groupBox3.TabStop = false;
            this._groupBox3.Text = "Call Stack";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this._pictureBox1);
            this.panel1.Location = new System.Drawing.Point(6, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 385);
            this.panel1.TabIndex = 0;
            // 
            // _pictureBox1
            // 
            this._pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this._pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pictureBox1.Location = new System.Drawing.Point(3, 0);
            this._pictureBox1.Name = "_pictureBox1";
            this._pictureBox1.Size = new System.Drawing.Size(641, 387);
            this._pictureBox1.TabIndex = 0;
            this._pictureBox1.TabStop = false;
            this._pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this._pictureBox1_Paint);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, -134);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 96);
            this.textBox2.TabIndex = 0;
            // 
            // _butStepByStep
            // 
            this._butStepByStep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this._butStepByStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._butStepByStep.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._butStepByStep.Image = global::ITI.Properties.Resources.skip_to_start_15px;
            this._butStepByStep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._butStepByStep.Location = new System.Drawing.Point(101, 0);
            this._butStepByStep.Name = "_butStepByStep";
            this._butStepByStep.Size = new System.Drawing.Size(117, 23);
            this._butStepByStep.TabIndex = 2;
            this._butStepByStep.Text = "Step by step";
            this._butStepByStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._butStepByStep.UseVisualStyleBackColor = true;
            this._butStepByStep.Click += new System.EventHandler(this.butStepByStep_Click);
            // 
            // _butContinue
            // 
            this._butContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this._butContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._butContinue.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._butContinue.Image = ((System.Drawing.Image)(resources.GetObject("_butContinue.Image")));
            this._butContinue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._butContinue.Location = new System.Drawing.Point(135, 0);
            this._butContinue.Name = "_butContinue";
            this._butContinue.Size = new System.Drawing.Size(83, 23);
            this._butContinue.TabIndex = 5;
            this._butContinue.Text = "Continue";
            this._butContinue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._butContinue.UseVisualStyleBackColor = true;
            this._butContinue.Visible = false;
            this._butContinue.Click += new System.EventHandler(this.butContinue_Click);
            // 
            // _butStop
            // 
            this._butStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this._butStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._butStop.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._butStop.Image = ((System.Drawing.Image)(resources.GetObject("_butStop.Image")));
            this._butStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._butStop.Location = new System.Drawing.Point(235, 1);
            this._butStop.Name = "_butStop";
            this._butStop.Size = new System.Drawing.Size(56, 23);
            this._butStop.TabIndex = 6;
            this._butStop.Text = "Stop";
            this._butStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._butStop.UseVisualStyleBackColor = true;
            this._butStop.Visible = false;
            this._butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // _butStartAll
            // 
            this._butStartAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this._butStartAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._butStartAll.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._butStartAll.Image = global::ITI.Properties.Resources.skip_to_start_15px_1_;
            this._butStartAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._butStartAll.Location = new System.Drawing.Point(224, 0);
            this._butStartAll.Name = "_butStartAll";
            this._butStartAll.Size = new System.Drawing.Size(67, 23);
            this._butStartAll.TabIndex = 3;
            this._butStartAll.Text = "Start";
            this._butStartAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._butStartAll.UseVisualStyleBackColor = true;
            this._butStartAll.Click += new System.EventHandler(this.butStartAll_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            // 
            // _buttonBreak
            // 
            this._buttonBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonBreak.Font = new System.Drawing.Font("Consolas", 9F);
            this._buttonBreak.ForeColor = System.Drawing.Color.Black;
            this._buttonBreak.Image = ((System.Drawing.Image)(resources.GetObject("_buttonBreak.Image")));
            this._buttonBreak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._buttonBreak.Location = new System.Drawing.Point(319, 1);
            this._buttonBreak.Name = "_buttonBreak";
            this._buttonBreak.Size = new System.Drawing.Size(75, 23);
            this._buttonBreak.TabIndex = 7;
            this._buttonBreak.Text = "Break";
            this._buttonBreak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._buttonBreak.UseVisualStyleBackColor = true;
            this._buttonBreak.Click += new System.EventHandler(this._buttonBreak_Click);
            // 
            // _buttonContinueRun
            // 
            this._buttonContinueRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonContinueRun.Font = new System.Drawing.Font("Consolas", 9F);
            this._buttonContinueRun.Image = global::ITI.Properties.Resources.start_all_15px;
            this._buttonContinueRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._buttonContinueRun.Location = new System.Drawing.Point(297, 0);
            this._buttonContinueRun.Name = "_buttonContinueRun";
            this._buttonContinueRun.Size = new System.Drawing.Size(112, 23);
            this._buttonContinueRun.TabIndex = 8;
            this._buttonContinueRun.Text = "Continue Run";
            this._buttonContinueRun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._buttonContinueRun.UseVisualStyleBackColor = true;
            this._buttonContinueRun.Click += new System.EventHandler(this._buttonContinueRun_Click);
            // 
            // _currentLineTextBox
            // 
            this._currentLineTextBox.BackColor = System.Drawing.Color.Black;
            this._currentLineTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this._currentLineTextBox.Enabled = false;
            this._currentLineTextBox.ForeColor = System.Drawing.Color.LimeGreen;
            this._currentLineTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._currentLineTextBox.Location = new System.Drawing.Point(48, 672);
            this._currentLineTextBox.Name = "_currentLineTextBox";
            this._currentLineTextBox.Size = new System.Drawing.Size(405, 22);
            this._currentLineTextBox.TabIndex = 4;
            // 
            // Cil_Cowding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 733);
            this.Controls.Add(this._buttonContinueRun);
            this.Controls.Add(this._buttonBreak);
            this.Controls.Add(this._butStop);
            this.Controls.Add(this._butContinue);
            this.Controls.Add(this._butStartAll);
            this.Controls.Add(this._butStepByStep);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Cil_Cowding";
            this.Text = "Cil-Cowding";
            this.Load += new System.EventHandler(this.TextEditor_Load);
            this.Resize += new System.EventHandler(this.Cil_Cowding_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox2)).EndInit();
            this._groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem _fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox _groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button _butStepByStep;
        private System.Windows.Forms.PictureBox _pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button _butContinue;
        private System.Windows.Forms.Button _butStop;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox _pictureBox2;
        private System.Windows.Forms.RichTextBox _richTextBox;
        private System.Windows.Forms.Panel _panelNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _butStartAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button _buttonBreak;
        private System.Windows.Forms.Button _buttonContinueRun;
        private System.Windows.Forms.TextBox _currentLineTextBox;
    }
}
