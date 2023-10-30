using System.Diagnostics;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Start();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.B))
            {
                Back();
                return true;
            }
            if (keyData == (Keys.Control | Keys.D))
            {
                try
                {
                    foreach (ListViewItem item in filesList.SelectedItems)
                    {
                        try
                        {
                            File.Delete(item.Name);

                        }
                        catch (Exception)
                        {

                        }
                        try
                        {

                            Directory.Delete(item.Name);
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
                catch (Exception)
                {

                }

                WhichTypeShouldTake(pathString.Text);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void Start()
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                TreeNode node = new TreeNode(drive.Name);

                node.Checked = false;
                node.Tag = drive;
                tree.Nodes.Add(node);
                AddSubItems(node, drive.Name);

            }
        }
        private TreeNode find(TreeNode node, string path)
        {
            if (node.Name.Split("\\").Last() == path.Split("\\").Last()) return node;
            foreach (TreeNode item in node.Nodes)
            {
                if (node.Name.Split("\\").Contains(path.Split("\\").Last()))
                {
                    return find(item, path);
                }
            }
            return null;

        }
        private void AddSubItems(TreeNode node, string path)
        {
            try
            {
                foreach (var folder in Directory.GetDirectories(path))
                {
                    TreeNode newNode = new TreeNode(folder.Split('\\').Last());
                    newNode.Checked = false;
                    newNode.Tag = folder;
                    node.Nodes.Add(newNode);

                }

            }
            catch (Exception)
            {

            }
        }
        private void FillListViewLarge(string path)
        {

            try
            {
                filesList.Items.Clear();
                foreach (var item in Directory.GetFiles(path))
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = item.Split('\\').Last();
                    listViewItem.Name = item;
                    listViewItem.ImageIndex = 2;
                    filesList.Items.Add(listViewItem);
                }
                foreach (var item in Directory.GetDirectories(path))
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = item.Split('\\').Last();
                    listViewItem.Name = item;
                    listViewItem.ImageIndex = 1;
                    filesList.Items.Add(listViewItem);
                }

            }
            catch (Exception)
            {

            }

        }
        private void FillListViewSmall(string path)
        {

            try
            {
                filesList.Items.Clear();
                foreach (var item in Directory.GetFiles(path))
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = item.Split('\\').Last();
                    listViewItem.Name = item;
                    listViewItem.ImageIndex = 2;
                    filesList.Items.Add(listViewItem);
                }
                foreach (var item in Directory.GetDirectories(path))
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Name = item;
                    listViewItem.Text = item.Split('\\').Last();
                    listViewItem.ImageIndex = 1;
                    filesList.Items.Add(listViewItem);
                }

            }
            catch (Exception)
            {

            }

        }
        private void FillListViewList(string path)
        {

            try
            {
                filesList.Items.Clear();
                foreach (var item in Directory.GetFiles(path))
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = item.Split('\\').Last();
                    listViewItem.Name = item;
                    listViewItem.ImageIndex = 2;
                    filesList.Items.Add(listViewItem);
                }
                foreach (var item in Directory.GetDirectories(path))
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = item.Split('\\').Last();
                    listViewItem.Name = item;
                    listViewItem.ImageIndex = 1;
                    filesList.Items.Add(listViewItem);
                }

            }
            catch (Exception)
            {

            }

        }
        private void FillListViewTile(string path)
        {

            try
            {
                filesList.Items.Clear();
                foreach (var item in Directory.GetFiles(path))
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = item.Split('\\').Last();
                    listViewItem.Name = item;
                    listViewItem.ImageIndex = 2;
                    filesList.Items.Add(listViewItem);
                }
                foreach (var item in Directory.GetDirectories(path))
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = item.Split('\\').Last();
                    listViewItem.Name = item;
                    listViewItem.ImageIndex = 1;
                    filesList.Items.Add(listViewItem);
                }

            }
            catch (Exception)
            {

            }

        }



        private void WhichTypeShouldTake(string path)
        {
            if (filesList.View == View.LargeIcon)
            {
                FillListViewLarge(path);
            }
            else if (filesList.View == View.SmallIcon)
            {
                FillListViewSmall(path);
            }
            else if (filesList.View == View.Tile)
            {
                FillListViewTile(path);
            }
            else if (filesList.View == View.List)
            {
                FillListViewList(path);
            }

        }
        private void tree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            pathString.Text = tree.SelectedNode.Tag.ToString();
            if (e.Node.IsEditing == false)
            {
                foreach (TreeNode i in tree.SelectedNode.Nodes)
                {
                    AddSubItems(i, i.Tag.ToString());

                }
                pathString.Text = tree.SelectedNode.Tag.ToString();
                WhichTypeShouldTake(pathString.Text);
            }
            else
            {
                foreach (TreeNode i in e.Node.Nodes)
                {
                    i.Nodes.Clear();
                }
            }

        }

        private void LargeImage_Click(object sender, EventArgs e)
        {
            filesList.View = View.LargeIcon;
            WhichTypeShouldTake(pathString.Text);
        }

        private void SmallImage_Click(object sender, EventArgs e)
        {
            filesList.View = View.SmallIcon;
            WhichTypeShouldTake(pathString.Text);
        }

        private void ListMuneItem_Click(object sender, EventArgs e)
        {

            filesList.View = View.List;
            WhichTypeShouldTake(pathString.Text);
        }

        private void tile_Click(object sender, EventArgs e)
        {

            filesList.View = View.Tile;
            WhichTypeShouldTake(pathString.Text);
        }

        private void Details_Click(object sender, EventArgs e)
        {

            filesList.View = View.Details;
            WhichTypeShouldTake(pathString.Text);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (filesList.SelectedItems.Count == 1)
                {
                    if (filesList.SelectedItems[0].ImageIndex == 2)
                    {
                        Process.Start("notepad.exe", filesList.SelectedItems[0].Name);
                    }
                    else if (filesList.SelectedItems[0].ImageIndex == 1)
                    {
                        pathString.Text = filesList.SelectedItems[0].Name;
                        WhichTypeShouldTake(pathString.Text);


                    }
                }

            }
            catch (Exception)
            {

            }
        }

        private void createFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pathString.Text == "") return;
            try
            {
                Form2 form = new Form2(pathString.Text, false);
                form.ShowDialog();
                WhichTypeShouldTake(pathString.Text);
            }
            catch (Exception)
            {

            }
        }

        private void createFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (pathString.Text == "") return;
            try
            {
                Form2 form = new Form2(pathString.Text, true);
                form.ShowDialog();
                WhichTypeShouldTake(pathString.Text);
            }
            catch (Exception)
            {

            }

        }

        private void deletToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in filesList.SelectedItems)
                {
                    try
                    {
                        File.Delete(item.Name);

                    }
                    catch (Exception)
                    {

                    }
                }
            }
            catch (Exception)
            {

            }

            WhichTypeShouldTake(pathString.Text);
        }

        private void deleteFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in filesList.SelectedItems)
                {
                    try
                    {
                        Directory.Delete(item.Name, true);

                    }
                    catch (Exception)
                    {

                    }
                }
            }
            catch (Exception)
            {

            }

            WhichTypeShouldTake(pathString.Text);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("help");
        }

        private void infromationAbout_Click(object sender, EventArgs e)
        {
            if (filesList.SelectedItems.Count == 1 && filesList.SelectedItems[0].ImageIndex == 2)
            {
                propertiesFile properties = new propertiesFile(filesList.SelectedItems[0].Name);
                properties.Show();
            }
            else if (filesList.SelectedItems.Count == 1 && filesList.SelectedItems[0].ImageIndex == 1)
            {
                propertiesFolder propertiesFolder = new propertiesFolder(filesList.SelectedItems[0].Name);
                propertiesFolder.Show();
            }
        }

        private void Back()
        {
            if (pathString.Text.Split('\\').Length > 1)
            {
                pathString.Text = String.Join("\\", pathString.Text.Split("\\").SkipLast(1)) + "\\";

                WhichTypeShouldTake(pathString.Text);
            }

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Back();
        }
    }
}