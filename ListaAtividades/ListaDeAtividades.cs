using ListaAtividades.Dominio;

namespace ListaAtividades
{
    public partial class ListaDeAtividades : Form
    {
        public ListaDeAtividades()
        {
            InitializeComponent();
        }


        private void ListaDeAtividades_Load(object sender, EventArgs e)
        {
            Atividade atividade = new();

            var atividadeEmAndamento = atividade.BuscarAtividadeEmAndamento();
            textBoxAtividadeEmAndamento.Text = $"{atividadeEmAndamento.Id} - {atividadeEmAndamento.Titulo}";

            var atividadesPendente = atividade.ListarAtividadesPendentes();
            dataGridViewAtividades.DataSource = atividadeEmAndamento;

            
        }
    }
}
