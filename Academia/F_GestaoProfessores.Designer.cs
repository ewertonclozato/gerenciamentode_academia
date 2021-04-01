namespace Academia
{
    partial class F_GestaoProfessores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_exlcuir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novoProfessor = new System.Windows.Forms.Button();
            this.dgv_professores = new System.Windows.Forms.DataGridView();
            this.tb_idProfessor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nomeProfessor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_telefoneProfessores = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professores)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Location = new System.Drawing.Point(375, 481);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 17;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_exlcuir
            // 
            this.btn_exlcuir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exlcuir.Location = new System.Drawing.Point(241, 481);
            this.btn_exlcuir.Name = "btn_exlcuir";
            this.btn_exlcuir.Size = new System.Drawing.Size(113, 23);
            this.btn_exlcuir.TabIndex = 16;
            this.btn_exlcuir.Text = "Excluir";
            this.btn_exlcuir.UseVisualStyleBackColor = true;
            this.btn_exlcuir.Click += new System.EventHandler(this.btn_exlcuir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.Location = new System.Drawing.Point(127, 481);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(108, 23);
            this.btn_salvar.TabIndex = 15;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novoProfessor
            // 
            this.btn_novoProfessor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novoProfessor.Location = new System.Drawing.Point(15, 481);
            this.btn_novoProfessor.Name = "btn_novoProfessor";
            this.btn_novoProfessor.Size = new System.Drawing.Size(106, 23);
            this.btn_novoProfessor.TabIndex = 14;
            this.btn_novoProfessor.Text = "Novo Professor";
            this.btn_novoProfessor.UseVisualStyleBackColor = true;
            this.btn_novoProfessor.Click += new System.EventHandler(this.btn_novoProfessor_Click);
            // 
            // dgv_professores
            // 
            this.dgv_professores.AllowUserToAddRows = false;
            this.dgv_professores.AllowUserToDeleteRows = false;
            this.dgv_professores.AllowUserToResizeColumns = false;
            this.dgv_professores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_professores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_professores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_professores.EnableHeadersVisualStyles = false;
            this.dgv_professores.Location = new System.Drawing.Point(15, 51);
            this.dgv_professores.MultiSelect = false;
            this.dgv_professores.Name = "dgv_professores";
            this.dgv_professores.ReadOnly = true;
            this.dgv_professores.RowHeadersVisible = false;
            this.dgv_professores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_professores.Size = new System.Drawing.Size(435, 424);
            this.dgv_professores.TabIndex = 13;
            this.dgv_professores.SelectionChanged += new System.EventHandler(this.dgv_professores_SelectionChanged);
            // 
            // tb_idProfessor
            // 
            this.tb_idProfessor.Enabled = false;
            this.tb_idProfessor.Location = new System.Drawing.Point(15, 25);
            this.tb_idProfessor.Name = "tb_idProfessor";
            this.tb_idProfessor.ReadOnly = true;
            this.tb_idProfessor.Size = new System.Drawing.Size(62, 20);
            this.tb_idProfessor.TabIndex = 11;
            this.tb_idProfessor.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Professor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // tb_nomeProfessor
            // 
            this.tb_nomeProfessor.Location = new System.Drawing.Point(83, 25);
            this.tb_nomeProfessor.Name = "tb_nomeProfessor";
            this.tb_nomeProfessor.Size = new System.Drawing.Size(219, 20);
            this.tb_nomeProfessor.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Telefone";
            // 
            // mtb_telefoneProfessores
            // 
            this.mtb_telefoneProfessores.Location = new System.Drawing.Point(308, 25);
            this.mtb_telefoneProfessores.Mask = "(00)00000-0000";
            this.mtb_telefoneProfessores.Name = "mtb_telefoneProfessores";
            this.mtb_telefoneProfessores.Size = new System.Drawing.Size(142, 20);
            this.mtb_telefoneProfessores.TabIndex = 20;
            // 
            // F_GestaoProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 516);
            this.Controls.Add(this.mtb_telefoneProfessores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nomeProfessor);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_exlcuir);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_novoProfessor);
            this.Controls.Add(this.dgv_professores);
            this.Controls.Add(this.tb_idProfessor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Professores";
            this.Load += new System.EventHandler(this.F_GestaoProfessores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_exlcuir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novoProfessor;
        private System.Windows.Forms.DataGridView dgv_professores;
        private System.Windows.Forms.TextBox tb_idProfessor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nomeProfessor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtb_telefoneProfessores;
    }
}