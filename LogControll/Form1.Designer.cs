namespace LogControll
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btMatriculas = new Guna.UI2.WinForms.Guna2Button();
            this.btCursos = new Guna.UI2.WinForms.Guna2Button();
            this.btAlunos = new Guna.UI2.WinForms.Guna2Button();
            this.panelUserControl = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
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
            this.panel2.Controls.Add(this.guna2Button4);
            this.panel2.Controls.Add(this.btMatriculas);
            this.panel2.Controls.Add(this.guna2Button3);
            this.panel2.Controls.Add(this.btCursos);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.guna2Button2);
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
            this.btMatriculas.Location = new System.Drawing.Point(461, 7);
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
            this.btCursos.Location = new System.Drawing.Point(304, 7);
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
            this.btAlunos.Location = new System.Drawing.Point(147, 6);
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
            // guna2Button1
            // 
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.Checked = true;
            this.guna2Button1.CheckedState.CustomBorderColor = System.Drawing.Color.Salmon;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.FocusedColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.Salmon;
            this.guna2Button1.Location = new System.Drawing.Point(0, 7);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(151, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Home";
            this.guna2Button1.Click += new System.EventHandler(this.btHome_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.CheckedState.CustomBorderColor = System.Drawing.Color.Salmon;
            this.guna2Button2.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.FocusedColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.Salmon;
            this.guna2Button2.Location = new System.Drawing.Point(157, 7);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(151, 45);
            this.guna2Button2.TabIndex = 0;
            this.guna2Button2.Text = "Alunos";
            this.guna2Button2.Click += new System.EventHandler(this.btAlunos_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button3.CheckedState.CustomBorderColor = System.Drawing.Color.Salmon;
            this.guna2Button3.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.White;
            this.guna2Button3.FocusedColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.HoverState.CustomBorderColor = System.Drawing.Color.Salmon;
            this.guna2Button3.Location = new System.Drawing.Point(314, 7);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(151, 45);
            this.guna2Button3.TabIndex = 0;
            this.guna2Button3.Text = "Cursos";
            this.guna2Button3.Click += new System.EventHandler(this.btCursos_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button4.CheckedState.CustomBorderColor = System.Drawing.Color.Salmon;
            this.guna2Button4.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.White;
            this.guna2Button4.FocusedColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.Black;
            this.guna2Button4.HoverState.CustomBorderColor = System.Drawing.Color.Salmon;
            this.guna2Button4.Location = new System.Drawing.Point(471, 7);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(151, 45);
            this.guna2Button4.TabIndex = 0;
            this.guna2Button4.Text = "Matrículas";
            this.guna2Button4.Click += new System.EventHandler(this.btMatriculas_Click);
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
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}

