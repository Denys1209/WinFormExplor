

using System.Linq;

namespace WinFormsApp3
{

    public partial class propertiesFile : Form
    {
        private string path;
        FileInfo fileInfo;
        public propertiesFile(string path)
        {
            InitializeComponent();
            this.path = path;
            fileInfo = new FileInfo(path);
            typeOfFile.Text = fileInfo.Name.Split('.').Last().ToString();
            location.Text = fileInfo.FullName;
            size.Text = fileInfo.Length.ToString();
            modified.Text = fileInfo.LastWriteTime.ToString();
            accessed.Text = fileInfo.LastAccessTime.ToString();
            create.Text = fileInfo.CreationTime.ToString();
            Name = fileInfo.Name;
            textBox1.Text = fileInfo.Name;

        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void apply_Click(object sender, EventArgs e)
        {
            if (fileInfo.Name != textBox1.Text) 
            {
                var newPath = path.Split('\\').SkipLast(1);
                File.Move(path,String.Join('\\', newPath)+"\\"+ textBox1.Text);
            }

            this.Close();
        }
    }
}
