using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Penzugyi_tanacsado
{
    public partial class Új_találkozó_felvétele : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=HERNADI;Initial Catalog=tanacsado;Integrated Security=True");

        public Új_találkozó_felvétele()
        {
            InitializeComponent();
        }

        private void Új_találkozó_felvétele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tanacsadoDataSet.ugyfel' table. You can move, or remove it, as needed.
            this.ugyfelTableAdapter.Fill(this.tanacsadoDataSet.ugyfel);
            // TODO: This line of code loads data into the 'tanacsadoDataSet.tanacsado' table. You can move, or remove it, as needed.
            this.tanacsadoTableAdapter.Fill(this.tanacsadoDataSet.tanacsado);

        }

        private void Felvétel_Click(object sender, EventArgs e)
        {
            string tanacsadoNev = tanacsadoNeve.Text;
            string ugyfelNev = ugyfelNeve.Text;
            DateTime talalkodoDat = (this.talalkozoDatuma.MinDate = System.DateTime.Now);
            DateTime talalkozoIde = (this.talalkozoIdeje.MinDate = System.DateTime.Now);
            int talalkozoIdo = (int)Convert.ToInt32(talalkozoIdotartama.Value);

            connection.Open();
            //string Query = "INSERT INTO tanacsado.AllData (TanácsadóNeve,ÜgyfélNeve,TalálkozóDátuma,TalálkozóKezdésiIdőpontja,TalálkozóIdőtartama) values(" + this.tanacsadoNeve.SelectedItem.ToString()", `" + this.ugyfelNeve.SelectedItem.ToString()"')";
            //command = new SqlCommand("INSERT INTO Mentett values('"+this.tanacsadoNeve.Text+ "', '"+this.ugyfelNeve.Text+"', '"+this.talalkozoDatuma.Text+"', '"+this.talalkozoIdeje.Text+"', '"+this.talalkozoIdotartama+"')", connection);
            //command.ExecuteNonQuery();
            //MessageBox.Show("Az adatok sikeresen elmentve!");
            //connection.Close();
            
        }

        private void Mégse_Click(object sender, EventArgs e)
        {
            Form ujTalalkozo = new Form();
            this.Close();
        }
    }
}
