using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p2Ofc
{
    public partial class Form1 : Form
    {


        #region VARIÁVEIS GLOBAIS

        int tipo = 0; 

        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        #region Botao Sair
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Saindo...",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
                 
        }
        #endregion


        #region Botao salvar
        private void Btn_Salvar_Click(object sender, EventArgs e)
        {


            if(TXT_NOME.Text.Length > 0 && TXT_DATA.Text.Length >0 && TXT_EQUI.Text.Length > 0 && TXT_MOTIVO.Text.Length > 0 && TXT_SITUA.Text.Length > 0 )
            {
                Dgv_Monitor.Enabled = true;
                DataRow novalinha = Dts_Monitor.Tables["Monitor"].NewRow();

                novalinha["Nome"] = TXT_NOME.Text.ToString();
                novalinha["Equipamento"] = TXT_EQUI.Text.ToString();
                novalinha["Data"] = TXT_DATA.Text.ToString();
                novalinha["Motivo"] = TXT_MOTIVO.Text.ToString();
                novalinha["Situação"] = TXT_SITUA.Text.ToString();

                Dts_Monitor.Tables[0].Rows.Add(novalinha);
                TXT_DATA.Clear();
                TXT_NOME.Clear();
                TXT_MOTIVO.Clear();
                TXT_SITUA.Clear();
                TXT_EQUI.Clear();
                TXT_NOME.Focus();

                Dgv_Monitor.Enabled = false;    
            }

            else 
            {
                MessageBox.Show("Todos os campos deve estar completos.", "Erro", MessageBoxButtons.OK);
            }
        }
        #endregion


        #region Lixo
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion



        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            switch(comboBox1.Text)
            {
                case "Nome do Monitor":
                    Bsc_Monitor.Filter = "Nome like '%" + TXT_FILTRO.Text + " %'";
                    break;

                case "Equipamento":
                    Bsc_Monitor.Filter = "Equipamento like '%" + TXT_FILTRO.Text + " %'";
                    break;

                case "Data da Manutenção":
                    Bsc_Monitor.Filter = "Data like '%" + TXT_FILTRO.Text + " %'";
                    break;

                case "Motivo":
                    Bsc_Monitor.Filter = "Motivo like '%" + TXT_FILTRO.Text + " %'";
                    break;

                case "Situação":
                    Bsc_Monitor.Filter = "Situação like '%" + TXT_FILTRO.Text + " %'";
                    break;

                default:
                    TXT_FILTRO.Clear();
                    MessageBox.Show("Escolha uma opção", "Erro");
                    break;
            }
        }

        private void porLinhasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivo de texto|*.txt";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(saveFileDialog1.FileName); 
                for (int i = 0;i < Dts_Monitor.Tables["Monitor"].Rows.Count; i++)
                {
                    SW.WriteLine(Dts_Monitor.Tables["Monitor"].Rows[i]["Nome"]);
                    SW.WriteLine(Dts_Monitor.Tables["Monitor"].Rows[i]["Equipamento"]);
                    SW.WriteLine(Dts_Monitor.Tables["Monitor"].Rows[i]["Data"]);
                    SW.WriteLine(Dts_Monitor.Tables["Monitor"].Rows[i]["Motivo"]);
                    SW.WriteLine(Dts_Monitor.Tables["Monitor"].Rows[i]["Situação"]);
                    SW.WriteLine(string.Empty);
                }
                SW.Dispose();
            }

        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o salvamento?", "Cancelando",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                TXT_DATA.Clear();
                TXT_EQUI.Clear();
                TXT_FILTRO.Clear();
                TXT_DATA.Clear();
                TXT_MOTIVO.Clear();
                TXT_SITUA.Clear();
                TXT_NOME.Clear();
                TXT_NOME.Focus();
                
                    
            }
                
        }
    }
}
