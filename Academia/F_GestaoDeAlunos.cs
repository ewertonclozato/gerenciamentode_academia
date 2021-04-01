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
    public partial class F_GestaoDeAlunos : Form
    {
        string queryDGV = string.Empty;
        string turma = string.Empty;
        string idSelecionado = string.Empty;
        string turmaAtual = string.Empty;
        string turmaVagas = string.Empty;
        //int linha = 0;
        string origemCompleta = string.Empty;
        string foto = string.Empty;
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = string.Empty;
        bool alteracaoFoto = false;
        string imagmAntiga;

        public F_GestaoDeAlunos()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_GestaoDeAlunos_Load(object sender, EventArgs e)
        {
            queryDGV = @"
                SELECT
                    N_IDALUNO as 'ID',
                    T_NOMEALUNO as 'Nome Aluno',
                    T_TELEFONE as 'Telefone'
                FROM
                    tb_alunos";
            dgv_alunos.DataSource = Banco.dql(queryDGV);
            dgv_alunos.Columns[0].Width = 20;
            dgv_alunos.Columns[1].Width = 120;
            dgv_alunos.Columns[2].Width = 100;

            if (dgv_alunos.Rows.Count < 1)
            {
                
            }
            else
            {
                tb_nome.Text = dgv_alunos.SelectedRows[0].Cells[1].Value.ToString();
            }
            
            string queryTurmas = @"
                SELECT
                    N_IDTURMA,
                    ('Vagas: '||(
                                (N_MAXIMOALUNOS)-(
                                                    SELECT
                                                        count(tba.N_IDALUNO)
                                                    FROM
                                                        tb_alunos as tba
                                                    WHERE
                                                        tba.T_STATUS = 'A' and tba.N_IDTURMA = tbt.N_IDTURMA
                                                    )
                                )|| ' / Turma: '||T_DESCTURMA
                    )as 'Turma'
                    FROM
                        tb_turmas as tbt";
            cb_turmas.Items.Clear();
            cb_turmas.DataSource = Banco.dql(queryTurmas);
            cb_turmas.DisplayMember = "Turma";
            cb_turmas.ValueMember = "N_IDTURMA";

            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Ativo");
            status.Add("B", "Bloqueado");
            status.Add("C", "Cancelado");
            cb_status.DataSource = new BindingSource(status, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            turma = cb_turmas.Text;
            turmaAtual = cb_turmas.Text;

            if (dgv_alunos.Rows.Count < 1)
            {
                cb_status.SelectedIndex = -1;
                cb_turmas.SelectedIndex = -1;
            }
            else
            {
                idSelecionado = dgv_alunos.CurrentRow.Cells[0].Value.ToString();
                string vqueryCampos = @"
                    SELECT
                        T_NOMEALUNO,
                        T_TELEFONE,
                        T_STATUS,
                        N_IDTURMA
                    FROM
                        tb_alunos
                    WHERE
                        N_IDALUNO=" + idSelecionado;
                DataTable dt = Banco.dql(vqueryCampos);
                tb_nome.Text = dt.Rows[0].ItemArray[0].ToString();
                mtb_telefone.Text = dt.Rows[0].ItemArray[1].ToString();
                cb_status.SelectedValue = dt.Rows[0].ItemArray[2].ToString();
                cb_turmas.SelectedValue = dt.Rows[0].ItemArray[3].ToString();
                turmaAtual = cb_turmas.Text;
            }
        }

        private void dgv_alunos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_alunos.SelectedRows.Count > 0)
            {
                idSelecionado = dgv_alunos.SelectedRows[0].Cells[0].Value.ToString();
                string vqueryCampos = @"
                    SELECT
                        T_NOMEALUNO,
                        T_TELEFONE,
                        T_STATUS,
                        N_IDTURMA,
                        T_FOTO
                    FROM
                        tb_alunos
                    WHERE
                        N_IDALUNO=" + idSelecionado;
                DataTable dt = Banco.dql(vqueryCampos);
                tb_nome.Text = dt.Rows[0].ItemArray[0].ToString();
                mtb_telefone.Text = dt.Rows[0].ItemArray[1].ToString();
                cb_status.SelectedValue = dt.Rows[0].ItemArray[2].ToString();
                cb_turmas.SelectedValue = dt.Rows[0].ItemArray[3].ToString();
                pic_aluno.ImageLocation= dt.Rows[0].ItemArray[4].ToString();
                turmaAtual = cb_turmas.Text;
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            turma = cb_turmas.Text;
            if (turmaAtual != turma)
            {
                string[] t = turma.Split(' ');
                int vagas = Convert.ToInt32(t[1]);
                
                if (vagas <= 0)
                {
                    MessageBox.Show("Não há vagas nessa turma, selecione outra!");
                    cb_turmas.Focus();
                    return;
                }
                else
                {
                    //linha = dgv_alunos.SelectedRows[0].Index;
                    string queryAlteracao = string.Format(@"
                        UPDATE
                            tb_alunos
                        SET
                            T_NOMEALUNO = '{0}',
                            T_TELEFONE = '{1}',
                            T_STATUS = '{2}',
                            N_IDTURMA = {3}
                        WHERE
                            N_IDALUNO={4}", tb_nome.Text, mtb_telefone.Text, cb_status.SelectedValue, cb_turmas.SelectedValue, idSelecionado);
                    Banco.dml(queryAlteracao);
                    //dgv_alunos[1, linha].Value = tb_nome.Text;
                }
            }
            else
            {
                //linha = dgv_alunos.SelectedRows[0].Index;
                string queryAlteracao = string.Format(@"
                    UPDATE
                        tb_alunos
                    SET
                        T_NOMEALUNO = '{0}',
                        T_TELEFONE = '{1}',
                        T_STATUS = '{2}',
                        N_IDTURMA = {3}
                    WHERE
                        N_IDALUNO={4}", tb_nome.Text, mtb_telefone.Text, cb_status.SelectedValue, cb_turmas.SelectedValue, idSelecionado);
                Banco.dml(queryAlteracao);
                //dgv_alunos[1, linha].Value = tb_nome.Text;
            }

            if (alteracaoFoto == true)
            {
                string queryAlteracao = string.Format(@"
                    UPDATE
                        tb_alunos
                    SET
                        T_FOTO = '{0}'
                    WHERE
                        N_IDALUNO={1}", destinoCompleto,idSelecionado);
                Banco.dml(queryAlteracao);

                if (destinoCompleto == string.Empty)
                {
                    if (pic_aluno.ImageLocation == null)
                    {
                        if (MessageBox.Show("Sem foto, deseja continuar?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            return;
                        }
                    }
                }
                else if(destinoCompleto != string.Empty)
                {
                    System.IO.File.Copy(origemCompleta, destinoCompleto, true);
                    if (File.Exists(destinoCompleto))
                    {
                        pic_aluno.ImageLocation = destinoCompleto;
                    }
                    else
                    {
                        if (MessageBox.Show("Erro ao localiza foto, deseja continuar?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            return;
                        }
                    }
                }
            }
            if (pic_aluno.ImageLocation == imagmAntiga)
            {
                
            }
            else
            {
                if (File.Exists(imagmAntiga))
                {
                    File.Delete(imagmAntiga);
                }
            }
        }

        private void btn_excluirAluno_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confimar exclusão?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (File.Exists(pic_aluno.ImageLocation))
                {
                    File.Delete(pic_aluno.ImageLocation);
                }
                string queryExcluir = string.Format(@"
                    DELETE FROM
                        tb_alunos
                    WHERE
                        N_IDALUNO='{0}'",idSelecionado);
                Banco.dml(queryExcluir);
                dgv_alunos.Rows.Remove(dgv_alunos.CurrentRow);
            }
        }

        private void pic_aluno_Click(object sender, EventArgs e)
        {
            imagmAntiga = pic_aluno.ImageLocation;
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
            if (imagmAntiga != destinoCompleto)
            {
                alteracaoFoto = true;
            }

            if (File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("Arquivo já existe, deseja substituir?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if (origemCompleta != string.Empty)
            {
                pic_aluno.ImageLocation = origemCompleta;
            }
        }
    }
}
