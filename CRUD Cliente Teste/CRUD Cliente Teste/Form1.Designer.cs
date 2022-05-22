
namespace CRUD_Cliente_Teste
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btExibir = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btLimpar = new System.Windows.Forms.Button();
            this.txtBoxNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(77, 36);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(108, 20);
            this.txtBoxNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(0, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numero:";
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(11, 88);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(64, 20);
            this.btAdicionar.TabIndex = 2;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Enabled = false;
            this.btEditar.Location = new System.Drawing.Point(81, 88);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(64, 20);
            this.btEditar.TabIndex = 2;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Location = new System.Drawing.Point(150, 88);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(64, 20);
            this.btExcluir.TabIndex = 2;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(219, 88);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(64, 20);
            this.btConsultar.TabIndex = 2;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btExibir
            // 
            this.btExibir.Location = new System.Drawing.Point(289, 88);
            this.btExibir.Name = "btExibir";
            this.btExibir.Size = new System.Drawing.Size(64, 20);
            this.btExibir.TabIndex = 2;
            this.btExibir.Text = "Exibir";
            this.btExibir.UseVisualStyleBackColor = true;
            this.btExibir.Click += new System.EventHandler(this.btExibir_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(11, 113);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersWidth = 40;
            this.dgvDados.RowTemplate.Height = 25;
            this.dgvDados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDados.Size = new System.Drawing.Size(342, 150);
            this.dgvDados.TabIndex = 3;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(191, 38);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(64, 20);
            this.btLimpar.TabIndex = 2;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // txtBoxNumero
            // 
            this.txtBoxNumero.Location = new System.Drawing.Point(77, 61);
            this.txtBoxNumero.Name = "txtBoxNumero";
            this.txtBoxNumero.Size = new System.Drawing.Size(108, 20);
            this.txtBoxNumero.TabIndex = 1;
            this.txtBoxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNumero_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(77, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(108, 20);
            this.txtId.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 279);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btExibir);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.txtBoxNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btExibir;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.TextBox txtBoxNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
    }
}

