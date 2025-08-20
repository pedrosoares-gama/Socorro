using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumeroRepeticoesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ExecutarAplicacao();
        }

        private void ExecutarAplicacao()
        {
            List<int> numeros = new List<int>();

            while (numeros.Count < 20)
            {
                string entrada = Microsoft.VisualBasic.Interaction.InputBox($"Digite o {numeros.Count + 1}º número (0 a 100):", "Entrada de Número");

                if (int.TryParse(entrada, out int numero))
                {
                    if (numero >= 0 && numero <= 100)
                    {
                        numeros.Add(numero);
                    }
                    else
                    {
                        MessageBox.Show("Número fora do intervalo permitido (0 a 100). Tente novamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Entrada inválida. Digite um número inteiro.");
                }
            }

            // Processamento dos dados
            var numerosOrdenados = numeros.OrderBy(n => n).ToList();
            int somaTotal = numerosOrdenados.Sum();
            int maior = numerosOrdenados.Max();
            int menor = numerosOrdenados.Min();

            var contagem = numerosOrdenados.GroupBy(n => n)
                                           .ToDictionary(g => g.Key, g => g.Count());

            var numerosRepetidos = contagem.Where(kvp => kvp.Value > 1)
                                           .OrderByDescending(kvp => kvp.Key)
                                           .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            int somaRepetidos = numerosRepetidos.Sum(kvp => kvp.Key * kvp.Value);

            double porcentagemRepetidos = somaTotal > 0 ? (somaRepetidos * 100.0 / somaTotal) : 0;

            // Montar resultado para exibição
            StringBuilder resultado = new StringBuilder();

            resultado.AppendLine("=== NÚMEROS DIGITADOS (ORDENADOS) ===");
            resultado.AppendLine(string.Join(", ", numerosOrdenados));
            resultado.AppendLine();

            resultado.AppendLine($"Soma Total: {somaTotal}");
            resultado.AppendLine($"Maior Número: {maior}");
            resultado.AppendLine($"Menor Número: {menor}");
            resultado.AppendLine();

            if (numerosRepetidos.Count > 0)
            {
                resultado.AppendLine("=== NÚMEROS REPETIDOS (DECRESCENTE) ===");
                foreach (var kvp in numerosRepetidos)
                {
                    resultado.AppendLine($"Número {kvp.Key} - Repetições: {kvp.Value}");
                }

                resultado.AppendLine();
                resultado.AppendLine($"Soma dos Números Repetidos: {somaRepetidos}");
                resultado.AppendLine($"Porcentagem da Soma dos Repetidos: {porcentagemRepetidos:F2}%");

                // Gráfico de Barras
                resultado.AppendLine();
                resultado.AppendLine("=== GRÁFICO DE BARRAS DAS REPETIÇÕES ===");
                foreach (var kvp in numerosRepetidos)
                {
                    string barras = new string('*', kvp.Value);
                    resultado.AppendLine($"Número {kvp.Key}: {barras} ({kvp.Value}x)");
                }

                // Gráfico de Pizza
                resultado.AppendLine();
                resultado.AppendLine("=== GRÁFICO DE PIZZA (TEXTUAL) ===");

                int totalBarras = 20;
                int barrasRepetidos = (int)(porcentagemRepetidos / 100 * totalBarras);
                int barrasOutros = totalBarras - barrasRepetidos;

                resultado.AppendLine($"Soma Repetidos: [{"".PadLeft(barrasRepetidos, '#').PadRight(totalBarras, '-')}] {porcentagemRepetidos:F1}%");
                resultado.AppendLine($"Outros Números: [{"".PadLeft(barrasOutros, '#').PadRight(totalBarras, '-')}] {(100 - porcentagemRepetidos):F1}%");
            }
            else
            {
                resultado.AppendLine("Nenhum número foi repetido.");
            }

            // Exibir resultados
            TextBox textBoxResultado = new TextBox();
            textBoxResultado.Multiline = true;
            textBoxResultado.ScrollBars = ScrollBars.Both;
            textBoxResultado.ReadOnly = true;
            textBoxResultado.Dock = DockStyle.Fill;
            textBoxResultado.Font = new System.Drawing.Font("Consolas", 10);
            textBoxResultado.Text = resultado.ToString();

            this.Controls.Add(textBoxResultado);
            this.Text = "Análise de Números";
            this.Width = 800;
            this.Height = 600;
        }
    }
}
