using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penzugyi_tanacsado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tanacsadoDataSet.szakterulet' table. You can move, or remove it, as needed.
            this.szakteruletTableAdapter.Fill(this.tanacsadoDataSet.szakterulet);
            // TODO: This line of code loads data into the 'tanacsadoDataSet.AllData' table. You can move, or remove it, as needed.
            this.allDataTableAdapter.Fill(this.tanacsadoDataSet.AllData);
            // TODO: This line of code loads data into the 'tanacsadoDataSet.AllData' table. You can move, or remove it, as needed.
            this.allDataTableAdapter.Fill(this.tanacsadoDataSet.AllData);

        }

        private void Szűrésbe_Click_1(object sender, EventArgs e)
        {
            bindingSourceAllDataForTable.Filter = $"SzakterületMegnevezése='{comboBox1.SelectedValue}'";
        }

        private void Szűréski_Click(object sender, EventArgs e)
        {
            bindingSourceAllDataForTable.Filter = "";
        }

        private void ExportAllData_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string fileName = Path.Combine(folderBrowserDialog1.SelectedPath, $"tanacsadok_{comboBox1.SelectedValue}_{DateTime.Now:yyyy-MM-dd}.csv");
            File.WriteAllLines(fileName, 
                tanacsadoDataSet.AllData.Select(x => string.Join(";", x.ItemArray))
                );
        }
    }
}
