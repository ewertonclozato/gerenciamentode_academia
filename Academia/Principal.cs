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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void abreForm(int nivel, Form f)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= nivel)
                {
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("Não há usuário logado");
            }
        }

        private void lOGONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void lOGOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acessoNum.Text = "0";
            lb_nomeUsuario.Text = "---";
            /* ou
               this.principal.lb_nomeUsuario.Text = dataTable.Rows[0].Field<string>("T_NOMEUSUARIO");
            */
            pb_status.Image = Properties.Resources.DESATIVADO;
            Globais.nivel = 0;
            Globais.logado = false;
            Text = Globais.versao.ToString();
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int nivel = Globais.nivel;
            abreForm(3, null);
        }

        private void gestãoDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoUsuarios f_GestaoUsuarios = new F_GestaoUsuarios();
            abreForm(2, f_GestaoUsuarios);
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            abreForm(1, f_NovoUsuario);
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoAluno f_NovoAluno = new F_NovoAluno();
            abreForm(2, f_NovoAluno);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Horarios f_Horarios = new F_Horarios();
            abreForm(2, f_Horarios);
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoProfessores f_GestaoProfessores = new F_GestaoProfessores();
            abreForm(2, f_GestaoProfessores);
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoTurmas f_GestaoTurmas = new F_GestaoTurmas();
            abreForm(2, f_GestaoTurmas);
        }

        private void gestãoDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoDeAlunos f_GestaoDeAlunos = new F_GestaoDeAlunos();
            abreForm(1, f_GestaoDeAlunos);
        }
    }
}
