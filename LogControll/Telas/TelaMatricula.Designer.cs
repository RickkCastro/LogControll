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
            this.dgvMatriculas = new System.Windows.Forms.DataGridView();
            this.btExcluir = new Guna.UI2.WinForms.Guna2Button();
            this.btEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btAdicionar = new Guna.UI2.WinForms.Guna2Button();
            this.btLimpar = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxAluno = new System.Windows.Forms.ComboBox();
            this.cBoxCurso = new System.Windows.Forms.ComboBox();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.txtID);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.cBoxCurso);
            this.guna2GradientPanel1.Controls.Add(this.cBoxAluno);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.btExcluir);
            this.guna2GradientPanel1.Controls.Add(this.btEditar);
            this.guna2GradientPanel1.Controls.Add(this.btAdicionar);
            this.guna2GradientPanel1.Controls.Add(this.btLimpar);
            this.guna2GradientPanel1.Controls.Add(this.dgvAlunos);
            this.guna2GradientPanel1.Controls.Add(this.dgvCursos);
            this.guna2GradientPanel1.Controls.Add(this.dgvMatriculas);
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
            // dgvMatriculas
            // 
            this.dgvMatriculas.AllowUserToAddRows = false;
            this.dgvMatriculas.AllowUserToDeleteRows = false;
            this.dgvMatriculas.AllowUserToResizeColumns = false;
            this.dgvMatriculas.AllowUserToResizeRows = false;
            this.dgvMatriculas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMatriculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriculas.Location = new System.Drawing.Point(22, 177);
            this.dgvMatriculas.MultiSelect = false;
            this.dgvMatriculas.Name = "dgvMatriculas";
            this.dgvMatriculas.ReadOnly = true;
            this.dgvMatriculas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvMatriculas.Size = new System.Drawing.Size(909, 170);
            this.dgvMatriculas.TabIndex = 1;
            this.dgvMatriculas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMatriculas_CellMouseClick);
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
            this.btExcluir.Location = new System.Drawing.Point(667, 144);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(84, 27);
            this.btExcluir.TabIndex = 6;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btEditar
            // 
            this.btEditar.BorderColor = System.Drawing.Color.Gray;
            this.btEditar.BorderThickness = 1;
            this.btEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btEditar.FillColor = System.Drawing.SystemColors.Control;
            this.btEditar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.Color.Black;
            this.btEditar.Location = new System.Drawing.Point(757, 144);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(84, 27);
            this.btEditar.TabIndex = 7;
            this.btEditar.Text = "Editar";
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
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
            this.btAdicionar.Location = new System.Drawing.Point(577, 144);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(84, 27);
            this.btAdicionar.TabIndex = 8;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
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
            this.btLimpar.Location = new System.Drawing.Point(847, 144);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(84, 27);
            this.btLimpar.TabIndex = 9;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Alunos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cursos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(576, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Aluno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(576, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Curso:";
            // 
            // cBoxAluno
            // 
            this.cBoxAluno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxAluno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxAluno.FormattingEnabled = true;
            this.cBoxAluno.Location = new System.Drawing.Point(644, 57);
            this.cBoxAluno.Name = "cBoxAluno";
            this.cBoxAluno.Size = new System.Drawing.Size(287, 28);
            this.cBoxAluno.TabIndex = 11;
            // 
            // cBoxCurso
            // 
            this.cBoxCurso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxCurso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxCurso.FormattingEnabled = true;
            this.cBoxCurso.Items.AddRange(new object[] {
            "sadsadasds",
            "dasdasd",
            "d",
            "asd",
            "asd",
            "as",
            "das",
            "das",
            "d"});
            this.cBoxCurso.Location = new System.Drawing.Point(644, 91);
            this.cBoxCurso.Name = "cBoxCurso";
            this.cBoxCurso.Size = new System.Drawing.Size(287, 28);
            this.cBoxCurso.TabIndex = 11;
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AllowUserToResizeColumns = false;
            this.dgvCursos.AllowUserToResizeRows = false;
            this.dgvCursos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(300, 54);
            this.dgvCursos.MultiSelect = false;
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCursos.Size = new System.Drawing.Size(271, 112);
            this.dgvCursos.TabIndex = 1;
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AllowUserToDeleteRows = false;
            this.dgvAlunos.AllowUserToResizeColumns = false;
            this.dgvAlunos.AllowUserToResizeRows = false;
            this.dgvAlunos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(22, 54);
            this.dgvAlunos.MultiSelect = false;
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAlunos.Size = new System.Drawing.Size(271, 112);
            this.dgvAlunos.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(612, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(30, 32);
            this.txtID.TabIndex = 12;
            this.txtID.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(575, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Id:";
            // 
            // TelaMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TelaMatricula";
            this.Size = new System.Drawing.Size(952, 363);
            this.Load += new System.EventHandler(this.TelaMatricula_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.DataGridView dgvMatriculas;
        private Guna.UI2.WinForms.Guna2Button btExcluir;
        private Guna.UI2.WinForms.Guna2Button btEditar;
        private Guna.UI2.WinForms.Guna2Button btAdicionar;
        private Guna.UI2.WinForms.Guna2Button btLimpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxCurso;
        private System.Windows.Forms.ComboBox cBoxAluno;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label label5;
    }
}
