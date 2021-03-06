using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_Cliente_Teste.UserControls;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CRUD_Cliente_Teste
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelUserControl.Controls.Clear();
            panelUserControl.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btAlunos_Click(object sender, EventArgs e)
        {
            TelaCliente telaCliente = new TelaCliente();
            addUserControl(telaCliente);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TelaCliente telaCliente = new TelaCliente();
            addUserControl(telaCliente);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btCursos_Click(object sender, EventArgs e)
        {
            TelaCursos telaCursos = new TelaCursos();
            addUserControl(telaCursos);
        }

        private void btMatriculas_Click(object sender, EventArgs e)
        {
            TelaMatriculas telaMatriculas = new TelaMatriculas();
            addUserControl(telaMatriculas);
        }
    }
}
