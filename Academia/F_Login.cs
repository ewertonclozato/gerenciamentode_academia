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
    public partial class F_Login : Form
    {
        Principal principal;
        DataTable dataTable = new DataTable();

        private void fechar()
        {
            if (principal.Text == string.Empty)
            {
                this.Close();
                this.principal.Close();
            }
            else
            {
                this.Close();
            }
        }

        public F_Login(Principal user)
        {
            InitializeComponent();
            this.principal = user;
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == string.Empty)
            {
                MessageBox.Show("Digite o USERNAME");
                tb_username.Focus();
                return;
            }
            else if (tb_senha.Text == string.Empty)
            {
                MessageBox.Show("Digite a SENHA");
                tb_senha.Focus();
                return;
            }

            //criando o SQL com a consulta no cmd do banco de dados
            string sql = "SELECT * FROM tb_usuarios WHERE T_USERNAME='" + tb_username.Text + "' AND T_SENHAUSUARIO='" + tb_senha.Text + "'";
            dataTable = Banco.dql(sql);

            if (dataTable.Rows.Count == 1)
            {
                this.principal.lb_acessoNum.Text = dataTable.Rows[0].ItemArray[5].ToString();
                this.principal.lb_nomeUsuario.Text = dataTable.Rows[0].ItemArray[1].ToString();
                /* ou
                   this.principal.lb_nomeUsuario.Text = dataTable.Rows[0].Field<string>("T_NOMEUSUARIO");
                */
                this.principal.pb_status.Image = Properties.Resources.ATIVADO;
                Globais.nivel = int.Parse(dataTable.Rows[0].ItemArray[5].ToString());
                Globais.logado = true;
                this.principal.Text = dataTable.Rows[0].ItemArray[1].ToString() + " - " + Globais.versao.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username ou Senha incorreto");
                tb_username.Focus();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            fechar();
        }

        private void F_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            fechar();
        }
    }
}
