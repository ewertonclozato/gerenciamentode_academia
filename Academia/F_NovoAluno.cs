using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Academia
{
    public partial class F_NovoAluno : Form
    {
        Globais sequencia = new Globais();
        string origemCompleta = string.Empty;
        string foto = string.Empty;
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = string.Empty;

        public F_NovoAluno()
        {
            InitializeComponent();
            
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_NovoAluno_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A","Ativo");
            status.Add("B","Bloqueado");
            status.Add("C","Cancelado");

            cb_status.DataSource = new BindingSource(status, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";
            cb_status.SelectedIndex = -1;
            tb_nome.Clear();
            tb_turma.SelectionLength = 0;
        }

        private void bt_Novo_Click(object sender, EventArgs e)
        {
            tb_nome.Enabled = true;
            mtb_telefone.Enabled = true;
            cb_status.Enabled = true;
            tb_turma.Enabled = true;
            tb_plano.Enabled = true;
            bt_gravar.Enabled = true;
            bt_cancelar.Enabled = true;
            bt_Novo.Enabled = false;
            bt_pesquisarTurma.Enabled = true;
            bt_pesqusarPlano.Enabled = true;
            btnadcFoto.Enabled = true;
            pic_foto.Enabled = true;
            tb_nome.Clear();
            mtb_telefone.Clear();
            cb_status.SelectedIndex = -1;
            tb_nome.Focus();
            sequencia.sequencia("tb_alunos");
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            tb_nome.Enabled = false;
            mtb_telefone.Enabled = false;
            cb_status.Enabled = false;
            tb_turma.Enabled = false;
            tb_plano.Enabled = false;
            bt_gravar.Enabled = false;
            bt_cancelar.Enabled = false;
            bt_Novo.Enabled = true;
            btnadcFoto.Enabled = false;
            pic_foto.Enabled = false;
            cb_status.SelectedIndex = -1;
            bt_Novo.Focus();
        }

        private void bt_gravar_Click(object sender, EventArgs e)
        {
            if (destinoCompleto == string.Empty)
            {
                if(MessageBox.Show("Sem foto, deseja continuar?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                System.IO.File.Copy(origemCompleta, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    pic_foto.ImageLocation = destinoCompleto;
                }
                else
                {
                    if(MessageBox.Show("Erro ao localiza foto, deseja continuar?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            string queryNovoAluno = string.Format(@"
                INSERT INTO
                    tb_alunos (T_NOMEALUNO,T_TELEFONE,T_STATUS,N_IDTURMA,T_FOTO)
                VALUES
                    ('{0}','{1}','{2}','{3}','{4}')", tb_nome.Text, mtb_telefone.Text,cb_status.SelectedValue,tb_turma.Tag,destinoCompleto);

            Banco.dml(queryNovoAluno);
            sequencia.sequencia("tb_alunos");
            MessageBox.Show("Aluno inserido");

            tb_nome.Enabled = false;
            mtb_telefone.Enabled = false;
            cb_status.Enabled = false;
            tb_turma.Enabled = false;
            tb_plano.Enabled = false;
            bt_gravar.Enabled = false;
            bt_cancelar.Enabled = false;
            bt_Novo.Enabled = true;
            cb_status.SelectedIndex = -1;
            bt_Novo.Focus();
            mtb_telefone.Clear();
            tb_turma.Clear();
            tb_plano.Clear();
            bt_pesquisarTurma.Enabled = false;
            bt_pesqusarPlano.Enabled = false;
            btnadcFoto.Enabled = false;
            pic_foto.Enabled = false;
            pic_foto.ImageLocation = destinoCompleto;
        }

        private void bt_pesquisarTurma_Click(object sender, EventArgs e)
        {
            F_SelecionarTurma f_SelecionarTurma = new F_SelecionarTurma(this);
            f_SelecionarTurma.ShowDialog();
        }

        private void tb_turma_MouseMove(object sender, MouseEventArgs e)
        {
            tb_turma.Cursor = Cursors.No;
            ActiveControl = null;
        }

        private void tb_turma_MouseClick(object sender, MouseEventArgs e)
        {
            ActiveControl = null;
        }

        private void tb_turma_DoubleClick(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void tb_turma_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void btnadcFoto_Click(object sender, EventArgs e)
        {
            origemCompleta = string.Empty;
            foto = string.Empty;
            pastaDestino = Globais.caminhoFotos;
            destinoCompleto = string.Empty;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleta = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + foto;
            }
            if (File.Exists(destinoCompleto))
            {
                if(MessageBox.Show("Arquivo já existe, deseja substituir?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            pic_foto.ImageLocation = origemCompleta;
        }
    }
}
