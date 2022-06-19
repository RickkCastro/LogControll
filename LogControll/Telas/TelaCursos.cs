using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogControll.Telas
{
    public partial class TelaCursos : UserControl
    {
        public TelaCursos()
        {
            InitializeComponent();
        }

        ClassDaoCursos  dao = new ClassDaoCursos();

        private void conectarBD(string bd, string tabela)
        {
            try
            {
                dao.conecte(bd, tabela);
                dao.PreencherTabela(dgvDados);
                LimparCampos();
            }
            catch
            {
                MessageBox.Show("Erro ao conectar com BD!!");
            }
        }

        private void TelaCursos_Load(object sender, EventArgs e)
        {
            conectarBD("logcontroll", "tb_cursos");
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxNome.Text != "")
                {
                    dao.Adicionar(txtBoxNome.Text, txtBoxTipo.Text, txtBoxDataI.Text, txtBoxDataT.Text);
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

        private void LimparCampos()
        {
            btAdicionar.Enabled = true;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;

            txtBoxNome.Clear();
            txtBoxTipo.Clear();
            txtBoxDataI.Clear();
            txtBoxDataT.Clear();
            txtID.Text = dao.NumId().ToString();

            dgvDados.ClearSelection();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Tem certeza que dejesa excluir dados?", "Aviso!!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    dao.Excluir(int.Parse(txtID.Text));
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

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxNome.Text != "")
                {
                    dao.EditarCliente(int.Parse(txtID.Text), txtBoxNome.Text, txtBoxTipo.Text, txtBoxDataI.Text, txtBoxDataT.Text);
                    dao.PreencherTabela(dgvDados);
                    MessageBox.Show("Dados foram Editados", "Suscesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
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

        private void dgvDados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Consultar
            try
            {
                var row = dgvDados.CurrentRow;

                string txtIdCell = row.Cells[0].Value.ToString();

                dao.ConsultaCurso(txtIdCell);

                txtID.Text = dao.camposCurso.id.ToString();
                txtBoxNome.Text = dao.camposCurso.nome;
                txtBoxTipo.Text = dao.camposCurso.tipo;
                txtBoxDataI.Text = dao.camposCurso.dtInicio;
                txtBoxDataT.Text = dao.camposCurso.dtInicio;

                btAdicionar.Enabled = false;
                btEditar.Enabled = true;
                btExcluir.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
