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
    public partial class F_GestaoProfessores : Form
    {
        Globais sequencia = new Globais();

        public F_GestaoProfessores()
        {
            InitializeComponent();
        }

        private void btn_novoProfessor_Click(object sender, EventArgs e)
        {
            if (tb_idProfessor.Text == string.Empty)
            {

            }
            else
            {
                tb_idProfessor.Clear();
                tb_nomeProfessor.Clear();
                mtb_telefoneProfessores.Clear();
                tb_nomeProfessor.Focus();
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_professores_SelectionChanged(object sender, EventArgs e)
        {
            int contLinas = dgv_professores.SelectedRows.Count;
            if (contLinas > 0)
            {
                DataTable dataTable = new DataTable();
                string vid = dgv_professores.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                    SELECT * FROM 
                        tb_professores
                    WHERE
                        N_IDPROFESSOR =" + vid;

                dataTable = Banco.dql(vquery);
                tb_idProfessor.Text = dataTable.Rows[0].ItemArray[0].ToString();
                tb_nomeProfessor.Text = dataTable.Rows[0].ItemArray[1].ToString();
                mtb_telefoneProfessores.Text = dataTable.Rows[0].ItemArray[2].ToString();
            }
        }

        private void F_GestaoProfessores_Load(object sender, EventArgs e)
        {
            string vquery = @"
                SELECT
                    N_IDPROFESSOR as 'ID', T_NOMEPROFESSOR as 'Nome', T_TELEFONE as 'Telefone'
                FROM
                    tb_professores
                ORDER BY
                    T_NOMEPROFESSOR";
            dgv_professores.DataSource = Banco.dql(vquery);
            dgv_professores.Columns[0].Width = 50;
            dgv_professores.Columns[1].Width = 200;
            dgv_professores.Columns[2].Width = 150;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int linha = 0;
            if (dgv_professores.RowCount > 0)
            {
                linha = dgv_professores.SelectedRows[0].Index;
            }
            else if(tb_nomeProfessor.Text == string.Empty || mtb_telefoneProfessores.Text == string.Empty)
            {
                return;
            }
            string vquery = string.Empty;

            if (tb_idProfessor.Text == string.Empty)
            {
                vquery = @"
                INSERT INTO 
                    tb_professores (T_NOMEPROFESSOR,T_TELEFONE)
                VALUES
                    ('" + tb_nomeProfessor.Text + "','" + mtb_telefoneProfessores.Text + "')";
            }
            else
            {
                vquery = @"
                UPDATE
                    tb_professores
                SET 
                    T_NOMEPROFESSOR='" + tb_nomeProfessor.Text + @"',
                    T_TELEFONE='" + mtb_telefoneProfessores.Text + @"'
                WHERE
                    N_IDPROFESSOR=" + tb_idProfessor.Text;
            }
            sequencia.sequencia("tb_professores");
            Banco.dml(vquery);
            vquery = @"
                SELECT
                    N_IDPROFESSOR as 'ID', T_NOMEPROFESSOR as 'Nome', T_TELEFONE as 'Telefone'
                FROM
                    tb_professores
                ORDER BY
                    T_NOMEPROFESSOR";
            dgv_professores.DataSource = Banco.dql(vquery);
            dgv_professores.Columns[0].Width = 50;
            dgv_professores.Columns[1].Width = 210;
            dgv_professores.Columns[2].Width = 150;

            dgv_professores.CurrentCell = dgv_professores[0, linha];
            dgv_professores[1, linha].Value = tb_nomeProfessor.Text;
            dgv_professores[2, linha].Value = mtb_telefoneProfessores.Text;
        }

        private void btn_exlcuir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma Exclusão?", "", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_professores WHERE N_IDPROFESSOR=" + tb_idProfessor.Text;
                Banco.dml(vquery);
                dgv_professores.Rows.Remove(dgv_professores.CurrentRow);
            }
            sequencia.sequencia("tb_professores");
        }
    }
}
