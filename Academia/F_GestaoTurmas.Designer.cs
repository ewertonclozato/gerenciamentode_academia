namespace Academia
{
    partial class F_GestaoTurmas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_turmas = new System.Windows.Forms.DataGridView();
            this.btn_novaTurma = new System.Windows.Forms.Button();
            this.btn_salvasAlteracoes = new System.Windows.Forms.Button();
            this.btn_excluirTurma = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_professor = new System.Windows.Forms.ComboBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.cb_horarios = new System.Windows.Forms.ComboBox();
            this.nud_maximoalunos = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_turma = new System.Windows.Forms.TextBox();
            this.lb_idTurma = new System.Windows.Forms.Label();
            this.tb_vagas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maximoalunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_turmas
            // 
            this.dgv_turmas.AllowUserToAddRows = false;
            this.dgv_turmas.AllowUserToDeleteRows = false;
            this.dgv_turmas.AllowUserToResizeColumns = false;
            this.dgv_turmas.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_turmas.EnableHeadersVisualStyles = false;
            this.dgv_turmas.Location = new System.Drawing.Point(12, 12);
            this.dgv_turmas.MultiSelect = false;
            this.dgv_turmas.Name = "dgv_turmas";
            this.dgv_turmas.ReadOnly = true;
            this.dgv_turmas.RowHeadersVisible = false;
            this.dgv_turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_turmas.Size = new System.Drawing.Size(435, 463);
            this.dgv_turmas.TabIndex = 14;
            this.dgv_turmas.SelectionChanged += new System.EventHandler(this.dgv_turmas_SelectionChanged);
            // 
            // btn_novaTurma
            // 
            this.btn_novaTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novaTurma.Location = new System.Drawing.Point(12, 482);
            this.btn_novaTurma.Name = "btn_novaTurma";
            this.btn_novaTurma.Size = new System.Drawing.Size(154, 23);
            this.btn_novaTurma.TabIndex = 5;
            this.btn_novaTurma.Text = "Nova Turma";
            this.btn_novaTurma.UseVisualStyleBackColor = true;
            this.btn_novaTurma.Click += new System.EventHandler(this.btn_novaTurma_Click);
            // 
            // btn_salvasAlteracoes
            // 
            this.btn_salvasAlteracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvasAlteracoes.Location = new System.Drawing.Point(172, 482);
            this.btn_salvasAlteracoes.Name = "btn_salvasAlteracoes";
            this.btn_salvasAlteracoes.Size = new System.Drawing.Size(154, 23);
            this.btn_salvasAlteracoes.TabIndex = 6;
            this.btn_salvasAlteracoes.Text = "Salvar Alterações";
            this.btn_salvasAlteracoes.UseVisualStyleBackColor = true;
            this.btn_salvasAlteracoes.Click += new System.EventHandler(this.btn_salvasAlteracoes_Click);
            // 
            // btn_excluirTurma
            // 
            this.btn_excluirTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluirTurma.Location = new System.Drawing.Point(332, 481);
            this.btn_excluirTurma.Name = "btn_excluirTurma";
            this.btn_excluirTurma.Size = new System.Drawing.Size(154, 23);
            this.btn_excluirTurma.TabIndex = 7;
            this.btn_excluirTurma.Text = "Excluir Turma";
            this.btn_excluirTurma.UseVisualStyleBackColor = true;
            this.btn_excluirTurma.Click += new System.EventHandler(this.btn_excluirTurma_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir.Location = new System.Drawing.Point(492, 481);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(154, 23);
            this.btn_imprimir.TabIndex = 8;
            this.btn_imprimir.Text = "Imprimir Turma";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Location = new System.Drawing.Point(652, 481);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(68, 23);
            this.btn_fechar.TabIndex = 9;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Professor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Máximo Alunos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Horário";
            // 
            // cb_professor
            // 
            this.cb_professor.FormattingEnabled = true;
            this.cb_professor.Location = new System.Drawing.Point(456, 80);
            this.cb_professor.Name = "cb_professor";
            this.cb_professor.Size = new System.Drawing.Size(264, 21);
            this.cb_professor.TabIndex = 1;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(598, 135);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(122, 21);
            this.cb_status.TabIndex = 3;
            // 
            // cb_horarios
            // 
            this.cb_horarios.FormattingEnabled = true;
            this.cb_horarios.Location = new System.Drawing.Point(456, 188);
            this.cb_horarios.Name = "cb_horarios";
            this.cb_horarios.Size = new System.Drawing.Size(264, 21);
            this.cb_horarios.TabIndex = 4;
            // 
            // nud_maximoalunos
            // 
            this.nud_maximoalunos.Location = new System.Drawing.Point(456, 135);
            this.nud_maximoalunos.Name = "nud_maximoalunos";
            this.nud_maximoalunos.Size = new System.Drawing.Size(136, 20);
            this.nud_maximoalunos.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Turma";
            // 
            // tb_turma
            // 
            this.tb_turma.Location = new System.Drawing.Point(456, 28);
            this.tb_turma.Name = "tb_turma";
            this.tb_turma.Size = new System.Drawing.Size(264, 20);
            this.tb_turma.TabIndex = 1;
            // 
            // lb_idTurma
            // 
            this.lb_idTurma.AutoSize = true;
            this.lb_idTurma.Enabled = false;
            this.lb_idTurma.Location = new System.Drawing.Point(478, 252);
            this.lb_idTurma.Name = "lb_idTurma";
            this.lb_idTurma.Size = new System.Drawing.Size(0, 13);
            this.lb_idTurma.TabIndex = 26;
            this.lb_idTurma.Visible = false;
            // 
            // tb_vagas
            // 
            this.tb_vagas.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_vagas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_vagas.Location = new System.Drawing.Point(456, 239);
            this.tb_vagas.Name = "tb_vagas";
            this.tb_vagas.ReadOnly = true;
            this.tb_vagas.Size = new System.Drawing.Size(100, 20);
            this.tb_vagas.TabIndex = 27;
            this.tb_vagas.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Vagas";
            // 
            // F_GestaoTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 511);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_vagas);
            this.Controls.Add(this.lb_idTurma);
            this.Controls.Add(this.tb_turma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nud_maximoalunos);
            this.Controls.Add(this.cb_horarios);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.cb_professor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_excluirTurma);
            this.Controls.Add(this.btn_salvasAlteracoes);
            this.Controls.Add(this.btn_novaTurma);
            this.Controls.Add(this.dgv_turmas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Turmas";
            this.Load += new System.EventHandler(this.F_GestaoTurmas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maximoalunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_turmas;
        private System.Windows.Forms.Button btn_novaTurma;
        private System.Windows.Forms.Button btn_salvasAlteracoes;
        private System.Windows.Forms.Button btn_excluirTurma;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_professor;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.ComboBox cb_horarios;
        private System.Windows.Forms.NumericUpDown nud_maximoalunos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_turma;
        private System.Windows.Forms.Label lb_idTurma;
        private System.Windows.Forms.TextBox tb_vagas;
        private System.Windows.Forms.Label label6;
    }
}