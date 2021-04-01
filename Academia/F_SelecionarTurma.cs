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
    public partial class F_SelecionarTurma : Form
    {

        bool ativo = false;
        F_NovoAluno f_NovoAluno = new F_NovoAluno();
        public F_SelecionarTurma(F_NovoAluno f)
        {
            f_NovoAluno = f;
            InitializeComponent();
        }

        private void F_SelecionarTurma_Load(object sender, EventArgs e)
        {
            string queryTurma = string.Format(@"
                SELECT
                    tbt.N_IDTURMA as 'ID',
                    tbt.T_DESCTURMA as 'Turma',
                    tbh.T_DESCHORARIO as 'Horário',
                    tbp.T_NOMEPROFESSOR as 'Professor',
                    (SELECT
                        count(N_IDALUNO)
                    FROM
                        tb_alunos as tba
                    WHERE
                        tba.N_IDTURMA = tbt.N_IDTURMA and T_STATUS = 'A') as 'Quantidade de Alunos',
                    tbt.N_MAXIMOALUNOS as 'Máx. Alunos'
                FROM
                    tb_turmas as tbt
                INNER JOIN
                    tb_professores as tbp on tbp.N_IDPROFESSOR = tbt.N_IDPROFESSOR
                INNER JOIN
                    tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO");
            dgv_turmas.DataSource = Banco.dql(queryTurma);
            dgv_turmas.ClearSelection();
        }

        private void dgv_turmas_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            ativo = true;
            dgv_turmas.Cursor = Cursors.Hand;
        }

        private void dgv_turmas_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            ativo = false;
            dgv_turmas.Cursor = Cursors.Default;
        }

        private void dgv_turmas_Click(object sender, EventArgs e)
        {
            //DataGridView dgv = (DataGridView)sender;
            //int maxAlunos = Convert.ToInt32(dgv.SelectedRows[0].Cells[5].Value);
            //int qtdAluno = Convert.ToInt32(dgv.SelectedRows[0].Cells[4].Value);

            if (ativo == true)
            {
                if (Convert.ToInt32(dgv_turmas.SelectedRows[0].Cells[4].Value) >= Convert.ToInt32(dgv_turmas.SelectedRows[0].Cells[5].Value))
                {
                    MessageBox.Show("Não há vagas nessa turma");
                }
                else
                {
                    f_NovoAluno.tb_turma.Text = dgv_turmas.SelectedRows[0].Cells[1].Value.ToString();
                    f_NovoAluno.tb_turma.Tag = dgv_turmas.SelectedRows[0].Cells[0].Value.ToString();
                    f_NovoAluno.tb_turma.SelectionLength = 0;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma turma");
            }
            
        }
    }
}
