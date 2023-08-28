using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.Json;
using System.IO;

namespace Bakery_stock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Produto
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public DateTime Validade { get; set; }
            public string Fornecedor { get; set; }
            public int Quantidade { get; set; }
            public int Preco { get; set; }

        }

        private void criar_Click(object sender, EventArgs e)
        {
            DateTime d = new DateTime(2021, 12, 31);

            // Criar uma lista de objetos do tipo Pessoa
            List<Produto> produtos = new List<Produto>();
            produtos.Add(new Produto {Id = 0, Nome = "a", Validade = d, Fornecedor = "b", Quantidade = 0, Preco = 0 });
            

            // Transformar a lista em uma string json
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(produtos);

            // Escrever a string json em um arquivo
            File.WriteAllText("Prod.json", json);


            var form = new Tabela(); // Cria um objeto do tipo Tabela
            form.Show(); // Exibe o form Tabela
            this.Hide(); // Esconde o form Form1
        }

        private void carregar_Click(object sender, EventArgs e)
        {
            var form = new Tabela(); // Cria um objeto do tipo Tabela
            form.Show(); // Exibe o form Tabela
            this.Hide(); // Esconde o form Form1
        }
    }
}
