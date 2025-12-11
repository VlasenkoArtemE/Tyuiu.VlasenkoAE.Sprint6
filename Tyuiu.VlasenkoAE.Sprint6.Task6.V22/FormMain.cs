using System.IO;
using Tyuiu.VlasenkoAE.Sprint6.Task6.V22.Lib;

namespace Tyuiu.VlasenkoAE.Sprint6.Task6.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string openFilePath;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            textBoxOut_VAE.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialogTask_VAE.ShowDialog();
            openFilePath = openFileDialogTask_VAE.FileName;
            textBoxIn_VAE.Text = File.ReadAllText(openFilePath);
            groupBoxOutput_VAE.Text = groupBoxOutput_VAE.Text + " " + openFileDialogTask_VAE.FileName;
            buttonRun_VAE.Enabled = true;
        }
    }
}
