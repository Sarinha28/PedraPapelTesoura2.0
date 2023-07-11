using System.Diagnostics.Eventing.Reader;

namespace PedraPapelTesoura2._0
{

    public partial class Form1 : Form
    {
        private string EscolhadoUsuario;
        private string EscolhadaMaquina;
        private string[] opcoes =
        {
            "PEDRA",
            "PAPEL",
            "TESOURA"
        };
        private int pontosUsuario, pontosMaquina;

        public Form1()
        {
            InitializeComponent();
        }

        private void SalvaSelecao(string selecao)
        {
            EscolhadoUsuario = selecao;
            txt_usuario.Text = EscolhadoUsuario;

            SorteiaSelecaoComputador();

            Comparacao();
        }

        private void SorteiaSelecaoComputador()
        {
            Random rand = new Random();
            int sorteio = rand.Next(opcoes.Length);
            EscolhadaMaquina = opcoes[sorteio];
            txt_maquina.Text = EscolhadaMaquina;
        }



        private void btn_pedra_Click(object sender, EventArgs e)
        {
            SalvaSelecao(opcoes[0]);
        }

        private void Comparacao()
        {
            if (EscolhadoUsuario == EscolhadaMaquina)
            {
                txt_resultado.Text = "Deu empate!!!";
            }
            else if (EscolhadoUsuario == opcoes[0] && EscolhadaMaquina == opcoes[2])
            {
                pontosUsuario++;
                txt_resultado.Text = "Você venceu!!!!";

            }
            else if (EscolhadoUsuario == opcoes[1] && EscolhadaMaquina == opcoes[0])
            {
                pontosUsuario++;
                txt_resultado.Text = "Você venceu!!!!";

            }
            else if (EscolhadoUsuario == opcoes[2] && EscolhadaMaquina == opcoes[1])
            {
                pontosUsuario++;
                txt_resultado.Text = "Você venceu!!!!";

            }
            else
            {
                pontosMaquina++;
                txt_resultado.Text = "Você perdeu!!";
            }
            placarMaquina.Text = pontosMaquina.ToString();
            placarUsuario.Text = pontosUsuario.ToString();
        }

        private void btn_papel_Click(object sender, EventArgs e)
        {
            SalvaSelecao(opcoes[1]);
        }

        private void btn_tesoura_Click(object sender, EventArgs e)
        {
            SalvaSelecao(opcoes[2]);
        }
    }
}