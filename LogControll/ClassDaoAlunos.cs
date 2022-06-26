using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LogControll
{
    public class CamposAluno
    {
        public int id;
        public string nome;
        public int idade;
        public string email;
        public string sexo;
    }

    class ClassDaoAlunos
    {
        public ClassDaoAlunos()
        {
        }

        public CamposAluno camposAluno = new CamposAluno();

        //var do mySql
        MySqlConnection minhaConexao;

        //Dados do bd
        public string servidor = "localhost";
        public string usuarioBD = "root";
        public string senhaBd = "ninjah12";
        string bancoDados;
        string tabela;

        public void conecte(string BancoDados, string Tabela)
        {
            bancoDados = BancoDados;
            tabela = Tabela;
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

        public void PreencherTabela(System.Windows.Forms.DataGridView dgv)
        {
            Abrir();

            MySqlDataAdapter meuAdapter = new MySqlDataAdapter("select id, nome, idade, email, sexo " +
                "from  logcontroll.tb_alunos WHERE ativo_aluno = '1'", minhaConexao);
            System.Data.DataSet dataSet = new System.Data.DataSet();
            dataSet.Clear();
            meuAdapter.Fill(dataSet, tabela);
            dgv.DataSource = dataSet;
            dgv.DataMember = tabela;

            Fechar();
        }


        public void Adicionar(string campoNome, int campoIdade, string campoEmail, string campoSexo)
        {
            Abrir();

            MySqlCommand comando = new MySqlCommand ("INSERT INTO `logcontroll`.`tb_alunos` (`nome`, `idade`, `email`, `sexo`) " +
                "VALUES(@nome, @idade, @email, @sexo);", minhaConexao);

            comando.Parameters.AddWithValue("@nome", campoNome);
            comando.Parameters.AddWithValue("@idade", campoIdade);
            comando.Parameters.AddWithValue("@email", campoEmail);
            comando.Parameters.AddWithValue("@sexo", campoSexo);

            comando.ExecuteNonQuery();

            Fechar();
        }

        public void EditarCliente(int id, string campoNome, int campoIdade, string campoEmail, string campoSexo)
        {
            Abrir();

            MySqlCommand comando = new MySqlCommand("UPDATE `logcontroll`.`tb_alunos` SET `nome` = @nome, `idade` = @idade, `email` = @email, `sexo` = @sexo WHERE (`id` = @id)", minhaConexao);

            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nome", campoNome);
            comando.Parameters.AddWithValue("@idade", campoIdade);
            comando.Parameters.AddWithValue("@email", campoEmail);
            comando.Parameters.AddWithValue("@sexo", campoSexo);

            comando.ExecuteNonQuery();

            Fechar();
        }

        public void Excluir(int id)
        {
            Abrir();

            MySqlCommand comando = new MySqlCommand("UPDATE `logcontroll`.`tb_alunos` SET `ativo_aluno` = '0' WHERE (`id` = @id)", minhaConexao);

            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            Fechar();
        }

        public void ConsultaCurso(string campoId)
        {
            Abrir();

            MySqlCommand comando;

            comando = new MySqlCommand("select * from `logcontroll`.`tb_alunos` where id = '" + campoId + "'", minhaConexao);

            MySqlDataReader dtReader = comando.ExecuteReader();

            if (dtReader.Read())
            {
                camposAluno.id = int.Parse(dtReader["id"].ToString());
                camposAluno.nome = dtReader["nome"].ToString();
                camposAluno.idade = int.Parse(dtReader["idade"].ToString());
                camposAluno.email = dtReader["email"].ToString();
                camposAluno.sexo = dtReader["sexo"].ToString();
            }

            Fechar();
        }

        public int NumId()
        {
            Abrir();
            //Max retorna o num do ultimo valor do id
            MySqlCommand comando = new MySqlCommand("select coalesce( max( id), 0) + 1 from `logcontroll`.`tb_alunos`", minhaConexao);

            //ExecuteScalar retorna um dado do tipo object, é preciso converter para string
            string n = comando.ExecuteScalar().ToString();

            Fechar();

            int num = int.Parse(n);
            return num;
        }

        //public void CamposCursoClear()
        //{
        //    camposCurso.id = 0;
        //    camposCurso.nome = "";
        //    camposCurso.tipo = "";
        //    camposCurso.dtInicio = "";
        //    camposCurso.dtTermino = "";
        //}
    }
}
