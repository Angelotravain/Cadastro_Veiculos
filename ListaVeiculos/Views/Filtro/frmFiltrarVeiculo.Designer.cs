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
            btnPesquisarVeiculo = new Button();
            imgVeiculo = new PictureBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgVeiculo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnNovoVeiculo);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(imgVeiculo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 319);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.sair;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(689, 58);
            button1.Name = "button1";
            button1.Size = new Size(225, 58);
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
            btnNovoVeiculo.Location = new Point(689, 0);
            btnNovoVeiculo.Name = "btnNovoVeiculo";
            btnNovoVeiculo.Size = new Size(225, 58);
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
            flowLayoutPanel1.Controls.Add(btnPesquisarVeiculo);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(689, 319);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 23;
            label1.Text = "Ano de fabricação";
            // 
            // dtAnoDeFabricacao
            // 
            dtAnoDeFabricacao.CustomFormat = "yyyy";
            dtAnoDeFabricacao.Format = DateTimePickerFormat.Custom;
            dtAnoDeFabricacao.Location = new Point(140, 4);
            dtAnoDeFabricacao.Margin = new Padding(3, 4, 3, 4);
            dtAnoDeFabricacao.Name = "dtAnoDeFabricacao";
            dtAnoDeFabricacao.ShowUpDown = true;
            dtAnoDeFabricacao.Size = new Size(105, 27);
            dtAnoDeFabricacao.TabIndex = 24;
            dtAnoDeFabricacao.Value = new DateTime(2023, 12, 12, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 25;
            label2.Text = "Ano modelo";
            // 
            // dtAnoModelo
            // 
            dtAnoModelo.CustomFormat = "yyyy";
            dtAnoModelo.Format = DateTimePickerFormat.Custom;
            dtAnoModelo.Location = new Point(349, 4);
            dtAnoModelo.Margin = new Padding(3, 4, 3, 4);
            dtAnoModelo.Name = "dtAnoModelo";
            dtAnoModelo.ShowUpDown = true;
            dtAnoModelo.Size = new Size(97, 27);
            dtAnoModelo.TabIndex = 26;
            dtAnoModelo.Value = new DateTime(2023, 12, 12, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(452, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 27;
            label3.Text = "Chassi";
            // 
            // txtChassi
            // 
            txtChassi.Location = new Point(508, 4);
            txtChassi.Margin = new Padding(3, 4, 3, 4);
            txtChassi.MaxLength = 18;
            txtChassi.Name = "txtChassi";
            txtChassi.Size = new Size(169, 27);
            txtChassi.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 35);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 29;
            label5.Text = "Modelo";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(70, 39);
            txtModelo.Margin = new Padding(3, 4, 3, 4);
            txtModelo.MaxLength = 60;
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(376, 27);
            txtModelo.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(452, 35);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 31;
            label6.Text = "Placa";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(502, 39);
            txtPlaca.Margin = new Padding(3, 4, 3, 4);
            txtPlaca.MaxLength = 18;
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(175, 27);
            txtPlaca.TabIndex = 32;
            // 
            // btnPesquisarVeiculo
            // 
            btnPesquisarVeiculo.Image = Properties.Resources.pesquisa;
            btnPesquisarVeiculo.ImageAlign = ContentAlignment.MiddleRight;
            btnPesquisarVeiculo.Location = new Point(3, 73);
            btnPesquisarVeiculo.Name = "btnPesquisarVeiculo";
            btnPesquisarVeiculo.Size = new Size(131, 43);
            btnPesquisarVeiculo.TabIndex = 33;
            btnPesquisarVeiculo.Text = "Pesquisar";
            btnPesquisarVeiculo.UseVisualStyleBackColor = true;
            // 
            // imgVeiculo
            // 
            imgVeiculo.Image = Properties.Resources.novo;
            imgVeiculo.Location = new Point(689, 170);
            imgVeiculo.Margin = new Padding(3, 4, 3, 4);
            imgVeiculo.Name = "imgVeiculo";
            imgVeiculo.Size = new Size(222, 142);
            imgVeiculo.SizeMode = PictureBoxSizeMode.StretchImage;
            imgVeiculo.TabIndex = 2;
            imgVeiculo.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 319);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(914, 281);
            dataGridView1.TabIndex = 1;
            // 
            // frmFiltrarVeiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmFiltrarVeiculo";
            Text = "Buscar Veículos";
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgVeiculo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
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
        private PictureBox imgVeiculo;
        private Button button1;
    }
}