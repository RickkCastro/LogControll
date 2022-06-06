using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRUD_Cliente_Teste
{
    public class CamposCliente
    {
        public int id;
        public string nome;
        public int numero;
    }

    public class ClassDao
    {
        public ClassDao()
        {
        }

        public CamposCliente camposCliente = new CamposCliente();

        //var do mySql
        MySqlConnection minhaConexao;

        //Dados do bd
        public string usuarioBD = "root";
        public string senhaBd = "admin";
        public string servidor = "localhost";
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

            MySqlDataAdapter meuAdapter = new MySqlDataAdapter("Select * From " + tabela, minhaConexao);
            System.Data.DataSet dataSet = new System.Data.DataSet();
            dataSet.Clear();
            meuAdapter.Fill(dataSet, tabela);
            dgv.DataSource = dataSet;
            dgv.DataMember = tabela;

            Fechar();
        }

        //Comandos Cliente

        public void InserirCliente(string campoNome, string campoNumero)
        {
            Abrir();

            MySqlCommand comando = new MySqlCommand("INSERT INTO " + tabela + "(`nome`, `numero`) " +
                "VALUES (@nome, @numero)", minhaConexao);

            comando.Parameters.AddWithValue("@nome", campoNome);
            comando.Parameters.AddWithValue("@numero", campoNumero);

            comando.ExecuteNonQuery();

            Fechar();
        }

        public void EditarCliente(int id, string campoNome, string campoNumero)
        {
            Abrir();

            MySqlCommand comando = new MySqlCommand("Update " + tabela + " set nome=@nome, numero=@numero " +
                "where id=@id", minhaConexao);

            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nome", campoNome);
            comando.Parameters.AddWithValue("@numero", campoNumero);

            comando.ExecuteNonQuery();

            Fechar();
        }

        public void Excluir(int id)
        {
            Abrir();

            MySqlCommand comando = new MySqlCommand("Delete from " + tabela + " where id = @id", minhaConexao);

            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            Fechar();
        }

        public void ConsultaClienteNome(string campoId, string campoNome, string campoNumero)
        {
            Abrir();

            MySqlCommand comando;

            if (campoId != "")
                comando = new MySqlCommand("select * from " + tabela + " where id = '" + campoId + "'", minhaConexao);
            else if(campoNome != "")
                comando = new MySqlCommand("select * from " + tabela + " where nome = '" + campoNome + "'", minhaConexao);
            else
                comando = new MySqlCommand("select * from " + tabela + " where numero = '" + campoNumero + "'", minhaConexao);

            MySqlDataReader dtReader = comando.ExecuteReader();

            if (dtReader.Read())
            {
                camposCliente.id = int.Parse(dtReader["id"].ToString());
                camposCliente.nome = dtReader["nome"].ToString();
                camposCliente.numero = int.Parse(dtReader["numero"].ToString());
            }

            Fechar();
        }

        public int NumId()
        {
            Abrir();
            //Max retorna o num do ultimo valor do id
            MySqlCommand comando = new MySqlCommand("select auto_increment from information_schema.tables where table_name = '" + tabela + "' and table_schema = '" + bancoDados + "';", minhaConexao);

            //ExecuteScalar retorna um dado do tipo object, é preciso converter para string
            string n = comando.ExecuteScalar().ToString();

            //Agora convertemos o dado para int e somamos um para obter o numero do proximo registro
            int num;
            if (n != "1")
            {
                num = int.Parse(n) + 1;
            }
            else
            {
                num = int.Parse(n);
            }

            Fechar();

            return num;
        }

        public void CamposClienteClear()
        {
            camposCliente.id = 0;
            camposCliente.nome = "";
            camposCliente.numero = 0;
        }
    }
}
