using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Academia
{
    public partial class F_GestaoTurmas : Form
    {
        Globais sequencia = new Globais();
        string idSelecionado;
        string vqueryDGV = string.Empty;

        public F_GestaoTurmas()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            string nomeArquivo = Globais.caminho + @"\turmas.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminho + @"\SPFC.png");
            logo.ScaleToFit(140f, 120f);
            logo.Alignment = Element.ALIGN_LEFT;
            //logo.SetAbsolutePosition(100f, 700f);
            
            string dados = string.Empty;
            Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));

            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add("Relatório de Turmas\n\n");

            paragrafo2.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Italic);
            paragrafo2.Alignment = Element.ALIGN_CENTER;
            paragrafo2.Add("Curso C#\n\n\n");

            /*
            string texto = "youtube.com/";
            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 8, (int)System.Drawing.FontStyle.Regular);
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add(string.Format("{0}\n\n\n", texto));
            */

            PdfPTable tabela = new PdfPTable(3);//tabela com 3 colunas
            tabela.DefaultCell.FixedHeight = 20;

            /*
            PdfPCell celula1 = new PdfPCell();
            celula1.Colspan = 3;//Linha 1 mesclada
            //celula.Rotation = 90;
            celula1.AddElement(logo);
            tabela.AddCell(celula1);
            */

            tabela.AddCell("ID Turma");
            tabela.AddCell("Turma");
            tabela.AddCell("Horário");

            /*
            PdfPCell celula2 = new PdfPCell(new Phrase("Tabela de Preços"));
            celula2.Colspan = 3;//Linha 1 mesclada
            celula2.FixedHeight = 40;
            celula2.HorizontalAlignment = Element.ALIGN_CENTER;
            celula2.VerticalAlignment = Element.ALIGN_MIDDLE;
            celula2.Rotation = 0;
            tabela.AddCell(celula2);
            */

            DataTable dtTurmas = Banco.dql(vqueryDGV);
            for(int i = 0; i < dtTurmas.Rows.Count; i++)
            {
                tabela.AddCell(dtTurmas.Rows[i].ItemArray[0].ToString());
                tabela.AddCell(dtTurmas.Rows[i].ItemArray[1].ToString());
                tabela.AddCell(dtTurmas.Rows[i].ItemArray[2].ToString());
            }

            doc.Open();
            doc.Add(logo);
            doc.Add(paragrafo);
            doc.Add(tabela);
            doc.Add(paragrafo2);
            doc.Close();

            DialogResult res = MessageBox.Show("Deseja abrir o relatório?", string.Empty, MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Globais.caminho + @"\turmas.pdf");
            }
        }

        private void btn_excluirTurma_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma Exclusão?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_turmas WHERE N_IDTURMA=" + lb_idTurma.Text;
                Banco.dml(vquery);
                dgv_turmas.Rows.Remove(dgv_turmas.CurrentRow);
            }
            sequencia.sequencia("tb_turmas");
        }

        private void btn_salvasAlteracoes_Click(object sender, EventArgs e)
        {
            int linha = 0;
            if (dgv_turmas.Rows.Count > 0)
            {
                if (dgv_turmas.CurrentCell.Selected)
                {
                    linha = dgv_turmas.SelectedRows[0].Index;
                }
                else
                {
                    
                }
            }
            else if (tb_turma.Text == string.Empty && dgv_turmas.Rows.Count <= 0)
            {
                return;
            }
            string vquery = string.Empty;
            bool novo;

            if (lb_idTurma.Text == string.Empty)
            {
                vquery = string.Format(@"
                    INSERT INTO
                        tb_turmas (T_DESCTURMA,N_IDPROFESSOR,N_IDHORARIO,N_MAXIMOALUNOS,T_STATUS)
                    VALUES
                        ('{0}','{1}','{2}','{3}','{4}')",tb_turma.Text,cb_professor.SelectedValue,cb_horarios.SelectedValue,Convert.ToInt32(nud_maximoalunos.Value),cb_status.SelectedValue);
                novo = true;
            }
            else
            {
                vquery = string.Format(@"
                    UPDATE
                        tb_turmas
                    SET
                        T_DESCTURMA='{0}',
                        N_IDPROFESSOR='{1}',
                        N_IDHORARIO='{2}',
                        N_MAXIMOALUNOS='{3}',
                        T_STATUS='{4}'
                    WHERE
                        N_IDTURMA={5}", tb_turma.Text,cb_professor.SelectedValue,cb_horarios.SelectedValue,nud_maximoalunos.Value,cb_status.SelectedValue,lb_idTurma.Text);
                novo = false;
            }
            sequencia.sequencia("tb_turmas");
            Banco.dml(vquery);
            vquery= @"
                SELECT
                    tbt.N_IDTURMA as 'ID Turma',
                    tbt.T_DESCTURMA as 'Turma',
                    tbh.T_DESCHORARIO as 'Horário'
                FROM
                    tb_turmas as tbt
                INNER JOIN
                    tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO";
            dgv_turmas.DataSource = Banco.dql(vquery);
            dgv_turmas.Columns[0].Width = 90;
            dgv_turmas.Columns[1].Width = 200;
            dgv_turmas.Columns[2].Width = 85;
            
            if (novo == true)
            {
                dgv_turmas.CurrentCell = dgv_turmas.Rows[dgv_turmas.Rows.Count - 1].Cells[0];
                MessageBox.Show("Nova aula criada com sucesso!");
            }
            else
            {
                dgv_turmas.CurrentCell = dgv_turmas[0, linha];
                dgv_turmas[1, linha].Value = tb_turma.Text;
                dgv_turmas[2, linha].Value = cb_horarios.Text;
                MessageBox.Show("Aula alterada com sucesso!");
            }
        }

        private void btn_novaTurma_Click(object sender, EventArgs e)
        {
            if (lb_idTurma.Text == string.Empty)
            {
                lb_idTurma.Text = string.Empty;
                tb_turma.Clear();
                tb_turma.Focus();
                cb_professor.SelectedIndex = -1;
                cb_horarios.SelectedIndex = -1;
                cb_status.SelectedIndex = -1;
            }
            else
            {
                lb_idTurma.Text = string.Empty;
                tb_turma.Clear();
                tb_turma.Focus();
                nud_maximoalunos.Value = 0;
                cb_professor.SelectedIndex = -1;
                cb_horarios.SelectedIndex = -1;
                cb_status.SelectedIndex = -1;
            }
        }


        private void F_GestaoTurmas_Load(object sender, EventArgs e)
        {
            vqueryDGV = @"
                SELECT
                    tbt.N_IDTURMA as 'ID Turma',
                    tbt.T_DESCTURMA as 'Turma',
                    tbh.T_DESCHORARIO as 'Horário'
                FROM
                    tb_turmas as tbt
                INNER JOIN
                    tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO";

            dgv_turmas.DataSource = Banco.dql(vqueryDGV);
            dgv_turmas.Columns[0].Width = 90;
            dgv_turmas.Columns[1].Width = 200;
            dgv_turmas.Columns[2].Width = 85;

            string vqueryProfessores = @"
                SELECT
                    N_IDPROFESSOR,
                    T_NOMEPROFESSOR
                FROM
                    tb_professores
                Order By
                    N_IDPROFESSOR";
            cb_professor.DataSource = Banco.dql(vqueryProfessores);
            cb_professor.DisplayMember = "T_NOMEPROFESSOR";
            cb_professor.ValueMember = "N_IDPROFESSOR";

            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A", "Ativa");
            st.Add("P", "Paralisada");
            st.Add("C", "Cancelada");
            cb_status.DataSource = new BindingSource(st, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            string vqueryHoararios = @"
                SELECT
                    *
                FROM
                    tb_horarios
                Order By
                    T_DESCHORARIO";
            cb_horarios.DataSource = Banco.dql(vqueryHoararios);
            cb_horarios.DisplayMember = "T_DESCHORARIO";
            cb_horarios.ValueMember = "N_IDHORARIO";

            DataGridView dgv = dgv_turmas;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                idSelecionado = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vqueryCampos = @"
                    SELECT
                        *
                    FROM
                        tb_turmas
                    WHERE
                        N_IDTURMA=" + idSelecionado;
                DataTable dt = Banco.dql(vqueryCampos);
                tb_turma.Text = dt.Rows[0].ItemArray[1].ToString();
                cb_professor.SelectedValue = dt.Rows[0].ItemArray[2];
                nud_maximoalunos.Value = Convert.ToInt32(dt.Rows[0].ItemArray[4]);
                cb_status.SelectedValue = dt.Rows[0].ItemArray[5].ToString();
                cb_horarios.SelectedValue = dt.Rows[0].ItemArray[3].ToString();
                lb_idTurma.Text = dt.Rows[0].ItemArray[0].ToString();
            }

        }
        
        private void dgv_turmas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                idSelecionado = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vqueryCampos = @"
                    SELECT
                        *
                    FROM
                        tb_turmas
                    WHERE
                        N_IDTURMA=" + idSelecionado;
                DataTable dt = Banco.dql(vqueryCampos);
                tb_turma.Text = dt.Rows[0].ItemArray[1].ToString();
                cb_professor.SelectedValue = dt.Rows[0].ItemArray[2];
                nud_maximoalunos.Value = Convert.ToInt32(dt.Rows[0].ItemArray[4]);
                cb_status.SelectedValue = dt.Rows[0].ItemArray[5].ToString();
                cb_horarios.SelectedValue = dt.Rows[0].ItemArray[3].ToString();
                lb_idTurma.Text = dt.Rows[0].ItemArray[0].ToString();

                //calculo de vagas
                string queryVagas = string.Format(@"
                    SELECT
                        count(N_IDALUNO)
                    FROM
                        tb_alunos
                    WHERE
                        T_STATUS='A' and N_IDTURMA={0}",idSelecionado);
                dt = Banco.dql(queryVagas);
                int vagas = Convert.ToInt32(nud_maximoalunos.Value);
                vagas -= Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
                tb_vagas.Text = vagas.ToString();
            }
        }
    }
}
