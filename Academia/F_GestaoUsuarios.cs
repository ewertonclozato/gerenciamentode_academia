using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class F_GestaoUsuarios : Form
    {
        Globais sequenciaID = new Globais();
        public F_GestaoUsuarios()
        {
            InitializeComponent();
        }
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_GestaoUsuarios_Load(object sender, EventArgs e)
        {
            dgv_usuarios.DataSource = Banco.obterDadosUsuarios();
            dgv_usuarios.Columns[0].Width = 85;
            dgv_usuarios.Columns[1].Width = 190;
        }

        private void dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dataTable = new DataTable();
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dataTable = Banco.obterDadosUsuario(id);

                tb_id.Text = dataTable.Rows[0].ItemArray[0].ToString();
                //tb_id.Text = dataTable.Rows[0].Field<Int64>("N_IDUSUARIO").ToString();

                tb_nome.Text = dataTable.Rows[0].ItemArray[1].ToString();
                //tb_nome.Text = dataTable.Rows[0].Field<string>("T_NOMEUSUARIO").ToString();

                tb_username.Text = dataTable.Rows[0].Field<string>("T_USERNAME").ToString();
                tb_senha.Text = dataTable.Rows[0].Field<string>("T_SENHAUSUARIO").ToString();

                string checkStatus = dataTable.Rows[0].Field<string>("T_STATUSUSUARIO").ToString();
                switch (checkStatus)
                {
                    case "A":
                        rb_a.Checked = true;
                        break;
                    case "B":
                        rb_b.Checked = true;
                        break;
                    case "D":
                        rb_d.Checked = true;
                        break;
                }

                string checkNivel = dataTable.Rows[0].Field<Int64>("N_NIVELUSUARIO").ToString();
                switch (checkNivel)
                {
                    case "1":
                        rb_1.Checked = true;
                        break;
                    case "2":
                        rb_2.Checked = true;
                        break;
                    case "3":
                        rb_3.Checked = true;
                        break;
                }
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            f_NovoUsuario.ShowDialog();
            Refresh();
            dgv_usuarios.DataSource = Banco.obterDadosUsuarios();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            sequenciaID.sequencia("tb_usuarios");
            int linha = dgv_usuarios.SelectedRows[0].Index;

            Usuario u = new Usuario();
            u.id = int.Parse(tb_id.Text);
            u.nome = tb_nome.Text;
            u.username = tb_username.Text;
            u.senha = tb_senha.Text;
            foreach (RadioButton rb in painel_status.Controls)
            {
                if (rb.Checked)
                {
                    u.status = rb.Text;
                }
            }
            foreach (RadioButton rb in painel_nivel.Controls)
            {
                if (rb.Checked)
                {
                    u.nivel = int.Parse(rb.Text);
                }
            }

            Banco.ataluzarUsuarios(u);
            dgv_usuarios[1, linha].Value = tb_nome.Text;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma Exclusão?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int linha = dgv_usuarios.SelectedRows[0].Index;
                Banco.deletarUsuario(tb_id.Text);
                dgv_usuarios.Rows.RemoveAt(linha);
            }
            sequenciaID.sequencia("tb_usuarios");
        }
    }
}
