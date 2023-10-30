using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class propertiesFolder : Form
    {
        private string path;
        private DirectoryInfo info;
        public propertiesFolder(string path)
        {
            InitializeComponent();
            this.path = path;
            DirectoryInfo fl = new DirectoryInfo(path);
            info = fl;
            name.Text = fl.Name;
            location.Text = fl.FullName;
            type.Text = "Fodler";
            created.Text = fl.CreationTime.ToString();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void apply_Click(object sender, EventArgs e)
        {
            if (info.Name != name.Text) 
            {
                var newPath = path.Split('\\').SkipLast(1);
                Directory.Move(path,String.Join('\\', newPath)+"\\"+ name.Text);
            }

            this.Close();
        }
    }
}
