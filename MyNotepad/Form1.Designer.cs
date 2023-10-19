namespace MyNotepad
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            newWindowToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            pageSetupToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            xoaToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            findToolStripMenuItem = new ToolStripMenuItem();
            findNextToolStripMenuItem = new ToolStripMenuItem();
            findPreviousToolStripMenuItem = new ToolStripMenuItem();
            replaceToolStripMenuItem = new ToolStripMenuItem();
            goToToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            timeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            fontToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            zoomInToolStripMenuItem = new ToolStripMenuItem();
            zoomOutToolStripMenuItem = new ToolStripMenuItem();
            restoreDefaultZoomToolStripMenuItem = new ToolStripMenuItem();
            statusBảToolStripMenuItem = new ToolStripMenuItem();
            wordWrapToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            undoToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            cutToolStripMenuItem1 = new ToolStripMenuItem();
            copyToolStripMenuItem1 = new ToolStripMenuItem();
            pasteToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            selectAllToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator9 = new ToolStripSeparator();
            rightToolStripMenuItem = new ToolStripMenuItem();
            showUnicodeToolStripMenuItem = new ToolStripMenuItem();
            insertUnicodeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator10 = new ToolStripSeparator();
            reconversionToolStripMenuItem = new ToolStripMenuItem();
            bindingSource1 = new BindingSource(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            richTextBox1 = new RichTextBox();
            pageSetupDialog1 = new PageSetupDialog();
            fontDialog1 = new FontDialog();
            printDialog1 = new PrintDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            searchWithBingToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator11 = new ToolStripSeparator();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, newWindowToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, pageSetupToolStripMenuItem, printToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(271, 26);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // newWindowToolStripMenuItem
            // 
            newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            newWindowToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            newWindowToolStripMenuItem.Size = new Size(280, 26);
            newWindowToolStripMenuItem.Text = "New window";
            newWindowToolStripMenuItem.Click += newWindowToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(280, 26);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(280, 26);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(280, 26);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(277, 6);
            // 
            // pageSetupToolStripMenuItem
            // 
            pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            pageSetupToolStripMenuItem.Size = new Size(280, 26);
            pageSetupToolStripMenuItem.Text = "Page setup";
            pageSetupToolStripMenuItem.Click += pageSetupToolStripMenuItem_Click;
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem.Size = new Size(280, 26);
            printToolStripMenuItem.Text = "&Print";
            printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(277, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(271, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, xoaToolStripMenuItem, toolStripSeparator6, findToolStripMenuItem, findNextToolStripMenuItem, findPreviousToolStripMenuItem, replaceToolStripMenuItem, goToToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem, timeToolStripMenuItem, toolStripSeparator7, fontToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "&Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(244, 26);
            undoToolStripMenuItem.Text = "&Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(241, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(244, 26);
            cutToolStripMenuItem.Text = "Cu&t";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(244, 26);
            copyToolStripMenuItem.Text = "&Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(244, 26);
            pasteToolStripMenuItem.Text = "&Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // xoaToolStripMenuItem
            // 
            xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            xoaToolStripMenuItem.ShortcutKeys = Keys.Delete;
            xoaToolStripMenuItem.Size = new Size(244, 26);
            xoaToolStripMenuItem.Text = "Delete";
            xoaToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(241, 6);
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            findToolStripMenuItem.Size = new Size(244, 26);
            findToolStripMenuItem.Text = "Find";
            // 
            // findNextToolStripMenuItem
            // 
            findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            findNextToolStripMenuItem.ShortcutKeys = Keys.F3;
            findNextToolStripMenuItem.Size = new Size(244, 26);
            findNextToolStripMenuItem.Text = "Find next";
            // 
            // findPreviousToolStripMenuItem
            // 
            findPreviousToolStripMenuItem.Name = "findPreviousToolStripMenuItem";
            findPreviousToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F3;
            findPreviousToolStripMenuItem.Size = new Size(244, 26);
            findPreviousToolStripMenuItem.Text = "Find previous";
            // 
            // replaceToolStripMenuItem
            // 
            replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            replaceToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            replaceToolStripMenuItem.Size = new Size(244, 26);
            replaceToolStripMenuItem.Text = "Replace";
            // 
            // goToToolStripMenuItem
            // 
            goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            goToToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.G;
            goToToolStripMenuItem.Size = new Size(244, 26);
            goToToolStripMenuItem.Text = "Go to";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(241, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem.Size = new Size(244, 26);
            selectAllToolStripMenuItem.Text = "Select &all";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // timeToolStripMenuItem
            // 
            timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            timeToolStripMenuItem.ShortcutKeys = Keys.F5;
            timeToolStripMenuItem.Size = new Size(244, 26);
            timeToolStripMenuItem.Text = "Time/Date";
            timeToolStripMenuItem.Click += timeToolStripMenuItem_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(241, 6);
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(244, 26);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomToolStripMenuItem, statusBảToolStripMenuItem, wordWrapToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomInToolStripMenuItem, zoomOutToolStripMenuItem, restoreDefaultZoomToolStripMenuItem });
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(165, 26);
            zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomInToolStripMenuItem
            // 
            zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            zoomInToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Oemplus;
            zoomInToolStripMenuItem.Size = new Size(285, 26);
            zoomInToolStripMenuItem.Text = "Zoom in";
            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.OemMinus;
            zoomOutToolStripMenuItem.Size = new Size(285, 26);
            zoomOutToolStripMenuItem.Text = "Zoom out";
            // 
            // restoreDefaultZoomToolStripMenuItem
            // 
            restoreDefaultZoomToolStripMenuItem.Name = "restoreDefaultZoomToolStripMenuItem";
            restoreDefaultZoomToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D0;
            restoreDefaultZoomToolStripMenuItem.Size = new Size(285, 26);
            restoreDefaultZoomToolStripMenuItem.Text = "Restore default zoom";
            // 
            // statusBảToolStripMenuItem
            // 
            statusBảToolStripMenuItem.Name = "statusBảToolStripMenuItem";
            statusBảToolStripMenuItem.Size = new Size(165, 26);
            statusBảToolStripMenuItem.Text = "Status bar";
            statusBảToolStripMenuItem.Click += statusBảToolStripMenuItem_Click;
            // 
            // wordWrapToolStripMenuItem
            // 
            wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            wordWrapToolStripMenuItem.Size = new Size(165, 26);
            wordWrapToolStripMenuItem.Text = "Word wrap";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { undoToolStripMenuItem1, toolStripSeparator5, cutToolStripMenuItem1, copyToolStripMenuItem1, pasteToolStripMenuItem1, deleteToolStripMenuItem, toolStripSeparator8, selectAllToolStripMenuItem1, toolStripSeparator9, rightToolStripMenuItem, showUnicodeToolStripMenuItem, insertUnicodeToolStripMenuItem, toolStripSeparator10, reconversionToolStripMenuItem, toolStripSeparator11, searchWithBingToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(298, 320);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // undoToolStripMenuItem1
            // 
            undoToolStripMenuItem1.Image = (Image)resources.GetObject("undoToolStripMenuItem1.Image");
            undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            undoToolStripMenuItem1.Size = new Size(297, 26);
            undoToolStripMenuItem1.Text = "Undo";
            undoToolStripMenuItem1.Click += undoToolStripMenuItem1_Click_1;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(294, 6);
            // 
            // cutToolStripMenuItem1
            // 
            cutToolStripMenuItem1.Image = (Image)resources.GetObject("cutToolStripMenuItem1.Image");
            cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            cutToolStripMenuItem1.Size = new Size(297, 26);
            cutToolStripMenuItem1.Text = "Cut";
            cutToolStripMenuItem1.Click += cutToolStripMenuItem1_Click;
            // 
            // copyToolStripMenuItem1
            // 
            copyToolStripMenuItem1.Image = (Image)resources.GetObject("copyToolStripMenuItem1.Image");
            copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            copyToolStripMenuItem1.Size = new Size(297, 26);
            copyToolStripMenuItem1.Text = "Copy";
            copyToolStripMenuItem1.Click += copyToolStripMenuItem1_Click;
            // 
            // pasteToolStripMenuItem1
            // 
            pasteToolStripMenuItem1.Image = (Image)resources.GetObject("pasteToolStripMenuItem1.Image");
            pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            pasteToolStripMenuItem1.Size = new Size(297, 26);
            pasteToolStripMenuItem1.Text = "Paste";
            pasteToolStripMenuItem1.Click += pasteToolStripMenuItem1_Click_1;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(297, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click_2;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(294, 6);
            // 
            // selectAllToolStripMenuItem1
            // 
            selectAllToolStripMenuItem1.Image = (Image)resources.GetObject("selectAllToolStripMenuItem1.Image");
            selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1";
            selectAllToolStripMenuItem1.Size = new Size(297, 26);
            selectAllToolStripMenuItem1.Text = "Select all";
            selectAllToolStripMenuItem1.Click += selectAllToolStripMenuItem1_Click_1;
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(294, 6);
            // 
            // rightToolStripMenuItem
            // 
            rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            rightToolStripMenuItem.Size = new Size(297, 26);
            rightToolStripMenuItem.Text = "Right-to-left reading order";
            rightToolStripMenuItem.Click += rightToolStripMenuItem_Click;
            // 
            // showUnicodeToolStripMenuItem
            // 
            showUnicodeToolStripMenuItem.Name = "showUnicodeToolStripMenuItem";
            showUnicodeToolStripMenuItem.Size = new Size(297, 26);
            showUnicodeToolStripMenuItem.Text = "Show unicode control characters";
            // 
            // insertUnicodeToolStripMenuItem
            // 
            insertUnicodeToolStripMenuItem.Name = "insertUnicodeToolStripMenuItem";
            insertUnicodeToolStripMenuItem.Size = new Size(297, 26);
            insertUnicodeToolStripMenuItem.Text = "Insert unicode control characters";
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new Size(294, 6);
            // 
            // reconversionToolStripMenuItem
            // 
            reconversionToolStripMenuItem.Image = (Image)resources.GetObject("reconversionToolStripMenuItem.Image");
            reconversionToolStripMenuItem.Name = "reconversionToolStripMenuItem";
            reconversionToolStripMenuItem.Size = new Size(297, 26);
            reconversionToolStripMenuItem.Text = "Reconversion";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 417);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 33);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 28);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 389);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // searchWithBingToolStripMenuItem
            // 
            searchWithBingToolStripMenuItem.Name = "searchWithBingToolStripMenuItem";
            searchWithBingToolStripMenuItem.Size = new Size(297, 26);
            searchWithBingToolStripMenuItem.Text = "Search with bing";
            // 
            // toolStripSeparator11
            // 
            toolStripSeparator11.Name = "toolStripSeparator11";
            toolStripSeparator11.Size = new Size(294, 6);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Untitled";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem newWindowToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem pageSetupToolStripMenuItem;
        private ToolStripMenuItem xoaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem findNextToolStripMenuItem;
        private ToolStripMenuItem findPreviousToolStripMenuItem;
        private ToolStripMenuItem replaceToolStripMenuItem;
        private ToolStripMenuItem goToToolStripMenuItem;
        private ToolStripMenuItem timeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem statusBảToolStripMenuItem;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripMenuItem wordWrapToolStripMenuItem;
        private ToolStripMenuItem restoreDefaultZoomToolStripMenuItem;
        private BindingSource bindingSource1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem undoToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem cutToolStripMenuItem1;
        private ToolStripMenuItem copyToolStripMenuItem1;
        private ToolStripMenuItem pasteToolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem selectAllToolStripMenuItem1;
        private ToolStripMenuItem rightToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem showUnicodeToolStripMenuItem;
        private ToolStripMenuItem insertUnicodeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem reconversionToolStripMenuItem;
        private RichTextBox richTextBox1;
        private PageSetupDialog pageSetupDialog1;
        private FontDialog fontDialog1;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripMenuItem searchWithBingToolStripMenuItem;
    }
}