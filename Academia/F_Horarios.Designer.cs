namespace Academia
{
    partial class F_Horarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_idHorario = new System.Windows.Forms.TextBox();
            this.mtb_descHorario = new System.Windows.Forms.MaskedTextBox();
            this.dgv_horarios = new System.Windows.Forms.DataGridView();
            this.btn_novoUsuario = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_exlcuir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horário";
            // 
            // tb_idHorario
            // 
            this.tb_idHorario.Location = new System.Drawing.Point(12, 25);
            this.tb_idHorario.Name = "tb_idHorario";
            this.tb_idHorario.ReadOnly = true;
            this.tb_idHorario.Size = new System.Drawing.Size(62, 20);
            this.tb_idHorario.TabIndex = 2;
            this.tb_idHorario.TabStop = false;
            // 
            // mtb_descHorario
            // 
            this.mtb_descHorario.Location = new System.Drawing.Point(80, 25);
            this.mtb_descHorario.Mask = "00\\h00 \\- 00\\h00";
            this.mtb_descHorario.Name = "mtb_descHorario";
            this.mtb_descHorario.Size = new System.Drawing.Size(100, 20);
            this.mtb_descHorario.TabIndex = 3;
            // 
            // dgv_horarios
            // 
            this.dgv_horarios.AllowUserToAddRows = false;
            this.dgv_horarios.AllowUserToDeleteRows = false;
            this.dgv_horarios.AllowUserToResizeColumns = false;
            this.dgv_horarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_horarios.EnableHeadersVisualStyles = false;
            this.dgv_horarios.Location = new System.Drawing.Point(12, 51);
            this.dgv_horarios.MultiSelect = false;
            this.dgv_horarios.Name = "dgv_horarios";
            this.dgv_horarios.ReadOnly = true;
            this.dgv_horarios.RowHeadersVisible = false;
            this.dgv_horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_horarios.Size = new System.Drawing.Size(435, 424);
            this.dgv_horarios.TabIndex = 4;
            this.dgv_horarios.SelectionChanged += new System.EventHandler(this.dgv_horarios_SelectionChanged);
            // 
            // btn_novoUsuario
            // 
            this.btn_novoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novoUsuario.Location = new System.Drawing.Point(12, 481);
            this.btn_novoUsuario.Name = "btn_novoUsuario";
            this.btn_novoUsuario.Size = new System.Drawing.Size(106, 23);
            this.btn_novoUsuario.TabIndex = 5;
            this.btn_novoUsuario.Text = "Novo Horário";
            this.btn_novoUsuario.UseVisualStyleBackColor = true;
            this.btn_novoUsuario.Click += new System.EventHandler(this.btn_novoUsuario_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.Location = new System.Drawing.Point(124, 481);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(108, 23);
            this.btn_salvar.TabIndex = 6;
            this.btn_salvar.Text = "Salvar Horário";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_exlcuir
            // 
            this.btn_exlcuir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exlcuir.Location = new System.Drawing.Point(238, 481);
            this.btn_exlcuir.Name = "btn_exlcuir";
            this.btn_exlcuir.Size = new System.Drawing.Size(113, 23);
            this.btn_exlcuir.TabIndex = 7;
            this.btn_exlcuir.Text = "Excluir Horário";
            this.btn_exlcuir.UseVisualStyleBackColor = true;
            this.btn_exlcuir.Click += new System.EventHandler(this.btn_exlcuir_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Location = new System.Drawing.Point(372, 481);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 8;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // F_Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 512);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_exlcuir);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_novoUsuario);
            this.Controls.Add(this.dgv_horarios);
            this.Controls.Add(this.mtb_descHorario);
            this.Controls.Add(this.tb_idHorario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Horarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horários";
            this.Load += new System.EventHandler(this.F_Horarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_idHorario;
        private System.Windows.Forms.MaskedTextBox mtb_descHorario;
        private System.Windows.Forms.DataGridView dgv_horarios;
        private System.Windows.Forms.Button btn_novoUsuario;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_exlcuir;
        private System.Windows.Forms.Button btn_fechar;
    }
}