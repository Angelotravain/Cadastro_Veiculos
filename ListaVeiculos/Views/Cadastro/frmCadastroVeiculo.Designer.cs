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
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(600, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 246);
            panel4.TabIndex = 2;
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
            flowLayoutPanel1.Location = new Point(200, 0);
            flowLayoutPanel1.MaximumSize = new Size(400, 450);
            flowLayoutPanel1.MinimumSize = new Size(400, 450);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(400, 450);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
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
            dtAnoDeFabricacao.TabIndex = 2;
            dtAnoDeFabricacao.Value = new DateTime(2023, 12, 12, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 3;
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
            dtAnoModelo.TabIndex = 4;
            dtAnoModelo.Value = new DateTime(2023, 12, 12, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 29);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 5;
            label3.Text = "Chassi";
            // 
            // txtChassi
            // 
            txtChassi.Location = new Point(50, 32);
            txtChassi.MaxLength = 18;
            txtChassi.Name = "txtChassi";
            txtChassi.Size = new Size(126, 23);
            txtChassi.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(182, 29);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "Marca";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(228, 32);
            txtMarca.MaxLength = 40;
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(160, 23);
            txtMarca.TabIndex = 8;
            txtMarca.Leave += txtMarca_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 58);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 9;
            label5.Text = "Modelo";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(57, 61);
            txtModelo.MaxLength = 60;
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(330, 23);
            txtModelo.TabIndex = 10;
            txtModelo.KeyDown += txtModelo_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 87);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 11;
            label6.Text = "Placa";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(44, 90);
            txtPlaca.MaxLength = 18;
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(108, 23);
            txtPlaca.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(158, 87);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 13;
            label7.Text = "Valor da tabela FIPE";
            // 
            // txtValorFipe
            // 
            txtValorFipe.Location = new Point(273, 90);
            txtValorFipe.MaxLength = 16;
            txtValorFipe.Name = "txtValorFipe";
            txtValorFipe.Size = new Size(103, 23);
            txtValorFipe.TabIndex = 14;
            txtValorFipe.Text = "R$ 0,00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 116);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 15;
            label8.Text = "Valor de venda";
            // 
            // txtValorVenda
            // 
            txtValorVenda.Location = new Point(93, 119);
            txtValorVenda.MaxLength = 16;
            txtValorVenda.Name = "txtValorVenda";
            txtValorVenda.Size = new Size(186, 23);
            txtValorVenda.TabIndex = 16;
            txtValorVenda.Text = "R$ 0,00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(285, 116);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 18;
            label9.Text = "Observações";
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(3, 148);
            txtObservacoes.MaxLength = 300;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(392, 84);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 246);
            panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.Dock = DockStyle.Top;
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Image = Properties.Resources.sair;
            btnSair.ImageAlign = ContentAlignment.TopCenter;
            btnSair.Location = new Point(0, 176);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(200, 44);
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
            btnCancelar.Location = new Point(0, 132);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(200, 44);
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
            btnExcluir.Location = new Point(0, 88);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(200, 44);
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
            btnEditar.Location = new Point(0, 44);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(200, 44);
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
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(200, 44);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.BottomCenter;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmCadastroVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 246);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmCadastroVeiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de veículos";
            Load += frmCadastroVeiculo_Load;
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
        private Button btnSalvar;
        private Button btnSair;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnEditar;
    }
}