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

namespace LogControll.Telas
{
    public partial class TelaAlunos : UserControl
    {
        public TelaAlunos()
        {
            InitializeComponent();
        }

        ClassDaoAlunos dao = new ClassDaoAlunos();

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

        private void TelaAlunos_Load(object sender, EventArgs e)
        {
            conectarBD("logcontroll", "tb_alunos");
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxNome.Text != "")
                {
                    string sexo;
                    if (rBtSexoF.Checked)
                        sexo = "F";
                    else
                        sexo = "M";

                    dao.Adicionar(txtBoxNome.Text, int.Parse(txtIdade.Value.ToString()), txtBoxEmail.Text, sexo);
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
            txtIdade.Value = 0;
            txtBoxEmail.Clear();
            rBtSexoF.Checked = true;
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
                    string sexo;
                    if (rBtSexoF.Checked)
                        sexo = "F";
                    else
                        sexo = "M";

                    dao.EditarCliente(int.Parse(txtID.Text), txtBoxNome.Text, int.Parse(txtIdade.Value.ToString()), txtBoxEmail.Text, sexo);
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

                txtID.Text = dao.camposAluno.id.ToString();
                txtBoxNome.Text = dao.camposAluno.nome;
                txtIdade.Value = dao.camposAluno.idade;
                txtBoxEmail.Text = dao.camposAluno.email;

                if (dao.camposAluno.sexo == "F")
                    rBtSexoF.Checked = true;
                else
                    rBtSexoM.Checked = true;

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
