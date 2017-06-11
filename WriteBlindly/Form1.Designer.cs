namespace WriteBlindly
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._words = new System.Windows.Forms.ToolStripStatusLabel();
            this._lines = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.sendToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._sendClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this._sendFile = new System.Windows.Forms.ToolStripMenuItem();
            this._selectAll = new System.Windows.Forms.ToolStripMenuItem();
            this._mask = new System.Windows.Forms.ToolStripMenuItem();
            this._txt = new System.Windows.Forms.TextBox();
            this._preInput = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._words,
            this._lines,
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _words
            // 
            this._words.Name = "_words";
            this._words.Size = new System.Drawing.Size(48, 17);
            this._words.Text = "Word: 0";
            // 
            // _lines
            // 
            this._lines.Name = "_lines";
            this._lines.Size = new System.Drawing.Size(46, 17);
            this._lines.Text = "Lines: 0";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendToToolStripMenuItem,
            this._selectAll,
            this._mask});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // sendToToolStripMenuItem
            // 
            this.sendToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._sendClipboard,
            this._sendFile});
            this.sendToToolStripMenuItem.Name = "sendToToolStripMenuItem";
            this.sendToToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sendToToolStripMenuItem.Text = "Send to";
            // 
            // _sendClipboard
            // 
            this._sendClipboard.Name = "_sendClipboard";
            this._sendClipboard.Size = new System.Drawing.Size(132, 22);
            this._sendClipboard.Text = "Clipboard";
            // 
            // _sendFile
            // 
            this._sendFile.Name = "_sendFile";
            this._sendFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this._sendFile.Size = new System.Drawing.Size(132, 22);
            this._sendFile.Text = "File";
            // 
            // _selectAll
            // 
            this._selectAll.Name = "_selectAll";
            this._selectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this._selectAll.Size = new System.Drawing.Size(164, 22);
            this._selectAll.Text = "Select All";
            this._selectAll.Click += new System.EventHandler(this._selectAll_Click);
            // 
            // _mask
            // 
            this._mask.Checked = true;
            this._mask.CheckState = System.Windows.Forms.CheckState.Checked;
            this._mask.Name = "_mask";
            this._mask.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this._mask.Size = new System.Drawing.Size(164, 22);
            this._mask.Text = "Mask";
            this._mask.Click += new System.EventHandler(this._mask_Click);
            // 
            // _txt
            // 
            this._txt.AcceptsReturn = true;
            this._txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txt.Font = new System.Drawing.Font("Consolas", 10F);
            this._txt.Location = new System.Drawing.Point(0, 0);
            this._txt.Multiline = true;
            this._txt.Name = "_txt";
            this._txt.PasswordChar = '●';
            this._txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txt.Size = new System.Drawing.Size(284, 150);
            this._txt.TabIndex = 1;
            this._txt.TextChanged += new System.EventHandler(this._txt_TextChanged);
            // 
            // _preInput
            // 
            this._preInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this._preInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._preInput.Location = new System.Drawing.Point(0, 0);
            this._preInput.Multiline = true;
            this._preInput.Name = "_preInput";
            this._preInput.Size = new System.Drawing.Size(284, 85);
            this._preInput.TabIndex = 2;
            this._preInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this._preInput_KeyUp);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._txt);
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._preInput);
            this.splitContainer1.Size = new System.Drawing.Size(284, 239);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.SplitterIncrement = 25;
            this.splitContainer1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Write blindly";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel _words;
        private System.Windows.Forms.ToolStripStatusLabel _lines;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem sendToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _sendClipboard;
        private System.Windows.Forms.ToolStripMenuItem _sendFile;
        private System.Windows.Forms.ToolStripMenuItem _mask;
        private System.Windows.Forms.TextBox _txt;
        private System.Windows.Forms.ToolStripMenuItem _selectAll;
        private System.Windows.Forms.TextBox _preInput;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

