using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LogControll
{
    public class CamposCurso
    {
        public int id;
        public string nome;
        public string tipo;
        public string dtInicio;
        public string dtTermino;
    }

    class ClassDaoCursos
    {
        public ClassDaoCursos()
        {
        }

        public CamposCurso camposCurso = new CamposCurso();

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

            MySqlDataAdapter meuAdapter = new MySqlDataAdapter("select id, nome, tipo, data_Inicio, data_Termino " +
                "from  logcontroll.tb_cursos WHERE ativo_curso = '1'", minhaConexao);
            System.Data.DataSet dataSet = new System.Data.DataSet();
            dataSet.Clear();
            meuAdapter.Fill(dataSet, tabela);
            dgv.DataSource = dataSet;
            dgv.DataMember = tabela;

            Fechar();
        }

        //Comandos Cursos

        public void Adicionar(string campoNome, string campoTipo, string campoDtInicio, string campoDtTermino)
        {
            Abrir();

            MySqlCommand comando = new MySqlCommand("INSERT INTO `logcontroll`.`tb_cursos` " +
                "(`nome`, `tipo`, `data_Inicio`, `data_Termino`) " +
                "VALUES (@nome, @tipo, @dtInicio, @dtTermino);", minhaConexao);

            comando.Parameters.AddWithValue("@nome", campoNome);
            comando.Parameters.AddWithValue("@tipo", campoTipo);
            comando.Parameters.AddWithValue("@dtInicio", campoDtInicio);
            comando.Parameters.AddWithValue("@dtTermino", campoDtTermino);

            comando.ExecuteNonQuery();

            Fechar();
        }

        public void EditarCliente(int id, string campoNome, string campoTipo, string campoDtInicio, string campoDtTermino)
        {
            Abrir();

            MySqlCommand comando = new MySqlCommand("UPDATE `logcontroll`.`tb_cursos` SET `nome` = @nome, `tipo` = @tipo, `data_inicio` = @dtInicio, `data_termino` = @dtTermino WHERE (`id` = @id)", minhaConexao);

            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nome", campoNome);
            comando.Parameters.AddWithValue("@tipo", campoTipo);
            comando.Parameters.AddWithValue("@dtInicio", campoDtInicio);
            comando.Parameters.AddWithValue("@dtTermino", campoDtTermino);

            comando.ExecuteNonQuery();

            Fechar();
        }

        public void Excluir(int id)
        {
            Abrir();

            MySqlCommand comando = new MySqlCommand("UPDATE `logcontroll`.`tb_cursos` SET `ativo_curso` = '0' WHERE (`id` = @id)", minhaConexao);

            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            Fechar();
        }

        public void ConsultaCurso(string campoId)
        {
            Abrir();

            MySqlCommand comando;

            comando = new MySqlCommand("select * from " + tabela + " where id = '" + campoId + "'", minhaConexao);

            MySqlDataReader dtReader = comando.ExecuteReader();

            if (dtReader.Read())
            {
                camposCurso.id = int.Parse(dtReader["id"].ToString());
                camposCurso.nome = dtReader["nome"].ToString();
                camposCurso.tipo = dtReader["tipo"].ToString();
                camposCurso.dtInicio = dtReader["data_inicio"].ToString();
                camposCurso.dtTermino = dtReader["data_termino"].ToString();
            }

            Fechar();
        }

        public int NumId()
        {
            Abrir();
            //Max retorna o num do ultimo valor do id
            MySqlCommand comando = new MySqlCommand("select coalesce( max( id), 0) + 1 from tb_cursos", minhaConexao);

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
