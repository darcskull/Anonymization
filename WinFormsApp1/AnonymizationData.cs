using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;


namespace WinFormsApp1
{
    public partial class AnonymizationData : Form
    {
        List<TableData> tableDatas;
        public AnonymizationData()
        {
            InitializeComponent();
            tableDatas = new List<TableData>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private DataTable ImportCSV(string filePath)
        {
            DataTable dataTable = new DataTable();

            using (StreamReader reader = new StreamReader(filePath))
            {
                // Read the headers
                if (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] headers = line.Split(',');

                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }
                }

                // Read the data
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] fields = line.Split(',');

                    dataTable.Rows.Add(fields);
                }
            }

            return dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";

            try
            {
                string filePath = openFileDialog.FileName;
                DataTable dataTable = ImportCSV(filePath);

                if (dataTable != null)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        TableData data = new TableData
                        {
                            Gender = row["Gender"].ToString(),
                            Age = row["Age"].ToString(),
                            Zip = row["Zip"].ToString(),
                            Color = row["Color"].ToString(),
                            Salary = row["Salary"].ToString()
                        };

                        tableDatas.Add(data);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (tableDatas.Count > 0)
            {
                switchForms();
            }
            else
            {
                if (textBox1.Text != null && int.TryParse(textBox1.Text, out int value))
                {
                    for (int i = 0; i < value; ++i)
                    {
                        TableData tableData = new TableData();
                        tableData.Gender = TableData.GenderValue(i);
                        tableData.Age = TableData.AgeValue();
                        tableData.Zip = TableData.ZipValue();
                        tableData.Color = TableData.ColorValue();
                        tableData.Salary = TableData.SalaryValue();

                        tableDatas.Add(tableData);
                    }

                    switchForms();

                }

                MessageBox.Show("Select rows value or import valid CSV data");
            }
        }

        private void switchForms()
        {
            Anonymization form = new Anonymization(tableDatas);
            this.Hide();
            form.ShowDialog();
            this.Close();

        }
    }
}