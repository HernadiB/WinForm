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
    public partial class Pénzügyi_tanácsadás : Form
    {
        public Pénzügyi_tanácsadás()
        {
            InitializeComponent();
        }

        private void Pénzügyi_tanácsadás_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tanacsadoDataSet.szakterulet' table. You can move, or remove it, as needed.
            this.szakteruletTableAdapter.Fill(this.tanacsadoDataSet.szakterulet);
            // TODO: This line of code loads data into the 'tanacsadoDataSet.AllData' table. You can move, or remove it, as needed.
            this.allDataTableAdapter.Fill(this.tanacsadoDataSet.AllData);
            // TODO: This line of code loads data into the 'tanacsadoDataSet.AllData' table. You can move, or remove it, as needed.
            this.allDataTableAdapter.Fill(this.tanacsadoDataSet.AllData);
            Size = new Size(1000, 500);

        }

        private void Szűrésbe_Click_1(object sender, EventArgs e)
        {
            bindingSourceAllDataForTable.Filter = $"SzakterületMegnevezése='{Szakterulet.SelectedValue}'";
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
            string fileName = Path.Combine(folderBrowserDialog1.SelectedPath, $"tanacsadok_{Szakterulet.SelectedValue}_{DateTime.Now:yyyy-MM-dd}.csv");
            File.WriteAllLines(fileName, 
                tanacsadoDataSet.AllData.Select(x => string.Join(";", x.ItemArray))
                );
        }

        private void UjTalalkozoFelvetele_Click(object sender, EventArgs e)
        {
            Új_találkozó_felvétele form2 = new Új_találkozó_felvétele();
            form2.ShowDialog();
        }
    }
}
