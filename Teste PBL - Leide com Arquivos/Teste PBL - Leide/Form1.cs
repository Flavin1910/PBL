using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace Teste_PBL___Leide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(LargRio.Text , out double LarguraRio))
            {
                    MessageBox.Show("Por favor, insira um número válido.");
                    return;
            }

            if(LarguraRio < 20 || LarguraRio > 120)
            {
                MessageBox.Show("Digite um valor entre 20 e 140");
            }
     

            if (!double.TryParse(Varr.Text, out double VelArr))
            {
                MessageBox.Show("Por favor, insira um número válido.");
                return;
            }

            if (!double.TryParse(AngBarco.Text, out double AngBar))
            {
                MessageBox.Show("Por favor, insira um número válido.");
                return;
            }

            if (!double.TryParse(Vrel.Text, out double VelRel))
            {
                MessageBox.Show("Por favor, insira um número válido.");
                return;

            }

            // Cálculo das variáveis
            AngBar = AngBar * (Math.PI / 180);
            double VelRel_I = VelRel * Math.Cos(AngBar);
            double VelRel_J = VelRel * Math.Sin(AngBar);
            double Vvel_Result = VelRel_I + VelArr;
            double Tempo = LarguraRio / VelRel_J;
            double MenorTempo = LarguraRio / VelRel;
            double P_chegada = Vvel_Result * Tempo;
            double AnguloResult = Math.Atan(VelRel_J / Vvel_Result) * (180 / Math.PI);

            

            // Impressão no ShowMessageBox (talvez saia porque ficou inútil)
            ShowMessageBox("Vetor relativo i: " + VelRel_I.ToString("f2") +
                "\nVetor Relativo j: " + VelRel_J.ToString("f2") +
                "\nVetor  velocidade resultante: " + Vvel_Result.ToString("f2") + "i" + " + " + VelRel_J.ToString("f2") + "j" +
                "\nTempo chegada: " + Tempo.ToString("f2") + "s" +
                "\nÂngulo resultante: " + AnguloResult.ToString("f2") + "°" +
                "\nPonto de chegada Px: " + P_chegada.ToString("f2") +
                "\nMenor tempo de chegada: " + MenorTempo.ToString("f2")
                ,"Valores" , new Font("Arial", 12, FontStyle.Bold));

            LargRio.Clear();
            Varr.Clear();
            AngBarco.Clear();
            Vrel.Clear();

            // Retorna angulo pra graus para ser escrito na tabela
           AngBar = AngBar / (Math.PI / 180);

            // Imprimi os dados no arquivo txt com espaçamento para encaixar na tabela 
            string path = PathArquivo.Text;
            string conteudo = "        " + VelRel.ToString("f2")+ ",          " +
            "               " + VelArr.ToString("f2")+
            ",                          " + AngBar + 
            ",                      " 
            + Tempo.ToString("f2");

            // adiciona os itens no arquivo
            using (StreamWriter sw = new StreamWriter(path, append: true))
            {
                Console.WriteLine();
                sw.WriteLine($"\n {conteudo} ");
            }
            Console.WriteLine();
        }

        
        // Criar um arquivo após o clique no botão
        private void CriarArquivo(string path)
        {
            File.WriteAllText(path, " Velocidade Barco (m/s)        Velocidade Arrasto(m/s)        Angulo Barco(º)        Tempo de Travessia(s)");
        }

        private void ShowMessageBox(string mensagem, string titulo, Font fonte)
        {
            Form form = new Form()
            {
                Size = new Size(600, 400),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                MinimizeBox = false,
                MaximizeBox = false,
                Text = titulo
            };
            Label textLabel = new Label()
            {
                Size = new Size(550, 300),
                Location = new Point(25, 25),
                Font = fonte,
                Text = mensagem
            };
            Button confirmation = new Button()
            {
                Text = "Ok",
                DialogResult = DialogResult.OK,
                Size = new Size(80, 40),
                Location = new Point(250 , 400)
            };
            confirmation.Click += (sender, e) => { form.Close(); };
            form.Controls.Add(textLabel);
            form.Controls.Add(confirmation);
            form.ShowDialog();
        }

        // Função para criar um arquivo
        private void button1_Click(object sender, EventArgs e)
        {
           string arquivo = ArquivoPath.Text;
           CriarArquivo(arquivo);
        }
    }
}
