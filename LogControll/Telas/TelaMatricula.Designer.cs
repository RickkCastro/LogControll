namespace LogControll.Telas
{
    partial class TelaMatricula
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxDataI = new System.Windows.Forms.TextBox();
            this.txtBoxDataT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.cBoxPesquisa = new System.Windows.Forms.ComboBox();
            this.txtBoxPesquisa = new System.Windows.Forms.TextBox();
            this.btPesquisar = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btLimpar = new Guna.UI2.WinForms.Guna2Button();
            this.btAdicionar = new Guna.UI2.WinForms.Guna2Button();
            this.btExcluir = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.btExcluir);
            this.guna2GradientPanel1.Controls.Add(this.btAdicionar);
            this.guna2GradientPanel1.Controls.Add(this.btLimpar);
            this.guna2GradientPanel1.Controls.Add(this.btPesquisar);
            this.guna2GradientPanel1.Controls.Add(this.txtBoxPesquisa);
            this.guna2GradientPanel1.Controls.Add(this.cBoxPesquisa);
            this.guna2GradientPanel1.Controls.Add(this.txtBoxDataT);
            this.guna2GradientPanel1.Controls.Add(this.txtBoxTipo);
            this.guna2GradientPanel1.Controls.Add(this.txtBoxDataI);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.txtBoxNome);
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.txtID);
            this.guna2GradientPanel1.Controls.Add(this.label7);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.dataGridView1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.LightSeaGreen;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.DeepSkyBlue;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(952, 363);
            this.guna2GradientPanel1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(909, 170);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Curso:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNome.Location = new System.Drawing.Point(164, 65);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(165, 25);
            this.txtBoxNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo do Curso:";
            // 
            // txtBoxTipo
            // 
            this.txtBoxTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxTipo.Location = new System.Drawing.Point(153, 95);
            this.txtBoxTipo.Name = "txtBoxTipo";
            this.txtBoxTipo.Size = new System.Drawing.Size(176, 25);
            this.txtBoxTipo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data de Início:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data de Término";
            // 
            // txtBoxDataI
            // 
            this.txtBoxDataI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDataI.Location = new System.Drawing.Point(473, 65);
            this.txtBoxDataI.Name = "txtBoxDataI";
            this.txtBoxDataI.Size = new System.Drawing.Size(195, 25);
            this.txtBoxDataI.TabIndex = 2;
            // 
            // txtBoxDataT
            // 
            this.txtBoxDataT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDataT.Location = new System.Drawing.Point(492, 96);
            this.txtBoxDataT.Name = "txtBoxDataT";
            this.txtBoxDataT.Size = new System.Drawing.Size(176, 25);
            this.txtBoxDataT.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Id:";
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(54, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(30, 32);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "0";
            // 
            // cBoxPesquisa
            // 
            this.cBoxPesquisa.AutoCompleteCustomSource.AddRange(new string[] {
            "Id",
            "Nome",
            "Tipo",
            "Data de início",
            "Data de término"});
            this.cBoxPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPesquisa.FormattingEnabled = true;
            this.cBoxPesquisa.Items.AddRange(new object[] {
            "Id",
            "Nome",
            "Tipo",
            "Data de Início",
            "Data de Término"});
            this.cBoxPesquisa.Location = new System.Drawing.Point(423, 18);
            this.cBoxPesquisa.Name = "cBoxPesquisa";
            this.cBoxPesquisa.Size = new System.Drawing.Size(119, 28);
            this.cBoxPesquisa.TabIndex = 3;
            // 
            // txtBoxPesquisa
            // 
            this.txtBoxPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPesquisa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPesquisa.Location = new System.Drawing.Point(548, 19);
            this.txtBoxPesquisa.Name = "txtBoxPesquisa";
            this.txtBoxPesquisa.Size = new System.Drawing.Size(293, 26);
            this.txtBoxPesquisa.TabIndex = 4;
            // 
            // btPesquisar
            // 
            this.btPesquisar.BorderColor = System.Drawing.Color.Gray;
            this.btPesquisar.BorderThickness = 1;
            this.btPesquisar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btPesquisar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btPesquisar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btPesquisar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btPesquisar.FillColor = System.Drawing.SystemColors.Control;
            this.btPesquisar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btPesquisar.Location = new System.Drawing.Point(847, 19);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(84, 27);
            this.btPesquisar.TabIndex = 5;
            this.btPesquisar.Text = "Pesquisar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(261, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Pesquisar:";
            // 
            // btLimpar
            // 
            this.btLimpar.BorderColor = System.Drawing.Color.Gray;
            this.btLimpar.BorderThickness = 1;
            this.btLimpar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btLimpar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btLimpar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btLimpar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btLimpar.FillColor = System.Drawing.SystemColors.Control;
            this.btLimpar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.Color.Black;
            this.btLimpar.Location = new System.Drawing.Point(674, 80);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(84, 27);
            this.btLimpar.TabIndex = 5;
            this.btLimpar.Text = "Limpar";
            // 
            // btAdicionar
            // 
            this.btAdicionar.BorderColor = System.Drawing.Color.Gray;
            this.btAdicionar.BorderThickness = 1;
            this.btAdicionar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAdicionar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAdicionar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAdicionar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAdicionar.FillColor = System.Drawing.SystemColors.Control;
            this.btAdicionar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionar.ForeColor = System.Drawing.Color.Black;
            this.btAdicionar.Location = new System.Drawing.Point(22, 144);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(84, 27);
            this.btAdicionar.TabIndex = 5;
            this.btAdicionar.Text = "Adicionar";
            // 
            // btExcluir
            // 
            this.btExcluir.BorderColor = System.Drawing.Color.Gray;
            this.btExcluir.BorderThickness = 1;
            this.btExcluir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btExcluir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btExcluir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btExcluir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btExcluir.FillColor = System.Drawing.SystemColors.Control;
            this.btExcluir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.Color.Black;
            this.btExcluir.Location = new System.Drawing.Point(112, 144);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(84, 27);
            this.btExcluir.TabIndex = 5;
            this.btExcluir.Text = "Excluir";
            // 
            // TelaCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TelaCursos";
            this.Size = new System.Drawing.Size(952, 363);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btPesquisar;
        private System.Windows.Forms.TextBox txtBoxPesquisa;
        private System.Windows.Forms.ComboBox cBoxPesquisa;
        private System.Windows.Forms.TextBox txtBoxDataT;
        private System.Windows.Forms.TextBox txtBoxTipo;
        private System.Windows.Forms.TextBox txtBoxDataI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btExcluir;
        private Guna.UI2.WinForms.Guna2Button btAdicionar;
        private Guna.UI2.WinForms.Guna2Button btLimpar;
    }
}
