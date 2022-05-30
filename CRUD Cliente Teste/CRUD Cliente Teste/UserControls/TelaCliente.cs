using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CRUD_Cliente_Teste.UserControls
{
    public partial class TelaCliente : UserControl
    {
        public TelaCliente()
        {
            InitializeComponent();
        }

        ClassDao dao = new ClassDao();

        public static MySqlConnection minhaconexao;

        private void TelaCliente_Load(object sender, EventArgs e)
        {
            conectarBD("tb_cliente");
        }

        private void conectarBD(string tabela)
        {
            try
            {
                dao.conecte("crud_cliente_c#", tabela);
                dao.PreencherTabela(dgvDados);
                LimparCampos();
            }
            catch
            {
                MessageBox.Show("Erro ao conectar com BD!!");
            }
        }

        private void btAdicionar_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (txtBoxNome.Text != "")
                {
                    if (txtBoxNumero.Text == "")
                        txtBoxNumero.Text = "0";

                    dao.InserirCliente(txtBoxNome.Text, txtBoxNumero.Text);
                    dao.PreencherTabela(dgvDados);
                    LimparCampos();
                    MessageBox.Show("Dados foram alocados no banco de dados", "Suscesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Digite pelo menos um nome", "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxNome.Text != "")
                {
                    if (txtBoxNumero.Text == "")
                        txtBoxNumero.Text = "0";

                    dao.EditarCliente(int.Parse(txtId.Text), txtBoxNome.Text, txtBoxNumero.Text);
                    dao.PreencherTabela(dgvDados);
                    MessageBox.Show("Dados foram Editados", "Suscesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Digite pelo menos um nome", "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Tem certeza que dejesa excluir dados?", "Aviso!!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    dao.Excluir(int.Parse(txtId.Text));
                    dao.PreencherTabela(dgvDados);
                    MessageBox.Show("Dados foram exluídos", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Dados não foram exluídos", "Aviso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                dao.ConsultaClienteNome(txtId.Text, txtBoxNome.Text, txtBoxNumero.Text);

                if (dao.camposCliente.id != 0)
                {

                    txtId.Text = dao.camposCliente.id.ToString();
                    txtBoxNome.Text = dao.camposCliente.nome;
                    txtBoxNumero.Text = dao.camposCliente.numero.ToString();

                    dao.CamposClienteClear();

                    MessageBox.Show("Dados encontrados", "Suscesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btAdicionar.Enabled = false;
                    btEditar.Enabled = true;
                    btExcluir.Enabled = true;
                }
                else
                    MessageBox.Show("Dados não exixstem", "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btExibir_Click(object sender, EventArgs e)
        {
            dao.PreencherTabela(dgvDados);
            LimparCampos();
            MessageBox.Show("Dados recarregados", "Suscesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            btAdicionar.Enabled = true;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;

            txtBoxNome.Clear();
            txtBoxNumero.Clear();
            txtId.Text = dao.NumId().ToString();
        }

        private void txtBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
