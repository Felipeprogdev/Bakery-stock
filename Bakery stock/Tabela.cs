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
using static System.Windows.Forms.LinkLabel;
using System.Threading;

namespace Bakery_stock
{
    public partial class Tabela : Form
    {
        void CriarLabels()
        {
            Label id = new Label();
            id.Text = "ID";
            tableLayoutPanel1.Controls.Add(id, 0, 0);

            Label name = new Label();
            name.Text = "Nome";
            tableLayoutPanel1.Controls.Add(name, 1, 0);

            Label quantidade = new Label();
            quantidade.Text = "Quantidade";
            tableLayoutPanel1.Controls.Add(quantidade, 2, 0);

            Label validade = new Label();
            validade.Text = "validade";
            tableLayoutPanel1.Controls.Add(validade, 3, 0);

            Label fornecedor = new Label();
            fornecedor.Text = "Fornecedor";
            tableLayoutPanel1.Controls.Add(fornecedor, 4, 0);

            Label preco = new Label();
            preco.Text = "Preço";
            tableLayoutPanel1.Controls.Add(preco, 5, 0);
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


        public Tabela()
        {
            InitializeComponent();
            CriarLabels();

            tableLayoutPanel1.AutoScroll = true;

            // Ler o arquivo JSON existente
            string value = File.ReadAllText("Prod.json");
            List<Produto> produtos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Produto>>(value);
            bool condicional = false;
            int conta = produtos.Count;


            for (int i = 1; i < 16; i++)
            {

                if (conta == 1 || i == conta)
                {
                    break;
                }

                else
                {
                    Label labels1 = new Label(); // criar um label para o id do produto
                    labels1.Text = produtos[i].Id.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels1, 0, i); // adicionar o label na tabela na coluna 1 e na linha i - 1

                    Label labels2 = new Label(); // criar um label para o nome do produto
                    labels2.Text = produtos[i].Nome; // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels2, 1, i); // adicionar o label na tabela na coluna 1 e na linha i - 1

                    Label labels3 = new Label(); // criar um label para a validade do produto
                    labels3.Text = produtos[i].Quantidade.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels3, 2, i); // adicionar o label na tabela na coluna 2 e na linha i - 1

                    Label labels4 = new Label(); // criar um label para o fornecedor do produto
                    labels4.Text = produtos[i].Validade.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels4, 3, i); // adicionar o label na tabela na coluna 3 e na linha i - 1

                    Label labels5 = new Label(); // criar um label para a quantidade do produto
                    labels5.Text = produtos[i].Fornecedor; // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels5, 4, i); // adicionar o label na tabela na coluna 4 e na linha i - 1

                    Label labels6 = new Label(); // criar um label para o preço do produto
                    labels6.Text = produtos[i].Preco.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels6, 5, i); // adicionar o label na tabela na coluna 5 e na linha i - 1
                }
               
            }



        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            // Ler o arquivo JSON existente
            string value = File.ReadAllText("Prod.json");
            List<Produto> produtos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Produto>>(value);

            int adicionar = produtos.Count;


            // Criar um novo objeto Pessoa
            var produto = new Produto { Id = adicionar, Nome = nometxt.Text, Validade = DateTime.Parse(validadetxt.Text), Fornecedor = fornecedortxt.Text, Quantidade = Convert.ToInt32(quantidadetxt.Text), Preco = Convert.ToInt32(precotxt.Text) };

            // Adicionar o novo objeto à lista
            produtos.Add(produto);

            File.WriteAllText("Prod.json", Newtonsoft.Json.JsonConvert.SerializeObject(produtos));

            for (int i = 1; i < 16; i++)
            {
                Control controle = tableLayoutPanel1.GetControlFromPosition(0, i);

                if (controle == null)
                {
                    Label labels1 = new Label(); // criar um label para o id do produto
                    labels1.Text = adicionar.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels1, 0, i); // adicionar o label na tabela na coluna 2 e na linha i

                    Label labels2 = new Label(); // criar um label para o nome do produto
                    labels2.Text = nometxt.Text; // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels2, 1, i); // adicionar o label na tabela na coluna 2 e na linha i

                    Label labels3 = new Label(); // criar um label para a validade do produto
                    labels3.Text = validadetxt.Text; // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels3, 2, i); // adicionar o label na tabela na coluna 2 e na linha i

                    Label labels4 = new Label(); // criar um label para o fornecedor do produto
                    labels4.Text = fornecedortxt.Text; // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels4, 3, i); // adicionar o label na tabela na coluna 3 e na linha i - 1

                    Label labels5 = new Label(); // criar um label para a quantidade do produto
                    labels5.Text = quantidadetxt.Text; // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels5, 4, i); // adicionar o label na tabela na coluna 4 e na linha i - 1

                    Label labels6 = new Label(); // criar um label para o preço do produto
                    labels6.Text = precotxt.Text; // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels6, 5, i); // adicionar o label na tabela na coluna 5 e na linha i - 1

                    i = 5000;
                }

                if (i == 15)
                {
                    int con = Convert.ToInt32(contador.Text) + 1;
                    contador.Text = con.ToString();

                    tableLayoutPanel1.Controls.Clear();
                    CriarLabels();
                }
            }
        }

        private void Tabela_Load(object sender, EventArgs e)
        {
            
        }

        private void proximo_Click(object sender, EventArgs e)
        {
            int la = 0;

            // Ler o arquivo JSON existente
            string value = File.ReadAllText("Prod.json");
            List<Produto> produtos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Produto>>(value);
            int conta = produtos.Count;

          
            
            Control control = tableLayoutPanel1.GetControlFromPosition(0, 15); // pega o controle na coluna 0 e na linha 20
            if (control is null) // verifica se o controle é nulo
            {
                
            }
            else
            {
                Label label = control as Label; // converte o controle em um label
                string text = label.Text; // pega o texto do label
                la = Convert.ToInt32(text);
            }
            

            if (la < 15 * Convert.ToInt32(contador.Text) || la + 1 == conta)
            {
                

            }
            else
            {
                tableLayoutPanel1.Controls.Clear();
                CriarLabels();
                int a = 1;
                int con = Convert.ToInt32(contador.Text) + 1;
                contador.Text = con.ToString();
                for (int i = la + 1; i < la +  16; i++)
                {

                    if (i == conta)
                    {
                        break;
                    }

                    else
                    {
                        Label labels1 = new Label(); // criar um label para o id do produto
                        labels1.Text = produtos[i].Id.ToString(); // atribuir o texto do label
                        tableLayoutPanel1.Controls.Add(labels1, 0, a); // adicionar o label na tabela na coluna 1 e na linha i - 1

                        Label labels2 = new Label(); // criar um label para o nome do produto
                        labels2.Text = produtos[i].Nome; // atribuir o texto do label
                        tableLayoutPanel1.Controls.Add(labels2, 1, a); // adicionar o label na tabela na coluna 1 e na linha i - 1

                        Label labels3 = new Label(); // criar um label para a validade do produto
                        labels3.Text = produtos[i].Validade.ToString(); // atribuir o texto do label
                        tableLayoutPanel1.Controls.Add(labels3, 2, a); // adicionar o label na tabela na coluna 2 e na linha i - 1

                        Label labels4 = new Label(); // criar um label para o fornecedor do produto
                        labels4.Text = produtos[i].Fornecedor; // atribuir o texto do label
                        tableLayoutPanel1.Controls.Add(labels4, 3, a); // adicionar o label na tabela na coluna 3 e na linha i - 1

                        Label labels5 = new Label(); // criar um label para a quantidade do produto
                        labels5.Text = produtos[i].Quantidade.ToString(); // atribuir o texto do label
                        tableLayoutPanel1.Controls.Add(labels5, 4, a); // adicionar o label na tabela na coluna 4 e na linha i - 1

                        Label labels6 = new Label(); // criar um label para o preço do produto
                        labels6.Text = produtos[i].Preco.ToString(); // atribuir o texto do label
                        tableLayoutPanel1.Controls.Add(labels6, 5, a); // adicionar o label na tabela na coluna 5 e na linha i - 1

                        a++;
                    }
                    
                }
            }
        }

        private void anterior_Click(object sender, EventArgs e)
        {
            int la = 0;
            // Ler o arquivo JSON existente
            string value = File.ReadAllText("Prod.json");
            List<Produto> produtos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Produto>>(value);
            int conta = produtos.Count;

            Control control = tableLayoutPanel1.GetControlFromPosition(0, 1); // pega o controle na coluna 0 e na linha 1
            if (control is null) // verifica se o controle é nulo
            {

            }
            else
            {
                Label label = control as Label; // converte o controle em um label
                string text = label.Text; // pega o texto do label
                la = Convert.ToInt32(text);
                la--;

                int h = Convert.ToInt32(contador.Text);
                int p = h - 1;

                

                if ( h > 1) 
                {
                    contador.Text = p.ToString();
                    tableLayoutPanel1.Controls.Clear();
                    CriarLabels();
                    int a = 15;

                    for (int i = la; i > la - 15; i--)
                    {
                        Label labels1 = new Label(); // criar um label para o id do produto
                        labels1.Text = produtos[i].Id.ToString(); // atribuir o texto do label
                        tableLayoutPanel1.Controls.Add(labels1, 0, a); 

                        Label labels2 = new Label(); // criar um label para o nome do produto
                        labels2.Text = produtos[i].Nome; // atribuir o texto do label
                        tableLayoutPanel1.Controls.Add(labels2, 1, a); 

                        Label labels3 = new Label(); // criar um label para a validade do produto
                        labels3.Text = produtos[i].Validade.ToString(); // atribuir o texto do label
                        tableLayoutPanel1.Controls.Add(labels3, 2, a);

                        Label labels4 = new Label(); // criar um label para o fornecedor do produto
                        labels4.Text = produtos[i].Fornecedor; // atribuir o texto do label
                        tableLayoutPanel1.Controls.Add(labels4, 3, a);

                        Label labels5 = new Label(); // criar um label para a quantidade do produto
                        labels5.Text = produtos[i].Quantidade.ToString(); // atribuir o texto do label
                        tableLayoutPanel1.Controls.Add(labels5, 4, a);

                        Label labels6 = new Label(); // criar um label para o preço do produto
                        labels6.Text = produtos[i].Preco.ToString(); // atribuir o texto do label
                        tableLayoutPanel1.Controls.Add(labels6, 5, a); 

                        a--;
                    }
                }
            }


            
        }

        private void procurar_Click(object sender, EventArgs e)
        {
            // Ler o arquivo JSON existente
            string value = File.ReadAllText("Prod.json");
            List<Produto> produtos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Produto>>(value);

            // Percorrer a lista pelo nome
            int linha = 1;
            for(int i = produtos.Count - 1; i > 0; i--)
            {
                tableLayoutPanel1.Controls.Clear();
                CriarLabels();

                if (linha == 15)
                {

                }
                else if (produtos[i].Nome.ToUpper() == nomep.Text.ToUpper())
                {
                    Label labels1 = new Label(); // criar um label para o id do produto
                    labels1.Text = produtos[i].Id.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels1, 0, linha);

                    Label labels2 = new Label(); // criar um label para o nome do produto
                    labels2.Text = produtos[i].Nome; // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels2, 1, linha);

                    Label labels3 = new Label(); // criar um label para a validade do produto
                    labels3.Text = produtos[i].Validade.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels3, 2, linha);

                    Label labels4 = new Label(); // criar um label para o fornecedor do produto
                    labels4.Text = produtos[i].Fornecedor; // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels4, 3, linha);

                    Label labels5 = new Label(); // criar um label para a quantidade do produto
                    labels5.Text = produtos[i].Quantidade.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels5, 4, linha);

                    Label labels6 = new Label(); // criar um label para o preço do produto
                    labels6.Text = produtos[i].Preco.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels6, 5, linha);
                    linha++;
                }

                else if (produtos[i].Validade.ToString() == validadep.Text)
                {
                    Label labels1 = new Label(); // criar um label para o id do produto
                    labels1.Text = produtos[i].Id.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels1, 0, linha);

                    Label labels2 = new Label(); // criar um label para o nome do produto
                    labels2.Text = produtos[i].Nome; // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels2, 1, linha);

                    Label labels3 = new Label(); // criar um label para a validade do produto
                    labels3.Text = produtos[i].Validade.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels3, 2, linha);

                    Label labels4 = new Label(); // criar um label para o fornecedor do produto
                    labels4.Text = produtos[i].Fornecedor; // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels4, 3, linha);

                    Label labels5 = new Label(); // criar um label para a quantidade do produto
                    labels5.Text = produtos[i].Quantidade.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels5, 4, linha);

                    Label labels6 = new Label(); // criar um label para o preço do produto
                    labels6.Text = produtos[i].Preco.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels6, 5, linha);
                    linha++;
                }

                else if (produtos[i].Fornecedor.ToString() == validadep.Text.ToUpper())
                {
                    Label labels1 = new Label(); // criar um label para o id do produto
                    labels1.Text = produtos[i].Id.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels1, 0, linha);

                    Label labels2 = new Label(); // criar um label para o nome do produto
                    labels2.Text = produtos[i].Nome; // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels2, 1, linha);

                    Label labels3 = new Label(); // criar um label para a validade do produto
                    labels3.Text = produtos[i].Validade.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels3, 2, linha);

                    Label labels4 = new Label(); // criar um label para o fornecedor do produto
                    labels4.Text = produtos[i].Fornecedor; // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels4, 3, linha);

                    Label labels5 = new Label(); // criar um label para a quantidade do produto
                    labels5.Text = produtos[i].Quantidade.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels5, 4, linha);

                    Label labels6 = new Label(); // criar um label para o preço do produto
                    labels6.Text = produtos[i].Preco.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels6, 5, linha);
                    linha++;
                }

                else if (produtos[i].Quantidade.ToString() == quantidadep.Text.ToUpper())
                {
                    Label labels1 = new Label(); // criar um label para o id do produto
                    labels1.Text = produtos[i].Id.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels1, 0, linha);

                    Label labels2 = new Label(); // criar um label para o nome do produto
                    labels2.Text = produtos[i].Nome; // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels2, 1, linha);

                    Label labels3 = new Label(); // criar um label para a validade do produto
                    labels3.Text = produtos[i].Validade.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels3, 2, linha);

                    Label labels4 = new Label(); // criar um label para o fornecedor do produto
                    labels4.Text = produtos[i].Fornecedor; // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels4, 3, linha);

                    Label labels5 = new Label(); // criar um label para a quantidade do produto
                    labels5.Text = produtos[i].Quantidade.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels5, 4, linha);

                    Label labels6 = new Label(); // criar um label para o preço do produto
                    labels6.Text = produtos[i].Preco.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels6, 5, linha);
                    linha++;
                }

                else if (produtos[i].Preco.ToString() == precop.Text.ToUpper())
                {
                    Label labels1 = new Label(); // criar um label para o id do produto
                    labels1.Text = produtos[i].Id.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels1, 0, linha);

                    Label labels2 = new Label(); // criar um label para o nome do produto
                    labels2.Text = produtos[i].Nome; // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels2, 1, linha);

                    Label labels3 = new Label(); // criar um label para a validade do produto
                    labels3.Text = produtos[i].Validade.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels3, 2, linha);

                    Label labels4 = new Label(); // criar um label para o fornecedor do produto
                    labels4.Text = produtos[i].Fornecedor; // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels4, 3, linha);

                    Label labels5 = new Label(); // criar um label para a quantidade do produto
                    labels5.Text = produtos[i].Quantidade.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels5, 4, linha);

                    Label labels6 = new Label(); // criar um label para o preço do produto
                    labels6.Text = produtos[i].Preco.ToString(); // atribuir o texto do label
                    tableLayoutPanel1.Controls.Add(labels6, 5, linha);
                    linha++;
                }

            }
            
        }
    }
}
