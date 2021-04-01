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
    public partial class F_NovoUsuario : Form
    {
        public F_NovoUsuario()
        {
            InitializeComponent();
        }
        public void limpar()
        {
            tb_nome.Clear();
            tb_username.Clear();
            tb_senha.Clear();
            rb_1.Checked = false;
            rb_2.Checked = false;
            rb_3.Checked = false;
            rb_a.Checked = false;
            rb_b.Checked = false;
            rb_d.Checked = false;
            tb_nome.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.nome = tb_nome.Text;
            usuario.username = tb_username.Text;
            usuario.senha = tb_senha.Text;

            if (tb_nome.Text == string.Empty)
            {
                MessageBox.Show("Digite o nome");
                tb_nome.Focus();
                return;
            }
            else if (tb_username.Text == string.Empty)
            {
                MessageBox.Show("Digite o Username");
                tb_username.Focus();
                return;
            }
            else if (tb_senha.Text == string.Empty)
            {
                MessageBox.Show("Digite a senha");
                tb_senha.Focus();
                return;
            }

            bool checkStatus = false;
            foreach (RadioButton rb in painel_status.Controls)
            {
                if (rb.Checked)
                {
                    checkStatus = true;
                    usuario.status = rb.Text;
                }
            }
            if(checkStatus == false)
            {
                MessageBox.Show("Selecione um STATUS para o novo usuário");
                return;
            }

            bool checkNivel = false;
            foreach (RadioButton rb in painel_nivel.Controls)
            {
                if (rb.Checked)
                {
                    checkNivel = true;
                    usuario.nivel = int.Parse(rb.Text);
                }
            }
            if (checkNivel == false)
            {
                MessageBox.Show("Selecione um NÍVEL para o novo usuário");
                return;
            }
            Banco.novoUsuario(usuario);
            limpar();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
