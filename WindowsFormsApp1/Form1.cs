using System;
using System.IO;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string selectedFilePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = openFileDialog.FileName;
                    MessageBox.Show("Dosya Seçildi: " + selectedFilePath, "Dosya Seçildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Update the FilePathLabel text with the selected file path
                    txtFilePath.Text = selectedFilePath;
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("İlk Önce Bir Dosya Seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(selectedFilePath) + ".xlsx";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string savePath = saveFileDialog1.FileName;

                try
                {
                    ConvertToExcel(selectedFilePath, savePath);
                    MessageBox.Show("Dosya başarılı bir şekilde Excel'e dönüştürüldü..", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir Hata Meydana Geldi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ConvertToExcel(string filePath, string savePath)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(','); // Assuming tab-separated values
                for (int j = 0; j < data.Length; j++)
                {
                    worksheet.Cell(i + 1, j + 1).Value = data[j];
                }
            }

            workbook.SaveAs(savePath);
        }
    }
}
