using System;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;  // Biblioteca para manipular JSON

namespace consultaCep
{
    public partial class ConsultaCEP : Form
    {
        public ConsultaCEP()
        {
            InitializeComponent();
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Botão pressionado");  // Ponto de depuração 1

            string cep = txtCep.Text;  // Coletar o CEP do TextBox
            cep = cep.Replace(".", "").Replace("-", "");

            // Verificar se o CEP não está vazio
            if (string.IsNullOrEmpty(cep))
            {
                MessageBox.Show("Por favor, insira um CEP válido.");
                return;
            }

            HttpClient cliente = new HttpClient();

            // Construir a URL com o CEP inserido pelo usuário
            string url = $"https://viacep.com.br/ws/{cep}/json/";

            HttpResponseMessage resposta = await cliente.GetAsync(url);

            if (resposta.IsSuccessStatusCode)
            {
                string conteudo = await resposta.Content.ReadAsStringAsync();
                Console.WriteLine($"Conteúdo da API: {conteudo}");  // Ponto de depuração 2

                // Usar o Newtonsoft.Json para interpretar o JSON
                JObject dadosCep = JObject.Parse(conteudo);
                Console.WriteLine($"Dados CEP: {dadosCep}");  // Ponto de depuração 3

                // Limpar os itens antigos na ListBox
                ltDados.Items.Clear();

                // Adicionar os novos dados na ListBox
                ltDados.Items.Add($"CEP: {dadosCep["cep"]}");
                ltDados.Items.Add($"Logradouro: {dadosCep["logradouro"]}");
                ltDados.Items.Add($"Complemento: {dadosCep["complemento"]}");
                ltDados.Items.Add($"Bairro: {dadosCep["bairro"]}");
                ltDados.Items.Add($"Cidade: {dadosCep["localidade"]}");
                ltDados.Items.Add($"Estado: {dadosCep["uf"]}");
            }
            else
            {
                MessageBox.Show("Não foi possível obter informações para este CEP.", "Informação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }
    }
}
