using System;
using System.Windows.Forms;


namespace GridViewOne
{

    public partial class Form1 : Form
    {
        public bool ThumbnailCallback()
        {
            return false;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private System.Windows.Forms.OpenFileDialog openFileDialog1;  
        OpenFileDialog select_file = new System.Windows.Forms.OpenFileDialog();

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_file_selector_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_file_name.Text = openFileDialog1.FileName;
            }

        }
        private void AddNewRow()
        {
            int serialNumber = 0;
            dataGridView1.Rows.Add(serialNumber++, "", "", "", "", "", "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
                status_richTextBox.Text = "Completed";
            AddNewRow();

        }

    }
}