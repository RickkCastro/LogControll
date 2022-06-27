using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LogControll
{
    public class CamposMatriculas
    {
        public int id;
        public string nome_aluno;
        public string nome_curso;
    }

    class ClassDaoMatriculas
    {
        public ClassDaoMatriculas()
        {
        }

        public CamposMatriculas camposMatriculas = new CamposMatriculas();

        //var do mySql
        MySqlConnection minhaConexao;

        //Dados do bd
        public string servidor = "localhost";
        public string usuarioBD = "root";
        public string senhaBd = "ninjah12";
        string bancoDados;

        public void conecte(string BancoDados)
        {
            bancoDados = BancoDados;
            minhaConexao = new MySqlConnection("server=" + servidor + "; database=" + bancoDados +
                                                "; uid=" + usuarioBD + "; password=" + senhaBd);
        }

        void Abrir()
        {
            minhaConexao.Open();
        }
        void Fechar()
        {
            minhaConexao.Close();
        }

        public void PreencherTabelaAlunos (System.Windows.Forms.DataGridView dgv)
        {
            Abrir();

            string tabela = "tb_alunos";
            MySqlDataAdapter meuAdapter = new MySqlDataAdapter("select id, nome, idade, email, sexo " +
                "from  logcontroll.tb_alunos WHERE ativo_aluno = '1'", minhaConexao);
            System.Data.DataSet dataSet = new System.Data.DataSet();
            dataSet.Clear();
            meuAdapter.Fill(dataSet, tabela);
            dgv.DataSource = dataSet;
            dgv.DataMember = tabela;

            Fechar();
        }

        public void PreencherTabelaCursos(System.Windows.Forms.DataGridView dgv)
        {
            Abrir();

            string tabela = "tb_cursos";
            MySqlDataAdapter meuAdapter = new MySqlDataAdapter("select id, nome, tipo, data_Inicio, data_Termino " +
                "from  logcontroll.tb_cursos WHERE ativo_curso = '1'", minhaConexao);
            System.Data.DataSet dataSet = new System.Data.DataSet();
            dataSet.Clear();
            meuAdapter.Fill(dataSet, tabela);
            dgv.DataSource = dataSet;
            dgv.DataMember = tabela;

            Fechar();
        }

        public void PreencherTabelaMatriculas(System.Windows.Forms.DataGridView dgv)
        {
            Abrir();

            string tabela = "tb_matriculas";
            MySqlDataAdapter meuAdapter = new MySqlDataAdapter("select id, nome_aluno, nome_curso " +
                "from  logcontroll.tb_matriculas WHERE ativo_matricula = '1'", minhaConexao);
            System.Data.DataSet dataSet = new System.Data.DataSet();
            dataSet.Clear();
            meuAdapter.Fill(dataSet, tabela);
            dgv.DataSource = dataSet;
            dgv.DataMember = tabela;

            Fechar();
        }

        public void Adicionar(string campoNome_aluno, string campoNome_curso)
        {
            Abrir();

            MySqlCommand comando = new MySqlCommand("INSERT INTO `logcontroll`.`tb_matriculas` (`nome_aluno`, `nome_curso`) " +
                "VALUES(@nome_aluno, @nome_curso);", minhaConexao);

            comando.Parameters.AddWithValue("@nome_aluno", campoNome_aluno);
            comando.Parameters.AddWithValue("@nome_curso", campoNome_curso);

            comando.ExecuteNonQuery();

            Fechar();
        }

        public void EditarCliente(int id, string campoNome_aluno, string campoNome_curso)
        {
            Abrir();

            MySqlCommand comando = new MySqlCommand("UPDATE `logcontroll`.`tb_matriculas` SET `nome_aluno` = @nome_aluno, `nome_curso` = @nome_curso WHERE (`id` = @id)", minhaConexao);

            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nome_aluno", campoNome_aluno);
            comando.Parameters.AddWithValue("@nome_curso", campoNome_curso);

            comando.ExecuteNonQuery();

            Fechar();
        }

        public void Excluir(int id)
        {
            Abrir();

            MySqlCommand comando = new MySqlCommand("UPDATE `logcontroll`.`tb_matriculas` SET `ativo_matricula` = '0' WHERE (`id` = @id)", minhaConexao);

            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            Fechar();
        }

        public void ConsultaCurso(string campoId)
        {
            Abrir();

            MySqlCommand comando;

            comando = new MySqlCommand("select * from `logcontroll`.`tb_matriculas` where id = '" + campoId + "'", minhaConexao);

            MySqlDataReader dtReader = comando.ExecuteReader();

            if (dtReader.Read())
            {
                camposMatriculas.id = int.Parse(dtReader["id"].ToString());
                camposMatriculas.nome_aluno = dtReader["nome_aluno"].ToString();
                camposMatriculas.nome_curso = dtReader["nome_curso"].ToString();
            }

            Fechar();
        }

        public int NumId()
        {
            Abrir();
            //Max retorna o num do ultimo valor do id
            MySqlCommand comando = new MySqlCommand("select coalesce( max( id), 0) + 1 from `logcontroll`.`tb_matriculas`", minhaConexao);

            //ExecuteScalar retorna um dado do tipo object, é preciso converter para string
            string n = comando.ExecuteScalar().ToString();

            Fechar();

            int num = int.Parse(n);
            return num;
        }
    }
}
