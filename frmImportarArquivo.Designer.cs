namespace VendaEstorno
{
    partial class frmImportarArquivo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblImportarArquivo = new Label();
            btnVoltarArquivo = new Button();
            btnCancelarArquivo = new Button();
            dgImportar = new DataGridView();
            btnLocalizarArquivo = new Button();
            txtImportarArquivo = new TextBox();
            btnImportarArquivo = new Button();
            progressBarImportacao = new ProgressBar();
            lblProgressoImportacao = new Label();
            lblResumoImportacao = new Label();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)dgImportar).BeginInit();
            SuspendLayout();
            // 
            // lblImportarArquivo
            // 
            lblImportarArquivo.AutoSize = true;
            lblImportarArquivo.Font = new Font("Segoe UI", 13.8F);
            lblImportarArquivo.Location = new Point(85, 51);
            lblImportarArquivo.Name = "lblImportarArquivo";
            lblImportarArquivo.Size = new Size(344, 31);
            lblImportarArquivo.TabIndex = 28;
            lblImportarArquivo.Text = "Localize o arquivo para importar";
            // 
            // btnVoltarArquivo
            // 
            btnVoltarArquivo.Font = new Font("Segoe UI", 13.8F);
            btnVoltarArquivo.Location = new Point(1391, 766);
            btnVoltarArquivo.Name = "btnVoltarArquivo";
            btnVoltarArquivo.Size = new Size(167, 37);
            btnVoltarArquivo.TabIndex = 27;
            btnVoltarArquivo.Text = "Voltar";
            btnVoltarArquivo.UseVisualStyleBackColor = true;
            btnVoltarArquivo.Click += btnVoltarArquivo_Click;
            // 
            // btnCancelarArquivo
            // 
            btnCancelarArquivo.Font = new Font("Segoe UI", 13.8F);
            btnCancelarArquivo.Location = new Point(387, 766);
            btnCancelarArquivo.Name = "btnCancelarArquivo";
            btnCancelarArquivo.Size = new Size(167, 37);
            btnCancelarArquivo.TabIndex = 26;
            btnCancelarArquivo.Text = "Cancelar";
            btnCancelarArquivo.UseVisualStyleBackColor = true;
            btnCancelarArquivo.Click += btnCancelarArquivo_Click;
            // 
            // dgImportar
            // 
            dgImportar.AllowUserToAddRows = false;
            dgImportar.AllowUserToDeleteRows = false;
            dgImportar.AllowUserToResizeColumns = false;
            dgImportar.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgImportar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgImportar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgImportar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgImportar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgImportar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgImportar.DefaultCellStyle = dataGridViewCellStyle3;
            dgImportar.Location = new Point(76, 147);
            dgImportar.MultiSelect = false;
            dgImportar.Name = "dgImportar";
            dgImportar.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgImportar.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgImportar.RowHeadersWidth = 51;
            dgImportar.Size = new Size(1482, 592);
            dgImportar.TabIndex = 22;
            // 
            // btnLocalizarArquivo
            // 
            btnLocalizarArquivo.Font = new Font("Segoe UI", 13.8F);
            btnLocalizarArquivo.Location = new Point(1417, 85);
            btnLocalizarArquivo.Name = "btnLocalizarArquivo";
            btnLocalizarArquivo.Size = new Size(141, 38);
            btnLocalizarArquivo.TabIndex = 21;
            btnLocalizarArquivo.Text = "Pesquisar";
            btnLocalizarArquivo.UseVisualStyleBackColor = true;
            btnLocalizarArquivo.Click += btnLocalizarArquivo_Click;
            // 
            // txtImportarArquivo
            // 
            txtImportarArquivo.Font = new Font("Segoe UI", 13.8F);
            txtImportarArquivo.Location = new Point(76, 85);
            txtImportarArquivo.Name = "txtImportarArquivo";
            txtImportarArquivo.Size = new Size(1322, 38);
            txtImportarArquivo.TabIndex = 20;
            // 
            // btnImportarArquivo
            // 
            btnImportarArquivo.Font = new Font("Segoe UI", 13.8F);
            btnImportarArquivo.Location = new Point(76, 766);
            btnImportarArquivo.Name = "btnImportarArquivo";
            btnImportarArquivo.Size = new Size(305, 37);
            btnImportarArquivo.TabIndex = 25;
            btnImportarArquivo.Text = "Importar Arquivo";
            btnImportarArquivo.UseVisualStyleBackColor = true;
            btnImportarArquivo.Click += btnImportarArquivo_Click;
            // 
            // progressBarImportacao
            // 
            progressBarImportacao.Location = new Point(76, 746);
            progressBarImportacao.Margin = new Padding(3, 4, 3, 4);
            progressBarImportacao.Name = "progressBarImportacao";
            progressBarImportacao.Size = new Size(1482, 13);
            progressBarImportacao.TabIndex = 29;
            // 
            // lblProgressoImportacao
            // 
            lblProgressoImportacao.AutoSize = true;
            lblProgressoImportacao.Location = new Point(710, 431);
            lblProgressoImportacao.Name = "lblProgressoImportacao";
            lblProgressoImportacao.Size = new Size(0, 20);
            lblProgressoImportacao.TabIndex = 30;
            // 
            // lblResumoImportacao
            // 
            lblResumoImportacao.AutoSize = true;
            lblResumoImportacao.Location = new Point(488, 187);
            lblResumoImportacao.Name = "lblResumoImportacao";
            lblResumoImportacao.Size = new Size(0, 20);
            lblResumoImportacao.TabIndex = 31;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(76, 129);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1482, 12);
            progressBar1.TabIndex = 32;
            // 
            // frmImportarArquivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1622, 853);
            Controls.Add(progressBar1);
            Controls.Add(lblResumoImportacao);
            Controls.Add(lblProgressoImportacao);
            Controls.Add(progressBarImportacao);
            Controls.Add(lblImportarArquivo);
            Controls.Add(btnVoltarArquivo);
            Controls.Add(btnCancelarArquivo);
            Controls.Add(btnImportarArquivo);
            Controls.Add(dgImportar);
            Controls.Add(btnLocalizarArquivo);
            Controls.Add(txtImportarArquivo);
            Name = "frmImportarArquivo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmImportarArquivo";
            ((System.ComponentModel.ISupportInitialize)dgImportar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblImportarArquivo;
        private Button btnVoltarArquivo;
        private Button btnCancelarArquivo;
        private DataGridView dgImportar;
        private Button btnLocalizarArquivo;
        private TextBox txtImportarArquivo;
        private Button btnImportarArquivo;
        private ProgressBar progressBarImportacao;
        private Label lblProgressoImportacao;
        private Label lblResumoImportacao;
        private ProgressBar progressBar1;
    }
}