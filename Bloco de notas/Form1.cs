using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Bloco_de_notas
{

    public partial class Form1 : Form
    {
        DataTable CDados;
        public Form1()
        {
            InitializeComponent();
            this.FormClosed += MyClosedHandler;
            
        }

        private void TxtMensagem_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CDados = new DataTable();
            CDados.Columns.Add("Titulo", typeof(string));
            CDados.Columns.Add("Mensagem", typeof(string));

            dataGridView1.DataSource = CDados;

            dataGridView1.Columns["Mensagem"].Visible = false;
            dataGridView1.Columns["Titulo"].Width = 432;
            
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (TxtTitulo.Text != "")
            {
                CDados.Rows.Add(TxtTitulo.Text, TxtMensagem.Text);
                TxtTitulo.Clear();
                TxtMensagem.Clear();
                Aviso.Visible = false;
                
            }
            else
            {
                Aviso.Visible = true;
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TxtTitulo.Clear();
            TxtMensagem.Clear();

        }

        private void BtnLer_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                TxtTitulo.Text = CDados.Rows[index].ItemArray[0].ToString();
                TxtMensagem.Text = CDados.Rows[index].ItemArray[1].ToString();

            }
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            CDados.Rows[index].Delete();
        }


        string arquivo = "arquivo.json";
        public void serializar()
        {                           
            string json = JsonConvert.SerializeObject(CDados, Formatting.Indented);
            File.WriteAllText(arquivo, json);           
        }
        public void Carregar()
        {
            var json = File.ReadAllText(arquivo);
            var dados = JsonConvert.DeserializeObject<CDados>(json);

            dataGridView1.DataSource = dados;
        }

        public void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
    
            
        }
    }
}
