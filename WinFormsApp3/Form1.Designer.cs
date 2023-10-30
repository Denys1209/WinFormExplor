namespace WinFormsApp3
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
            tree = new TreeView();
            smallImages = new ImageList(components);
            LargeImages = new ImageList(components);
            filesList = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            openToolStripMenuItem = new ToolStripMenuItem();
            createFolderToolStripMenuItem = new ToolStripMenuItem();
            createFileToolStripMenuItem = new ToolStripMenuItem();
            deletToolStripMenuItem = new ToolStripMenuItem();
            deletToolStripMenuItem1 = new ToolStripMenuItem();
            deleteFolderToolStripMenuItem = new ToolStripMenuItem();
            pathString = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            LargeImage = new ToolStripMenuItem();
            SmallImage = new ToolStripMenuItem();
            ListMuneItem = new ToolStripMenuItem();
            tile = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            infromationAbout = new ToolStripButton();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tree
            // 
            tree.Location = new Point(12, 93);
            tree.Name = "tree";
            tree.ShowRootLines = false;
            tree.Size = new Size(181, 385);
            tree.TabIndex = 0;
            tree.NodeMouseDoubleClick += tree_NodeMouseDoubleClick;
            // 
            // smallImages
            // 
            smallImages.ColorDepth = ColorDepth.Depth8Bit;
            smallImages.ImageStream = (ImageListStreamer)resources.GetObject("smallImages.ImageStream");
            smallImages.TransparentColor = Color.Transparent;
            smallImages.Images.SetKeyName(0, "1.jpg");
            smallImages.Images.SetKeyName(1, "3.png");
            smallImages.Images.SetKeyName(2, "4.png");
            // 
            // LargeImages
            // 
            LargeImages.ColorDepth = ColorDepth.Depth8Bit;
            LargeImages.ImageStream = (ImageListStreamer)resources.GetObject("LargeImages.ImageStream");
            LargeImages.TransparentColor = Color.Transparent;
            LargeImages.Images.SetKeyName(0, "1.jpg");
            LargeImages.Images.SetKeyName(1, "3.png");
            LargeImages.Images.SetKeyName(2, "4.png");
            // 
            // filesList
            // 
            filesList.ContextMenuStrip = contextMenuStrip1;
            filesList.LargeImageList = LargeImages;
            filesList.Location = new Point(199, 93);
            filesList.Name = "filesList";
            filesList.Size = new Size(589, 385);
            filesList.SmallImageList = smallImages;
            filesList.TabIndex = 1;
            filesList.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem, createFolderToolStripMenuItem, createFileToolStripMenuItem, deletToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(141, 92);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(140, 22);
            openToolStripMenuItem.Text = "open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // createFolderToolStripMenuItem
            // 
            createFolderToolStripMenuItem.Name = "createFolderToolStripMenuItem";
            createFolderToolStripMenuItem.Size = new Size(140, 22);
            createFolderToolStripMenuItem.Text = "create folder";
            createFolderToolStripMenuItem.Click += createFolderToolStripMenuItem_Click;
            // 
            // createFileToolStripMenuItem
            // 
            createFileToolStripMenuItem.Name = "createFileToolStripMenuItem";
            createFileToolStripMenuItem.Size = new Size(140, 22);
            createFileToolStripMenuItem.Text = "create file";
            createFileToolStripMenuItem.Click += createFileToolStripMenuItem_Click;
            // 
            // deletToolStripMenuItem
            // 
            deletToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deletToolStripMenuItem1, deleteFolderToolStripMenuItem });
            deletToolStripMenuItem.Name = "deletToolStripMenuItem";
            deletToolStripMenuItem.Size = new Size(140, 22);
            deletToolStripMenuItem.Text = "delete";
            // 
            // deletToolStripMenuItem1
            // 
            deletToolStripMenuItem1.Name = "deletToolStripMenuItem1";
            deletToolStripMenuItem1.Size = new Size(140, 22);
            deletToolStripMenuItem1.Text = "delete file";
            deletToolStripMenuItem1.Click += deletToolStripMenuItem1_Click;
            // 
            // deleteFolderToolStripMenuItem
            // 
            deleteFolderToolStripMenuItem.Name = "deleteFolderToolStripMenuItem";
            deleteFolderToolStripMenuItem.Size = new Size(140, 22);
            deleteFolderToolStripMenuItem.Text = "delete folder";
            deleteFolderToolStripMenuItem.Click += deleteFolderToolStripMenuItem_Click;
            // 
            // pathString
            // 
            pathString.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            pathString.Location = new Point(12, 52);
            pathString.Name = "pathString";
            pathString.ReadOnly = true;
            pathString.Size = new Size(776, 39);
            pathString.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { helpToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(180, 22);
            helpToolStripMenuItem.Text = "help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(180, 22);
            closeToolStripMenuItem.Text = "close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { LargeImage, SmallImage, ListMuneItem, tile });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // LargeImage
            // 
            LargeImage.Name = "LargeImage";
            LargeImage.Size = new Size(139, 22);
            LargeImage.Text = "Large image";
            LargeImage.Click += LargeImage_Click;
            // 
            // SmallImage
            // 
            SmallImage.Name = "SmallImage";
            SmallImage.Size = new Size(139, 22);
            SmallImage.Text = "Small Image";
            SmallImage.Click += SmallImage_Click;
            // 
            // ListMuneItem
            // 
            ListMuneItem.Name = "ListMuneItem";
            ListMuneItem.Size = new Size(139, 22);
            ListMuneItem.Text = "list";
            ListMuneItem.Click += ListMuneItem_Click;
            // 
            // tile
            // 
            tile.Name = "tile";
            tile.Size = new Size(139, 22);
            tile.Text = "tile";
            tile.Click += tile_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, infromationAbout });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "back";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // infromationAbout
            // 
            infromationAbout.DisplayStyle = ToolStripItemDisplayStyle.Image;
            infromationAbout.Image = (Image)resources.GetObject("infromationAbout.Image");
            infromationAbout.ImageTransparentColor = Color.Magenta;
            infromationAbout.Name = "infromationAbout";
            infromationAbout.Size = new Size(23, 22);
            infromationAbout.Text = "properties";
            infromationAbout.Click += infromationAbout_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 490);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(pathString);
            Controls.Add(filesList);
            Controls.Add(tree);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView tree;
        private ListView filesList;
        protected ImageList LargeImages;
        private TextBox pathString;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ImageList smallImages;
        private ToolStripMenuItem LargeImage;
        private ToolStripMenuItem SmallImage;
        private ToolStripMenuItem ListMuneItem;
        private ToolStripMenuItem tile;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem createFolderToolStripMenuItem;
        private ToolStripMenuItem createFileToolStripMenuItem;
        private ToolStripMenuItem deletToolStripMenuItem;
        private ToolStripMenuItem deletToolStripMenuItem1;
        private ToolStripMenuItem deleteFolderToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton infromationAbout;
        private ToolStripButton toolStripButton1;
    }
}