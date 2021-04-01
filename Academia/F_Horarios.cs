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
    public partial class F_Horarios : Form
    {
        Globais sequencia = new Globais();
        public F_Horarios()
        {
            InitializeComponent();
        }

        private void F_Horarios_Load(object sender, EventArgs e)
        {
            string vquery = @"
                    SELECT
                        N_IDHORARIO as 'ID', T_DESCHORARIO as 'Horário'
                    FROM
                        tb_horarios
                    ORDER BY
                        T_DESCHORARIO";

            dgv_horarios.DataSource = Banco.dql(vquery);
            dgv_horarios.Columns[0].Width = 60;
            dgv_horarios.Columns[1].Width = 170;
        }

        private void dgv_horarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int countLinhas = dgv.SelectedRows.Count;
            if (countLinhas > 0)
            {
                DataTable dataTable = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                    SELECT * FROM 
                        tb_horarios
                    WHERE
                        N_IDHORARIO =" + vid;
                dataTable = Banco.dql(vquery);
                tb_idHorario.Text = dataTable.Rows[0].ItemArray[0].ToString();
                mtb_descHorario.Text = dataTable.Rows[0].ItemArray[1].ToString();
            }
        }

        private void btn_novoUsuario_Click(object sender, EventArgs e)
        {
            tb_idHorario.Clear();
            mtb_descHorario.Clear();
            mtb_descHorario.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            sequencia.sequencia("tb_horarios");
            int linha = dgv_horarios.SelectedRows[0].Index;

            string vquery = string.Empty;
            if (tb_idHorario.Text == string.Empty)
            {
                vquery = @"
                INSERT INTO
                    tb_horarios (T_DESCHORARIO)
                VALUES
                    ('" + mtb_descHorario.Text + "')";
            }
            else
            {
                vquery = @"
                UPDATE
                    tb_horarios 
                SET 
                    T_DESCHORARIO='" + mtb_descHorario.Text + @"'
                    WHERE N_IDHORARIO=" + tb_idHorario.Text;
            }
            
            Banco.dml(vquery);
            vquery = @"
                    SELECT
                        N_IDHORARIO as 'ID', T_DESCHORARIO as 'Horário'
                    FROM
                        tb_horarios
                    ORDER BY
                        T_DESCHORARIO";

            dgv_horarios.DataSource = Banco.dql(vquery);
            dgv_horarios.Columns[0].Width = 60;
            dgv_horarios.Columns[1].Width = 170;

            dgv_horarios.CurrentCell = dgv_horarios[0, linha];
            dgv_horarios[1, linha].Value = mtb_descHorario.Text;
        }

        private void btn_exlcuir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma Exclusão?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_horarios WHERE N_IDHORARIO=" + tb_idHorario.Text;
                Banco.dml(vquery);
                dgv_horarios.Rows.Remove(dgv_horarios.CurrentRow);
            }
            sequencia.sequencia("tb_horarios");
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
