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
    public partial class TelaMatricula : UserControl
    {
        public TelaMatricula()
        {
            InitializeComponent();
        }

        ClassDaoMatriculas dao = new ClassDaoMatriculas();

        private void conectarBD(string bd)
        {
            try
            {
                dao.conecte(bd);
                dao.PreencherTabelaAlunos(dgvAlunos);
                dao.PreencherTabelaCursos(dgvCursos);
                dao.PreencherTabelaMatriculas(dgvMatriculas);
                LimparCampos();
            }
            catch
            {
                MessageBox.Show("Erro ao conectar com BD!!");
            }
        }

        private void TelaMatricula_Load(object sender, EventArgs e)
        {
            conectarBD("logcontroll");
            CreateLists();
        }

        private void CreateLists()
        {
            //Alunos
            string[] alunos = new string[dgvAlunos.Rows.Count];

            for (int i = 0; i < dgvAlunos.Rows.Count; i++)
            {
                alunos[i] = dgvAlunos.Rows[i].Cells[1].Value.ToString();
            }

            cBoxAluno.Items.Clear();
            cBoxAluno.Items.AddRange(alunos);

            //Cursos
            string[] cursos = new string[dgvCursos.Rows.Count];

            for (int i = 0; i < dgvCursos.Rows.Count; i++)
            {
                cursos[i] = dgvCursos.Rows[i].Cells[1].Value.ToString();
            }

            cBoxCurso.Items.Clear();
            cBoxCurso.Items.AddRange(cursos);
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cBoxAluno.Text != "")
                {
                    dao.Adicionar(cBoxAluno.Text, cBoxCurso.Text);
                    dao.PreencherTabelaMatriculas(dgvMatriculas);
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

            cBoxAluno.Text = "";
            cBoxCurso.Text = "";
            txtID.Text = dao.NumId().ToString();

            dgvAlunos.ClearSelection();
            dgvCursos.ClearSelection();
            dgvMatriculas.ClearSelection();
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
                    dao.PreencherTabelaMatriculas(dgvMatriculas);
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

        private void btEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cBoxAluno.Text != "")
                {

                    dao.EditarCliente(int.Parse(txtID.Text), cBoxAluno.Text, cBoxCurso.Text);
                    dao.PreencherTabelaMatriculas(dgvMatriculas);
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

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void dgvMatriculas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Consultar
            try
            {
                var row = dgvMatriculas.CurrentRow;

                string txtIdCell = row.Cells[0].Value.ToString();

                dao.ConsultaCurso(txtIdCell);

                txtID.Text = dao.camposMatriculas.id.ToString();
                cBoxAluno.Text = dao.camposMatriculas.nome_aluno;
                cBoxCurso.Text = dao.camposMatriculas.nome_curso;

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
