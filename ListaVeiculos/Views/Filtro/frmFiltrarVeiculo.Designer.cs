namespace ListaVeiculos.Views.Views.Filtro
{
    partial class frmFiltrarVeiculo
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
            panel1 = new Panel();
            button1 = new Button();
            btnNovoVeiculo = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            dtAnoDeFabricacao = new DateTimePicker();
            label2 = new Label();
            dtAnoModelo = new DateTimePicker();
            label3 = new Label();
            txtChassi = new TextBox();
            label5 = new Label();
            txtModelo = new TextBox();
            label6 = new Label();
            txtPlaca = new TextBox();
            lbMarca = new Label();
            txtMarca = new TextBox();
            btnPesquisarVeiculo = new Button();
            gridVeiculo = new DataGridView();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridVeiculo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnNovoVeiculo);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 239);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.sair;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(603, 44);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(197, 44);
            button1.TabIndex = 3;
            button1.Text = "Sair";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnNovoVeiculo
            // 
            btnNovoVeiculo.Dock = DockStyle.Top;
            btnNovoVeiculo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNovoVeiculo.Image = Properties.Resources.novo;
            btnNovoVeiculo.ImageAlign = ContentAlignment.TopCenter;
            btnNovoVeiculo.Location = new Point(603, 0);
            btnNovoVeiculo.Margin = new Padding(3, 2, 3, 2);
            btnNovoVeiculo.Name = "btnNovoVeiculo";
            btnNovoVeiculo.Size = new Size(197, 44);
            btnNovoVeiculo.TabIndex = 1;
            btnNovoVeiculo.Text = "Novo";
            btnNovoVeiculo.TextAlign = ContentAlignment.BottomCenter;
            btnNovoVeiculo.UseVisualStyleBackColor = true;
            btnNovoVeiculo.Click += btnNovoVeiculo_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(dtAnoDeFabricacao);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(dtAnoModelo);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(txtChassi);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(txtModelo);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(txtPlaca);
            flowLayoutPanel1.Controls.Add(lbMarca);
            flowLayoutPanel1.Controls.Add(txtMarca);
            flowLayoutPanel1.Controls.Add(btnPesquisarVeiculo);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(603, 239);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 23;
            label1.Text = "Ano de fabricação";
            // 
            // dtAnoDeFabricacao
            // 
            dtAnoDeFabricacao.CustomFormat = "yyyy";
            dtAnoDeFabricacao.Format = DateTimePickerFormat.Custom;
            dtAnoDeFabricacao.Location = new Point(112, 3);
            dtAnoDeFabricacao.Name = "dtAnoDeFabricacao";
            dtAnoDeFabricacao.ShowUpDown = true;
            dtAnoDeFabricacao.Size = new Size(92, 23);
            dtAnoDeFabricacao.TabIndex = 24;
            dtAnoDeFabricacao.Value = new DateTime(2023, 12, 12, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 25;
            label2.Text = "Ano modelo";
            // 
            // dtAnoModelo
            // 
            dtAnoModelo.CustomFormat = "yyyy";
            dtAnoModelo.Format = DateTimePickerFormat.Custom;
            dtAnoModelo.Location = new Point(289, 3);
            dtAnoModelo.Name = "dtAnoModelo";
            dtAnoModelo.ShowUpDown = true;
            dtAnoModelo.Size = new Size(85, 23);
            dtAnoModelo.TabIndex = 26;
            dtAnoModelo.Value = new DateTime(2023, 12, 12, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(380, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 27;
            label3.Text = "Chassi";
            // 
            // txtChassi
            // 
            txtChassi.Location = new Point(427, 3);
            txtChassi.MaxLength = 18;
            txtChassi.Name = "txtChassi";
            txtChassi.Size = new Size(148, 23);
            txtChassi.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 29);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 29;
            label5.Text = "Modelo";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(57, 32);
            txtModelo.MaxLength = 60;
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(330, 23);
            txtModelo.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(393, 29);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 31;
            label6.Text = "Placa";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(434, 32);
            txtPlaca.MaxLength = 18;
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(154, 23);
            txtPlaca.TabIndex = 32;
            // 
            // lbMarca
            // 
            lbMarca.AutoSize = true;
            lbMarca.Location = new Point(3, 58);
            lbMarca.Name = "lbMarca";
            lbMarca.Size = new Size(40, 15);
            lbMarca.TabIndex = 34;
            lbMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(49, 61);
            txtMarca.MaxLength = 18;
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(154, 23);
            txtMarca.TabIndex = 35;
            // 
            // btnPesquisarVeiculo
            // 
            btnPesquisarVeiculo.Image = Properties.Resources.pesquisa;
            btnPesquisarVeiculo.ImageAlign = ContentAlignment.MiddleRight;
            btnPesquisarVeiculo.Location = new Point(209, 60);
            btnPesquisarVeiculo.Margin = new Padding(3, 2, 3, 2);
            btnPesquisarVeiculo.Name = "btnPesquisarVeiculo";
            btnPesquisarVeiculo.Size = new Size(115, 32);
            btnPesquisarVeiculo.TabIndex = 33;
            btnPesquisarVeiculo.Text = "Pesquisar";
            btnPesquisarVeiculo.UseVisualStyleBackColor = true;
            btnPesquisarVeiculo.Click += btnPesquisarVeiculo_Click;
            // 
            // gridVeiculo
            // 
            gridVeiculo.BackgroundColor = Color.White;
            gridVeiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVeiculo.Dock = DockStyle.Fill;
            gridVeiculo.Location = new Point(0, 239);
            gridVeiculo.Margin = new Padding(3, 2, 3, 2);
            gridVeiculo.Name = "gridVeiculo";
            gridVeiculo.RowHeadersWidth = 51;
            gridVeiculo.RowTemplate.Height = 29;
            gridVeiculo.Size = new Size(800, 211);
            gridVeiculo.TabIndex = 1;
            gridVeiculo.CellContentDoubleClick += gridVeiculo_CellContentDoubleClick;
            // 
            // frmFiltrarVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(gridVeiculo);
            Controls.Add(panel1);
            MaximumSize = new Size(816, 489);
            Name = "frmFiltrarVeiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Veículos";
            Load += frmFiltrarVeiculo_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridVeiculo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView gridVeiculo;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private DateTimePicker dtAnoDeFabricacao;
        private Label label2;
        private DateTimePicker dtAnoModelo;
        private Label label3;
        private TextBox txtChassi;
        private Label label5;
        private TextBox txtModelo;
        private Label label6;
        private TextBox txtPlaca;
        private Button btnNovoVeiculo;
        private Button btnPesquisarVeiculo;
        private Button button1;
        private Label lbMarca;
        private TextBox txtMarca;
    }
}