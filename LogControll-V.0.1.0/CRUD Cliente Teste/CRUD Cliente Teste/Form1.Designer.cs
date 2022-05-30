
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btMatriculas = new Guna.UI2.WinForms.Guna2Button();
            this.btCursos = new Guna.UI2.WinForms.Guna2Button();
            this.btAlunos = new Guna.UI2.WinForms.Guna2Button();
            this.panelUserControl = new System.Windows.Forms.Panel();
            this.btClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 57);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btMatriculas);
            this.panel2.Controls.Add(this.btCursos);
            this.panel2.Controls.Add(this.btAlunos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 52);
            this.panel2.TabIndex = 6;
            // 
            // btMatriculas
            // 
            this.btMatriculas.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btMatriculas.CheckedState.CustomBorderColor = System.Drawing.Color.Salmon;
            this.btMatriculas.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btMatriculas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btMatriculas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btMatriculas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btMatriculas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btMatriculas.FillColor = System.Drawing.Color.White;
            this.btMatriculas.FocusedColor = System.Drawing.Color.Transparent;
            this.btMatriculas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btMatriculas.ForeColor = System.Drawing.Color.Black;
            this.btMatriculas.HoverState.CustomBorderColor = System.Drawing.Color.Salmon;
            this.btMatriculas.Location = new System.Drawing.Point(317, 4);
            this.btMatriculas.Name = "btMatriculas";
            this.btMatriculas.Size = new System.Drawing.Size(151, 45);
            this.btMatriculas.TabIndex = 0;
            this.btMatriculas.Text = "Matrículas";
            this.btMatriculas.Click += new System.EventHandler(this.btMatriculas_Click);
            // 
            // btCursos
            // 
            this.btCursos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btCursos.CheckedState.CustomBorderColor = System.Drawing.Color.Salmon;
            this.btCursos.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btCursos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCursos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCursos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCursos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCursos.FillColor = System.Drawing.Color.White;
            this.btCursos.FocusedColor = System.Drawing.Color.Transparent;
            this.btCursos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btCursos.ForeColor = System.Drawing.Color.Black;
            this.btCursos.HoverState.CustomBorderColor = System.Drawing.Color.Salmon;
            this.btCursos.Location = new System.Drawing.Point(160, 4);
            this.btCursos.Name = "btCursos";
            this.btCursos.Size = new System.Drawing.Size(151, 45);
            this.btCursos.TabIndex = 0;
            this.btCursos.Text = "Cursos";
            this.btCursos.Click += new System.EventHandler(this.btCursos_Click);
            // 
            // btAlunos
            // 
            this.btAlunos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btAlunos.Checked = true;
            this.btAlunos.CheckedState.CustomBorderColor = System.Drawing.Color.Salmon;
            this.btAlunos.CheckedState.FillColor = System.Drawing.Color.White;
            this.btAlunos.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btAlunos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAlunos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAlunos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAlunos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAlunos.FillColor = System.Drawing.Color.White;
            this.btAlunos.FocusedColor = System.Drawing.Color.Transparent;
            this.btAlunos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btAlunos.ForeColor = System.Drawing.Color.Black;
            this.btAlunos.HoverState.CustomBorderColor = System.Drawing.Color.Salmon;
            this.btAlunos.Location = new System.Drawing.Point(3, 3);
            this.btAlunos.Name = "btAlunos";
            this.btAlunos.Size = new System.Drawing.Size(151, 45);
            this.btAlunos.TabIndex = 0;
            this.btAlunos.Text = "Alunos";
            this.btAlunos.Click += new System.EventHandler(this.btAlunos_Click);
            // 
            // panelUserControl
            // 
            this.panelUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserControl.Location = new System.Drawing.Point(0, 109);
            this.panelUserControl.Name = "panelUserControl";
            this.panelUserControl.Size = new System.Drawing.Size(952, 363);
            this.panelUserControl.TabIndex = 7;
            // 
            // btClose
            // 
            this.btClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btClose.FillColor = System.Drawing.Color.Black;
            this.btClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Location = new System.Drawing.Point(910, 12);
            this.btClose.Name = "btClose";
            this.btClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btClose.Size = new System.Drawing.Size(30, 30);
            this.btClose.TabIndex = 9;
            this.btClose.Text = "X";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 472);
            this.Controls.Add(this.panelUserControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btMatriculas;
        private Guna.UI2.WinForms.Guna2Button btCursos;
        private Guna.UI2.WinForms.Guna2Button btAlunos;
        private System.Windows.Forms.Panel panelUserControl;
        private Guna.UI2.WinForms.Guna2CircleButton btClose;
    }
}

