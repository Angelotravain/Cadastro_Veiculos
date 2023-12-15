namespace ListaVeiculos.Views.Views.Cadastro
{
    partial class frmCadastroVeiculo
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
            panel4 = new Panel();
            imgVeiculo = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            dtAnoDeFabricacao = new DateTimePicker();
            label2 = new Label();
            dtAnoModelo = new DateTimePicker();
            label3 = new Label();
            txtChassi = new TextBox();
            label4 = new Label();
            txtMarca = new TextBox();
            label5 = new Label();
            txtModelo = new TextBox();
            label6 = new Label();
            txtPlaca = new TextBox();
            label7 = new Label();
            txtValorFipe = new TextBox();
            label8 = new Label();
            txtValorVenda = new TextBox();
            label9 = new Label();
            txtObservacoes = new RichTextBox();
            panel1 = new Panel();
            btnSair = new Button();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgVeiculo).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(imgVeiculo);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(685, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(229, 301);
            panel4.TabIndex = 2;
            // 
            // imgVeiculo
            // 
            imgVeiculo.Cursor = Cursors.Hand;
            imgVeiculo.Image = Properties.Resources.adicionarImagem;
            imgVeiculo.Location = new Point(7, 4);
            imgVeiculo.Margin = new Padding(3, 4, 3, 4);
            imgVeiculo.Name = "imgVeiculo";
            imgVeiculo.Size = new Size(142, 147);
            imgVeiculo.SizeMode = PictureBoxSizeMode.StretchImage;
            imgVeiculo.TabIndex = 0;
            imgVeiculo.TabStop = false;
            imgVeiculo.Click += imgVeiculo_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(dtAnoDeFabricacao);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(dtAnoModelo);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(txtChassi);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(txtMarca);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(txtModelo);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(txtPlaca);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(txtValorFipe);
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Controls.Add(txtValorVenda);
            flowLayoutPanel1.Controls.Add(label9);
            flowLayoutPanel1.Controls.Add(txtObservacoes);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(229, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.MaximumSize = new Size(457, 600);
            flowLayoutPanel1.MinimumSize = new Size(457, 600);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(457, 600);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 0;
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
            dtAnoDeFabricacao.TabIndex = 2;
            dtAnoDeFabricacao.Value = new DateTime(2023, 12, 12, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 3;
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
            dtAnoModelo.TabIndex = 4;
            dtAnoModelo.Value = new DateTime(2023, 12, 12, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 35);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "Chassi";
            // 
            // txtChassi
            // 
            txtChassi.Location = new Point(59, 39);
            txtChassi.Margin = new Padding(3, 4, 3, 4);
            txtChassi.MaxLength = 18;
            txtChassi.Name = "txtChassi";
            txtChassi.Size = new Size(143, 27);
            txtChassi.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(208, 35);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "Marca";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(264, 39);
            txtMarca.Margin = new Padding(3, 4, 3, 4);
            txtMarca.MaxLength = 40;
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(182, 27);
            txtMarca.TabIndex = 8;
            txtMarca.Leave += txtMarca_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 70);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 9;
            label5.Text = "Modelo";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(70, 74);
            txtModelo.Margin = new Padding(3, 4, 3, 4);
            txtModelo.MaxLength = 60;
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(377, 27);
            txtModelo.TabIndex = 10;
            txtModelo.KeyDown += txtModelo_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 105);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 11;
            label6.Text = "Placa";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(53, 109);
            txtPlaca.Margin = new Padding(3, 4, 3, 4);
            txtPlaca.MaxLength = 18;
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(123, 27);
            txtPlaca.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(182, 105);
            label7.Name = "label7";
            label7.Size = new Size(141, 20);
            label7.TabIndex = 13;
            label7.Text = "Valor da tabela FIPE";
            // 
            // txtValorFipe
            // 
            txtValorFipe.Location = new Point(329, 109);
            txtValorFipe.Margin = new Padding(3, 4, 3, 4);
            txtValorFipe.MaxLength = 16;
            txtValorFipe.Name = "txtValorFipe";
            txtValorFipe.Size = new Size(117, 27);
            txtValorFipe.TabIndex = 14;
            txtValorFipe.Text = "R$ 0,00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 140);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 15;
            label8.Text = "Valor de venda";
            // 
            // txtValorVenda
            // 
            txtValorVenda.Location = new Point(117, 144);
            txtValorVenda.Margin = new Padding(3, 4, 3, 4);
            txtValorVenda.MaxLength = 16;
            txtValorVenda.Name = "txtValorVenda";
            txtValorVenda.Size = new Size(212, 27);
            txtValorVenda.TabIndex = 16;
            txtValorVenda.Text = "R$ 0,00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(335, 140);
            label9.Name = "label9";
            label9.Size = new Size(93, 20);
            label9.TabIndex = 18;
            label9.Text = "Observações";
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(3, 179);
            txtObservacoes.Margin = new Padding(3, 4, 3, 4);
            txtObservacoes.MaxLength = 300;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(447, 111);
            txtObservacoes.TabIndex = 17;
            txtObservacoes.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnSalvar);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 301);
            panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.Dock = DockStyle.Top;
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Image = Properties.Resources.sair;
            btnSair.ImageAlign = ContentAlignment.TopCenter;
            btnSair.Location = new Point(0, 236);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(229, 59);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.BottomCenter;
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Dock = DockStyle.Top;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Image = Properties.Resources.cancelar;
            btnCancelar.ImageAlign = ContentAlignment.TopCenter;
            btnCancelar.Location = new Point(0, 177);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(229, 59);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Dock = DockStyle.Top;
            btnExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.Image = Properties.Resources.excluir;
            btnExcluir.ImageAlign = ContentAlignment.TopCenter;
            btnExcluir.Location = new Point(0, 118);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(229, 59);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.BottomCenter;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Dock = DockStyle.Top;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.Image = Properties.Resources.editar;
            btnEditar.ImageAlign = ContentAlignment.TopCenter;
            btnEditar.Location = new Point(0, 59);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(229, 59);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.BottomCenter;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Dock = DockStyle.Top;
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Image = Properties.Resources.salvar;
            btnSalvar.ImageAlign = ContentAlignment.TopCenter;
            btnSalvar.Location = new Point(0, 0);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(229, 59);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.BottomCenter;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmCadastroVeiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 301);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCadastroVeiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de veículos";
            Load += frmCadastroVeiculo_Load;
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgVeiculo).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private DateTimePicker dtAnoDeFabricacao;
        private Label label2;
        private DateTimePicker dtAnoModelo;
        private Label label3;
        private TextBox txtChassi;
        private Label label4;
        private TextBox txtMarca;
        private Label label5;
        private TextBox txtModelo;
        private Label label6;
        private TextBox txtPlaca;
        private Label label7;
        private TextBox txtValorFipe;
        private Label label8;
        private TextBox txtValorVenda;
        private Label label9;
        private RichTextBox txtObservacoes;
        private PictureBox imgVeiculo;
        private Button btnSalvar;
        private Button btnSair;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnEditar;
    }
}