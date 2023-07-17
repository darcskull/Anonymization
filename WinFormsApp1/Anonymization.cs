using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Anonymization : Form
    {
        List<TableData> tableData;
        public Anonymization(List<TableData> tableDatas)
        {
            InitializeComponent();
            tableData = tableDatas;
            Visualize(tableData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnonymizationData form = new AnonymizationData();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private List<TableData> Anonymous(List<TableData> data, int nQ, int nK)
        {
            List<TableData> dataA = new List<TableData>();

            for (int i = 0; i < data.Count; ++i)
            {
                TableData dataAn = new TableData();
                if (nQ >= 3)
                    dataAn.Gender = TableData.GenderAnonymous();
                else
                    dataAn.Gender = data[i].Gender;
                if (nQ >= 2)
                    dataAn.Age = TableData.AgeAnonymous(data[i].Age, nK);
                else
                    dataAn.Age = data[i].Age;
                dataAn.Zip = TableData.ZipAnonymous(data[i].Zip, nK);
                if (nQ >= 4)
                    dataAn.Color = TableData.ColorAnonymous(data[i].Color, nK);
                else
                    dataAn.Color = data[i].Color;
                if (nQ >= 5)
                    dataAn.Salary = TableData.SalaryAnonymous(data[i].Salary, nK);
                else
                    dataAn.Salary = data[i].Salary;


                dataA.Add(dataAn);
            }

            return dataA;
        }

        private void Visualize(List<TableData> data)
        {
            foreach (TableData row in data)
            {
                textBoxGender.Text = textBoxGender.Text + row.Gender.ToString() + Environment.NewLine;
                textBoxAge.Text = textBoxAge.Text + row.Age.ToString() + Environment.NewLine;
                textBoxColour.Text = textBoxColour.Text + row.Color.ToString() + Environment.NewLine;
                textBoxSalary.Text = textBoxSalary.Text + row.Salary.ToString() + Environment.NewLine;
                textBoxZip.Text = textBoxZip.Text + row.Zip.ToString() + Environment.NewLine;
            }

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxAn.Text, out int value))
            {
                if(int.TryParse(textBoxQ.Text, out int qValue))
                {
                    clearTextBox();
                    List<TableData> aTable = Anonymous(tableData, qValue, value);
                    Visualize(aTable);

                }
                else
                {
                    MessageBox.Show("Invalid value for Quasi indentificators");
                }
            }
            else
            {
                MessageBox.Show("Invalid value for Anonymization level");
            }
        }

        private void clearTextBox()
        {
            textBoxGender.Text = "";
            textBoxAge.Text = "";
            textBoxColour.Text = "";
            textBoxSalary.Text = "";
            textBoxZip.Text = "";
        }
    }
}
