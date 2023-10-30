
namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        private string name;
        private bool isFile;
        public Form2(string name, bool isFile)
        {
            InitializeComponent();
            this.name = name;
            this.isFile = isFile;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isFile)
                File.Create(name+"\\"+textBox1.Text).Close();
            else
                Directory.CreateDirectory(name+"\\"+textBox1.Text);
            this.Close();
        }
    }
}
