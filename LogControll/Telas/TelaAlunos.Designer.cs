namespace LogControll.Telas
{
    partial class TelaAlunos
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
            this.label7 = new System.Windows.Forms.Label();
            this.btEditar = new Guna.UI2.WinForms.Guna2Button();
            this.rBtSexoM = new System.Windows.Forms.RadioButton();
            this.rBtSexoF = new System.Windows.Forms.RadioButton();
            this.txtIdade = new System.Windows.Forms.NumericUpDown();
            this.btExcluir = new Guna.UI2.WinForms.Guna2Button();
            this.btAdicionar = new Guna.UI2.WinForms.Guna2Button();
            this.btLimpar = new Guna.UI2.WinForms.Guna2Button();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.dgvDados);
            this.guna2GradientPanel1.Controls.Add(this.label7);
            this.guna2GradientPanel1.Controls.Add(this.btEditar);
            this.guna2GradientPanel1.Controls.Add(this.rBtSexoM);
            this.guna2GradientPanel1.Controls.Add(this.rBtSexoF);
            this.guna2GradientPanel1.Controls.Add(this.txtIdade);
            this.guna2GradientPanel1.Controls.Add(this.btExcluir);
            this.guna2GradientPanel1.Controls.Add(this.btAdicionar);
            this.guna2GradientPanel1.Controls.Add(this.btLimpar);
            this.guna2GradientPanel1.Controls.Add(this.txtBoxEmail);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.txtBoxNome);
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.txtID);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.label1);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(593, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(338, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Clique nos dados para consultar";
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
            this.btEditar.Location = new System.Drawing.Point(202, 144);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(84, 27);
            this.btEditar.TabIndex = 9;
            this.btEditar.Text = "Editar";
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // rBtSexoM
            // 
            this.rBtSexoM.AutoSize = true;
            this.rBtSexoM.Location = new System.Drawing.Point(382, 99);
            this.rBtSexoM.Name = "rBtSexoM";
            this.rBtSexoM.Size = new System.Drawing.Size(38, 24);
            this.rBtSexoM.TabIndex = 7;
            this.rBtSexoM.TabStop = true;
            this.rBtSexoM.Text = "M";
            this.rBtSexoM.UseVisualStyleBackColor = true;
            // 
            // rBtSexoF
            // 
            this.rBtSexoF.AutoSize = true;
            this.rBtSexoF.Location = new System.Drawing.Point(341, 99);
            this.rBtSexoF.Name = "rBtSexoF";
            this.rBtSexoF.Size = new System.Drawing.Size(35, 24);
            this.rBtSexoF.TabIndex = 7;
            this.rBtSexoF.TabStop = true;
            this.rBtSexoF.Text = "F";
            this.rBtSexoF.UseVisualStyleBackColor = true;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(85, 97);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(176, 25);
            this.txtIdade.TabIndex = 6;
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
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
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
            this.btLimpar.Location = new System.Drawing.Point(292, 144);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(84, 27);
            this.btLimpar.TabIndex = 5;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxEmail.Location = new System.Drawing.Point(345, 67);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(215, 25);
            this.txtBoxEmail.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sexo:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNome.Location = new System.Drawing.Point(85, 68);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(176, 25);
            this.txtBoxNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToResizeColumns = false;
            this.dgvDados.AllowUserToResizeRows = false;
            this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(22, 177);
            this.dgvDados.MultiSelect = false;
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDados.Size = new System.Drawing.Size(909, 170);
            this.dgvDados.TabIndex = 12;
            this.dgvDados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDados_CellMouseClick);
            // 
            // TelaAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TelaAlunos";
            this.Size = new System.Drawing.Size(952, 363);
            this.Load += new System.EventHandler(this.TelaAlunos_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btExcluir;
        private Guna.UI2.WinForms.Guna2Button btAdicionar;
        private Guna.UI2.WinForms.Guna2Button btLimpar;
        private System.Windows.Forms.RadioButton rBtSexoM;
        private System.Windows.Forms.RadioButton rBtSexoF;
        private System.Windows.Forms.NumericUpDown txtIdade;
        private Guna.UI2.WinForms.Guna2Button btEditar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDados;
    }
}
