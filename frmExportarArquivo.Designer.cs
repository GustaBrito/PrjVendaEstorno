namespace VendaEstorno
{
    partial class frmExportarArquivo
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
            lblExportarArquivo = new Label();
            btnVoltarExpArquivo = new Button();
            btnCancelarExpArquivo = new Button();
            btnExportarArquivo = new Button();
            btnLocalizarExpArquivo = new Button();
            txtExportarArquivo = new TextBox();
            progressBarExportacao = new ProgressBar();
            lblProgressoExportacao = new Label();
            SuspendLayout();
            // 
            // lblExportarArquivo
            // 
            lblExportarArquivo.AutoSize = true;
            lblExportarArquivo.Font = new Font("Segoe UI", 13.8F);
            lblExportarArquivo.Location = new Point(384, 72);
            lblExportarArquivo.Name = "lblExportarArquivo";
            lblExportarArquivo.Size = new Size(341, 31);
            lblExportarArquivo.TabIndex = 35;
            lblExportarArquivo.Text = "Localize o arquivo para Exportar";
            // 
            // btnVoltarExpArquivo
            // 
            btnVoltarExpArquivo.Font = new Font("Segoe UI", 13.8F);
            btnVoltarExpArquivo.Location = new Point(1058, 172);
            btnVoltarExpArquivo.Name = "btnVoltarExpArquivo";
            btnVoltarExpArquivo.Size = new Size(167, 44);
            btnVoltarExpArquivo.TabIndex = 34;
            btnVoltarExpArquivo.Text = "Voltar";
            btnVoltarExpArquivo.UseVisualStyleBackColor = true;
            btnVoltarExpArquivo.Click += btnVoltarExpArquivo_Click;
            // 
            // btnCancelarExpArquivo
            // 
            btnCancelarExpArquivo.Font = new Font("Segoe UI", 13.8F);
            btnCancelarExpArquivo.Location = new Point(885, 172);
            btnCancelarExpArquivo.Name = "btnCancelarExpArquivo";
            btnCancelarExpArquivo.Size = new Size(167, 44);
            btnCancelarExpArquivo.TabIndex = 33;
            btnCancelarExpArquivo.Text = "Cancelar";
            btnCancelarExpArquivo.UseVisualStyleBackColor = true;
            btnCancelarExpArquivo.Click += btnCancelarExpArquivo_Click;
            // 
            // btnExportarArquivo
            // 
            btnExportarArquivo.Font = new Font("Segoe UI", 13.8F);
            btnExportarArquivo.Location = new Point(384, 172);
            btnExportarArquivo.Name = "btnExportarArquivo";
            btnExportarArquivo.Size = new Size(305, 44);
            btnExportarArquivo.TabIndex = 32;
            btnExportarArquivo.Text = "Exportar Arquivo";
            btnExportarArquivo.UseVisualStyleBackColor = true;
            btnExportarArquivo.Click += btnExportarArquivo_Click;
            // 
            // btnLocalizarExpArquivo
            // 
            btnLocalizarExpArquivo.Font = new Font("Segoe UI", 13.8F);
            btnLocalizarExpArquivo.Location = new Point(1075, 59);
            btnLocalizarExpArquivo.Name = "btnLocalizarExpArquivo";
            btnLocalizarExpArquivo.Size = new Size(150, 44);
            btnLocalizarExpArquivo.TabIndex = 30;
            btnLocalizarExpArquivo.Text = "Pesquisar";
            btnLocalizarExpArquivo.UseVisualStyleBackColor = true;
            btnLocalizarExpArquivo.Click += btnLocalizarExpArquivo_Click;
            // 
            // txtExportarArquivo
            // 
            txtExportarArquivo.Font = new Font("Segoe UI", 13.8F);
            txtExportarArquivo.Location = new Point(384, 106);
            txtExportarArquivo.Name = "txtExportarArquivo";
            txtExportarArquivo.Size = new Size(841, 38);
            txtExportarArquivo.TabIndex = 29;
            // 
            // progressBarExportacao
            // 
            progressBarExportacao.Location = new Point(384, 151);
            progressBarExportacao.Margin = new Padding(3, 4, 3, 4);
            progressBarExportacao.Name = "progressBarExportacao";
            progressBarExportacao.Size = new Size(841, 14);
            progressBarExportacao.TabIndex = 36;
            // 
            // lblProgressoExportacao
            // 
            lblProgressoExportacao.AutoSize = true;
            lblProgressoExportacao.Location = new Point(808, 360);
            lblProgressoExportacao.Name = "lblProgressoExportacao";
            lblProgressoExportacao.Size = new Size(0, 20);
            lblProgressoExportacao.TabIndex = 37;
            // 
            // frmExportarArquivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1622, 853);
            Controls.Add(lblProgressoExportacao);
            Controls.Add(progressBarExportacao);
            Controls.Add(lblExportarArquivo);
            Controls.Add(btnVoltarExpArquivo);
            Controls.Add(btnCancelarExpArquivo);
            Controls.Add(btnExportarArquivo);
            Controls.Add(btnLocalizarExpArquivo);
            Controls.Add(txtExportarArquivo);
            Name = "frmExportarArquivo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmExportarArquivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExportarArquivo;
        private Button btnVoltarExpArquivo;
        private Button btnCancelarExpArquivo;
        private Button btnExportarArquivo;
        private Button btnLocalizarExpArquivo;
        private TextBox txtExportarArquivo;
        private ProgressBar progressBarExportacao;
        private Label lblProgressoExportacao;
    }
}