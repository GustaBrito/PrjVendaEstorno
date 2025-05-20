namespace VendaEstorno
{
    partial class frmEstorno
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
            dgEstorno = new DataGridView();
            btnEstorno = new Button();
            btnOkEstorno = new Button();
            lblCodProdEstorno = new Label();
            btnVoltarEstorno = new Button();
            txtCodVenda = new TextBox();
            btnCancelarEstorno = new Button();
            dgData = new DataGridView();
            btnEstornoData = new Button();
            mskInicialEstorno = new MaskedTextBox();
            mskFinalEstorno = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgEstorno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgData).BeginInit();
            SuspendLayout();
            // 
            // dgEstorno
            // 
            dgEstorno.AllowUserToAddRows = false;
            dgEstorno.AllowUserToDeleteRows = false;
            dgEstorno.AllowUserToResizeColumns = false;
            dgEstorno.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgEstorno.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgEstorno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgEstorno.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgEstorno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgEstorno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgEstorno.DefaultCellStyle = dataGridViewCellStyle3;
            dgEstorno.Location = new Point(55, 517);
            dgEstorno.MultiSelect = false;
            dgEstorno.Name = "dgEstorno";
            dgEstorno.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgEstorno.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgEstorno.RowHeadersWidth = 51;
            dgEstorno.Size = new Size(1523, 387);
            dgEstorno.TabIndex = 17;
            // 
            // btnEstorno
            // 
            btnEstorno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnEstorno.Location = new Point(54, 910);
            btnEstorno.Name = "btnEstorno";
            btnEstorno.Size = new Size(134, 47);
            btnEstorno.TabIndex = 16;
            btnEstorno.Text = "Estorno";
            btnEstorno.UseVisualStyleBackColor = true;
            btnEstorno.Click += btnEstorno_Click;
            // 
            // btnOkEstorno
            // 
            btnOkEstorno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnOkEstorno.Location = new Point(301, 473);
            btnOkEstorno.Name = "btnOkEstorno";
            btnOkEstorno.Size = new Size(107, 38);
            btnOkEstorno.TabIndex = 15;
            btnOkEstorno.Text = "OK";
            btnOkEstorno.UseVisualStyleBackColor = true;
            btnOkEstorno.Click += btnOkEstorno_Click;
            // 
            // lblCodProdEstorno
            // 
            lblCodProdEstorno.AutoSize = true;
            lblCodProdEstorno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblCodProdEstorno.Location = new Point(54, 434);
            lblCodProdEstorno.Name = "lblCodProdEstorno";
            lblCodProdEstorno.Size = new Size(195, 31);
            lblCodProdEstorno.TabIndex = 9;
            lblCodProdEstorno.Text = "Codigo da Venda";
            // 
            // btnVoltarEstorno
            // 
            btnVoltarEstorno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnVoltarEstorno.Location = new Point(1443, 910);
            btnVoltarEstorno.Name = "btnVoltarEstorno";
            btnVoltarEstorno.Size = new Size(134, 47);
            btnVoltarEstorno.TabIndex = 18;
            btnVoltarEstorno.Text = "Voltar";
            btnVoltarEstorno.UseVisualStyleBackColor = true;
            btnVoltarEstorno.Click += btnVoltarEstorno_Click;
            // 
            // txtCodVenda
            // 
            txtCodVenda.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtCodVenda.Location = new Point(54, 473);
            txtCodVenda.Name = "txtCodVenda";
            txtCodVenda.Size = new Size(241, 38);
            txtCodVenda.TabIndex = 19;
            // 
            // btnCancelarEstorno
            // 
            btnCancelarEstorno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnCancelarEstorno.Location = new Point(194, 910);
            btnCancelarEstorno.Name = "btnCancelarEstorno";
            btnCancelarEstorno.Size = new Size(134, 47);
            btnCancelarEstorno.TabIndex = 21;
            btnCancelarEstorno.Text = "Cancelar ";
            btnCancelarEstorno.UseVisualStyleBackColor = true;
            btnCancelarEstorno.Click += btnCancelarEstorno_Click;
            // 
            // dgData
            // 
            dgData.AllowUserToAddRows = false;
            dgData.AllowUserToDeleteRows = false;
            dgData.AllowUserToResizeColumns = false;
            dgData.AllowUserToResizeRows = false;
            dgData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgData.DefaultCellStyle = dataGridViewCellStyle3;
            dgData.Location = new Point(55, 94);
            dgData.MultiSelect = false;
            dgData.Name = "dgData";
            dgData.ReadOnly = true;
            dgData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgData.RowHeadersWidth = 51;
            dgData.Size = new Size(1523, 337);
            dgData.TabIndex = 22;
            dgData.CellClick += dgData_CellClick;
            // 
            // btnEstornoData
            // 
            btnEstornoData.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnEstornoData.Location = new Point(493, 51);
            btnEstornoData.Name = "btnEstornoData";
            btnEstornoData.Size = new Size(107, 38);
            btnEstornoData.TabIndex = 25;
            btnEstornoData.Text = "OK";
            btnEstornoData.UseVisualStyleBackColor = true;
            btnEstornoData.Click += btnEstornoData_Click;
            // 
            // mskInicialEstorno
            // 
            mskInicialEstorno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mskInicialEstorno.Location = new Point(54, 51);
            mskInicialEstorno.Mask = "00/00/0000";
            mskInicialEstorno.Name = "mskInicialEstorno";
            mskInicialEstorno.Size = new Size(206, 38);
            mskInicialEstorno.TabIndex = 26;
            mskInicialEstorno.ValidatingType = typeof(DateTime);
            // 
            // mskFinalEstorno
            // 
            mskFinalEstorno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mskFinalEstorno.Location = new Point(282, 51);
            mskFinalEstorno.Mask = "00/00/0000";
            mskFinalEstorno.Name = "mskFinalEstorno";
            mskFinalEstorno.Size = new Size(205, 38);
            mskFinalEstorno.TabIndex = 27;
            mskFinalEstorno.ValidatingType = typeof(DateTime);
            // 
            // frmEstorno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1622, 969);
            Controls.Add(mskFinalEstorno);
            Controls.Add(mskInicialEstorno);
            Controls.Add(btnEstornoData);
            Controls.Add(dgData);
            Controls.Add(btnCancelarEstorno);
            Controls.Add(txtCodVenda);
            Controls.Add(btnVoltarEstorno);
            Controls.Add(dgEstorno);
            Controls.Add(btnEstorno);
            Controls.Add(btnOkEstorno);
            Controls.Add(lblCodProdEstorno);
            Name = "frmEstorno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estorno";
            ((System.ComponentModel.ISupportInitialize)dgEstorno).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgEstorno;
        private Button btnEstorno;
        private Button btnOkEstorno;
        private Label lblCodProdEstorno;
        private Button btnVoltarEstorno;
        private TextBox txtCodVenda;
        private Button btnCancelarEstorno;
        private DataGridView dgData;
        private Button btnEstornoData;
        private MaskedTextBox mskInicialEstorno;
        private MaskedTextBox mskFinalEstorno;
    }
}