namespace Academia
{
    partial class F_NovoAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.tb_turma = new System.Windows.Forms.TextBox();
            this.tb_plano = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_gravar = new System.Windows.Forms.Button();
            this.bt_Novo = new System.Windows.Forms.Button();
            this.bt_pesquisarTurma = new System.Windows.Forms.Button();
            this.bt_pesqusarPlano = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pic_foto = new System.Windows.Forms.PictureBox();
            this.btnadcFoto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Turma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Plano";
            // 
            // tb_nome
            // 
            this.tb_nome.Enabled = false;
            this.tb_nome.Location = new System.Drawing.Point(12, 25);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(312, 20);
            this.tb_nome.TabIndex = 5;
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Enabled = false;
            this.mtb_telefone.Location = new System.Drawing.Point(334, 25);
            this.mtb_telefone.Mask = "(00)00000-0000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(86, 20);
            this.mtb_telefone.TabIndex = 6;
            // 
            // cb_status
            // 
            this.cb_status.Enabled = false;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(12, 80);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(133, 21);
            this.cb_status.TabIndex = 7;
            // 
            // tb_turma
            // 
            this.tb_turma.Enabled = false;
            this.tb_turma.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_turma.Location = new System.Drawing.Point(159, 80);
            this.tb_turma.Name = "tb_turma";
            this.tb_turma.ReadOnly = true;
            this.tb_turma.Size = new System.Drawing.Size(239, 20);
            this.tb_turma.TabIndex = 8;
            this.tb_turma.TabStop = false;
            this.tb_turma.Tag = "7";
            this.tb_turma.Click += new System.EventHandler(this.tb_turma_Click);
            this.tb_turma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_turma_MouseClick);
            this.tb_turma.DoubleClick += new System.EventHandler(this.tb_turma_DoubleClick);
            this.tb_turma.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tb_turma_MouseMove);
            // 
            // tb_plano
            // 
            this.tb_plano.Enabled = false;
            this.tb_plano.Location = new System.Drawing.Point(12, 139);
            this.tb_plano.Name = "tb_plano";
            this.tb_plano.ReadOnly = true;
            this.tb_plano.Size = new System.Drawing.Size(261, 20);
            this.tb_plano.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_fechar);
            this.panel1.Controls.Add(this.bt_cancelar);
            this.panel1.Controls.Add(this.bt_gravar);
            this.panel1.Controls.Add(this.bt_Novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 23);
            this.panel1.TabIndex = 10;
            // 
            // bt_fechar
            // 
            this.bt_fechar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_fechar.Location = new System.Drawing.Point(435, 0);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(111, 23);
            this.bt_fechar.TabIndex = 16;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cancelar.Enabled = false;
            this.bt_cancelar.Location = new System.Drawing.Point(204, 0);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(109, 23);
            this.bt_cancelar.TabIndex = 15;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_gravar
            // 
            this.bt_gravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_gravar.Enabled = false;
            this.bt_gravar.Location = new System.Drawing.Point(103, 0);
            this.bt_gravar.Name = "bt_gravar";
            this.bt_gravar.Size = new System.Drawing.Size(95, 23);
            this.bt_gravar.TabIndex = 14;
            this.bt_gravar.Text = "Gravar";
            this.bt_gravar.UseVisualStyleBackColor = true;
            this.bt_gravar.Click += new System.EventHandler(this.bt_gravar_Click);
            // 
            // bt_Novo
            // 
            this.bt_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Novo.Location = new System.Drawing.Point(3, 0);
            this.bt_Novo.Name = "bt_Novo";
            this.bt_Novo.Size = new System.Drawing.Size(97, 23);
            this.bt_Novo.TabIndex = 13;
            this.bt_Novo.Text = "Novo";
            this.bt_Novo.UseVisualStyleBackColor = true;
            this.bt_Novo.Click += new System.EventHandler(this.bt_Novo_Click);
            // 
            // bt_pesquisarTurma
            // 
            this.bt_pesquisarTurma.Enabled = false;
            this.bt_pesquisarTurma.Location = new System.Drawing.Point(392, 78);
            this.bt_pesquisarTurma.Name = "bt_pesquisarTurma";
            this.bt_pesquisarTurma.Size = new System.Drawing.Size(28, 23);
            this.bt_pesquisarTurma.TabIndex = 11;
            this.bt_pesquisarTurma.Text = "...";
            this.bt_pesquisarTurma.UseVisualStyleBackColor = true;
            this.bt_pesquisarTurma.Click += new System.EventHandler(this.bt_pesquisarTurma_Click);
            // 
            // bt_pesqusarPlano
            // 
            this.bt_pesqusarPlano.Enabled = false;
            this.bt_pesqusarPlano.Location = new System.Drawing.Point(267, 137);
            this.bt_pesqusarPlano.Name = "bt_pesqusarPlano";
            this.bt_pesqusarPlano.Size = new System.Drawing.Size(31, 23);
            this.bt_pesqusarPlano.TabIndex = 12;
            this.bt_pesqusarPlano.Text = "...";
            this.bt_pesqusarPlano.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG(*.jpg*)|*.jpg|PNG(*.png*)|*.png";
            // 
            // pic_foto
            // 
            this.pic_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_foto.Enabled = false;
            this.pic_foto.Location = new System.Drawing.Point(451, 47);
            this.pic_foto.Name = "pic_foto";
            this.pic_foto.Size = new System.Drawing.Size(85, 113);
            this.pic_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_foto.TabIndex = 13;
            this.pic_foto.TabStop = false;
            // 
            // btnadcFoto
            // 
            this.btnadcFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadcFoto.Enabled = false;
            this.btnadcFoto.Location = new System.Drawing.Point(451, 18);
            this.btnadcFoto.Name = "btnadcFoto";
            this.btnadcFoto.Size = new System.Drawing.Size(85, 23);
            this.btnadcFoto.TabIndex = 17;
            this.btnadcFoto.Text = "Foto";
            this.btnadcFoto.UseVisualStyleBackColor = true;
            this.btnadcFoto.Click += new System.EventHandler(this.btnadcFoto_Click);
            // 
            // F_NovoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 207);
            this.Controls.Add(this.btnadcFoto);
            this.Controls.Add(this.pic_foto);
            this.Controls.Add(this.bt_pesqusarPlano);
            this.Controls.Add(this.bt_pesquisarTurma);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_plano);
            this.Controls.Add(this.tb_turma);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_NovoAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Aluno";
            this.Load += new System.EventHandler(this.F_NovoAluno_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.TextBox tb_plano;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_gravar;
        private System.Windows.Forms.Button bt_Novo;
        private System.Windows.Forms.Button bt_pesquisarTurma;
        private System.Windows.Forms.Button bt_pesqusarPlano;
        public System.Windows.Forms.TextBox tb_turma;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pic_foto;
        private System.Windows.Forms.Button btnadcFoto;
    }
}