namespace p2Ofc
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_NOME = new System.Windows.Forms.TextBox();
            this.TXT_EQUI = new System.Windows.Forms.TextBox();
            this.TXT_DATA = new System.Windows.Forms.TextBox();
            this.TXT_MOTIVO = new System.Windows.Forms.TextBox();
            this.TXT_SITUA = new System.Windows.Forms.TextBox();
            this.Dgv_Monitor = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TXT_FILTRO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Dts_Monitor = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.Dtc_Nome = new System.Data.DataColumn();
            this.Dtc_Eq = new System.Data.DataColumn();
            this.Dtc_Data = new System.Data.DataColumn();
            this.Dtc_Motivo = new System.Data.DataColumn();
            this.Dtc_Situ = new System.Data.DataColumn();
            this.Bsc_Monitor = new System.Windows.Forms.BindingSource(this.components);
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porLinhasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porColunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_CANCELAR = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Monitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dts_Monitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bsc_Monitor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BTN_CANCELAR);
            this.panel1.Controls.Add(this.Btn_Salvar);
            this.panel1.Controls.Add(this.TXT_SITUA);
            this.panel1.Controls.Add(this.TXT_MOTIVO);
            this.panel1.Controls.Add(this.TXT_DATA);
            this.panel1.Controls.Add(this.TXT_EQUI);
            this.panel1.Controls.Add(this.TXT_NOME);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 98);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.TXT_FILTRO);
            this.panel2.Location = new System.Drawing.Point(12, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 71);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Monitor(a)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Equipamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data da Manutenção";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(522, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Motivo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(690, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Situação";
            // 
            // TXT_NOME
            // 
            this.TXT_NOME.Location = new System.Drawing.Point(20, 30);
            this.TXT_NOME.Name = "TXT_NOME";
            this.TXT_NOME.Size = new System.Drawing.Size(123, 20);
            this.TXT_NOME.TabIndex = 1;
            this.TXT_NOME.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TXT_EQUI
            // 
            this.TXT_EQUI.Location = new System.Drawing.Point(190, 30);
            this.TXT_EQUI.Name = "TXT_EQUI";
            this.TXT_EQUI.Size = new System.Drawing.Size(123, 20);
            this.TXT_EQUI.TabIndex = 2;
            // 
            // TXT_DATA
            // 
            this.TXT_DATA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT_DATA.Location = new System.Drawing.Point(348, 30);
            this.TXT_DATA.Name = "TXT_DATA";
            this.TXT_DATA.Size = new System.Drawing.Size(123, 20);
            this.TXT_DATA.TabIndex = 3;
            // 
            // TXT_MOTIVO
            // 
            this.TXT_MOTIVO.Location = new System.Drawing.Point(525, 30);
            this.TXT_MOTIVO.Name = "TXT_MOTIVO";
            this.TXT_MOTIVO.Size = new System.Drawing.Size(123, 20);
            this.TXT_MOTIVO.TabIndex = 4;
            // 
            // TXT_SITUA
            // 
            this.TXT_SITUA.Location = new System.Drawing.Point(693, 30);
            this.TXT_SITUA.Name = "TXT_SITUA";
            this.TXT_SITUA.Size = new System.Drawing.Size(123, 20);
            this.TXT_SITUA.TabIndex = 5;
            // 
            // Dgv_Monitor
            // 
            this.Dgv_Monitor.AllowUserToAddRows = false;
            this.Dgv_Monitor.AutoGenerateColumns = false;
            this.Dgv_Monitor.ColumnHeadersHeight = 30;
            this.Dgv_Monitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Equipamento,
            this.Data,
            this.Motivo,
            this.Situação});
            this.Dgv_Monitor.DataSource = this.Bsc_Monitor;
            this.Dgv_Monitor.Location = new System.Drawing.Point(12, 211);
            this.Dgv_Monitor.Name = "Dgv_Monitor";
            this.Dgv_Monitor.Size = new System.Drawing.Size(834, 130);
            this.Dgv_Monitor.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Buscar por :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nome do Monitor",
            "Equipamento",
            "Data da Manutenção",
            "Motivo",
            "Situação"});
            this.comboBox1.Location = new System.Drawing.Point(101, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // TXT_FILTRO
            // 
            this.TXT_FILTRO.Location = new System.Drawing.Point(525, 25);
            this.TXT_FILTRO.Name = "TXT_FILTRO";
            this.TXT_FILTRO.Size = new System.Drawing.Size(168, 20);
            this.TXT_FILTRO.TabIndex = 1;
            this.TXT_FILTRO.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(416, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Informe o dado :";
            // 
            // Dts_Monitor
            // 
            this.Dts_Monitor.DataSetName = "NewDataSet";
            this.Dts_Monitor.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.Dtc_Nome,
            this.Dtc_Eq,
            this.Dtc_Data,
            this.Dtc_Motivo,
            this.Dtc_Situ});
            this.dataTable1.TableName = "Monitor";
            // 
            // Dtc_Nome
            // 
            this.Dtc_Nome.ColumnName = "Nome";
            // 
            // Dtc_Eq
            // 
            this.Dtc_Eq.ColumnName = "Equipamento";
            // 
            // Dtc_Data
            // 
            this.Dtc_Data.ColumnName = "Data";
            // 
            // Dtc_Motivo
            // 
            this.Dtc_Motivo.ColumnName = "Motivo";
            // 
            // Dtc_Situ
            // 
            this.Dtc_Situ.ColumnName = "Situação";
            // 
            // Bsc_Monitor
            // 
            this.Bsc_Monitor.DataMember = "Monitor";
            this.Bsc_Monitor.DataSource = this.Dts_Monitor;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Equipamento
            // 
            this.Equipamento.DataPropertyName = "Equipamento";
            this.Equipamento.HeaderText = "Equipamento";
            this.Equipamento.Name = "Equipamento";
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Motivo
            // 
            this.Motivo.DataPropertyName = "Motivo";
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            // 
            // Situação
            // 
            this.Situação.DataPropertyName = "Situação";
            this.Situação.HeaderText = "Situação";
            this.Situação.Name = "Situação";
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Salvar.Location = new System.Drawing.Point(693, 56);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(121, 29);
            this.Btn_Salvar.TabIndex = 6;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porLinhasToolStripMenuItem,
            this.porColunasToolStripMenuItem});
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // porLinhasToolStripMenuItem
            // 
            this.porLinhasToolStripMenuItem.Name = "porLinhasToolStripMenuItem";
            this.porLinhasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porLinhasToolStripMenuItem.Text = "Por Linhas";
            this.porLinhasToolStripMenuItem.Click += new System.EventHandler(this.porLinhasToolStripMenuItem_Click);
            // 
            // porColunasToolStripMenuItem
            // 
            this.porColunasToolStripMenuItem.Name = "porColunasToolStripMenuItem";
            this.porColunasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porColunasToolStripMenuItem.Text = "Por colunas";
            // 
            // BTN_CANCELAR
            // 
            this.BTN_CANCELAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_CANCELAR.Location = new System.Drawing.Point(566, 56);
            this.BTN_CANCELAR.Name = "BTN_CANCELAR";
            this.BTN_CANCELAR.Size = new System.Drawing.Size(121, 29);
            this.BTN_CANCELAR.TabIndex = 7;
            this.BTN_CANCELAR.Text = "Cancelar";
            this.BTN_CANCELAR.UseVisualStyleBackColor = true;
            this.BTN_CANCELAR.Click += new System.EventHandler(this.BTN_CANCELAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 353);
            this.Controls.Add(this.Dgv_Monitor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Monitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dts_Monitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bsc_Monitor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TXT_SITUA;
        private System.Windows.Forms.TextBox TXT_MOTIVO;
        private System.Windows.Forms.TextBox TXT_DATA;
        private System.Windows.Forms.TextBox TXT_EQUI;
        private System.Windows.Forms.TextBox TXT_NOME;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_FILTRO;
        private System.Windows.Forms.DataGridView Dgv_Monitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situação;
        private System.Windows.Forms.BindingSource Bsc_Monitor;
        private System.Data.DataSet Dts_Monitor;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn Dtc_Nome;
        private System.Data.DataColumn Dtc_Eq;
        private System.Data.DataColumn Dtc_Data;
        private System.Data.DataColumn Dtc_Motivo;
        private System.Data.DataColumn Dtc_Situ;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porLinhasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porColunasToolStripMenuItem;
        private System.Windows.Forms.Button BTN_CANCELAR;
    }
}

