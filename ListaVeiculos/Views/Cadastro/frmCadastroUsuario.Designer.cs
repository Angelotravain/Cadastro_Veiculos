namespace ListaVeiculos.Views.Views.Cadastro
{
    partial class frmCadastroUsuario
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtNome = new Label();
            txtChassi = new TextBox();
            label4 = new Label();
            txtMarca = new TextBox();
            label5 = new Label();
            txtModelo = new TextBox();
            panel1 = new Panel();
            btnSair = new Button();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            panel2 = new Panel();
            btnPesquisarUsuario = new Button();
            label2 = new Label();
            txtFiltrarUsuario = new TextBox();
            txtFiltrarNome = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(txtNome);
            flowLayoutPanel1.Controls.Add(txtChassi);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(txtMarca);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(txtModelo);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(229, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(685, 116);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.AutoSize = true;
            txtNome.Location = new Point(3, 0);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(50, 20);
            txtNome.TabIndex = 5;
            txtNome.Text = "Nome";
            // 
            // txtChassi
            // 
            txtChassi.Location = new Point(59, 4);
            txtChassi.Margin = new Padding(3, 4, 3, 4);
            txtChassi.MaxLength = 18;
            txtChassi.Name = "txtChassi";
            txtChassi.Size = new Size(615, 27);
            txtChassi.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 35);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 7;
            label4.Text = "Usuário";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(68, 39);
            txtMarca.Margin = new Padding(3, 4, 3, 4);
            txtMarca.MaxLength = 40;
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(255, 27);
            txtMarca.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(329, 35);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 9;
            label5.Text = "Senha";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(384, 39);
            txtModelo.Margin = new Padding(3, 4, 3, 4);
            txtModelo.MaxLength = 60;
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(290, 27);
            txtModelo.TabIndex = 10;
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
            panel1.Size = new Size(229, 600);
            panel1.TabIndex = 3;
            // 
            // btnSair
            // 
            btnSair.Dock = DockStyle.Top;
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Image = Properties.Resources.sair;
            btnSair.ImageAlign = ContentAlignment.TopCenter;
            btnSair.Location = new Point(0, 232);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(229, 58);
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
            btnCancelar.Location = new Point(0, 174);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(229, 58);
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
            btnExcluir.Location = new Point(0, 116);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(229, 58);
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
            btnEditar.Location = new Point(0, 58);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(229, 58);
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
            btnSalvar.Size = new Size(229, 58);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.BottomCenter;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnPesquisarUsuario);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtFiltrarUsuario);
            panel2.Controls.Add(txtFiltrarNome);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(229, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(685, 87);
            panel2.TabIndex = 5;
            // 
            // btnPesquisarUsuario
            // 
            btnPesquisarUsuario.Image = Properties.Resources.pesquisa;
            btnPesquisarUsuario.ImageAlign = ContentAlignment.MiddleRight;
            btnPesquisarUsuario.Location = new Point(542, 42);
            btnPesquisarUsuario.Name = "btnPesquisarUsuario";
            btnPesquisarUsuario.Size = new Size(131, 34);
            btnPesquisarUsuario.TabIndex = 13;
            btnPesquisarUsuario.Text = "Pesquisar";
            btnPesquisarUsuario.UseVisualStyleBackColor = true;
            btnPesquisarUsuario.Click += btnPesquisarUsuario_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 4);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 11;
            label2.Text = "Usuário";
            // 
            // txtFiltrarUsuario
            // 
            txtFiltrarUsuario.Location = new Point(394, 8);
            txtFiltrarUsuario.Margin = new Padding(3, 4, 3, 4);
            txtFiltrarUsuario.MaxLength = 40;
            txtFiltrarUsuario.Name = "txtFiltrarUsuario";
            txtFiltrarUsuario.Size = new Size(279, 27);
            txtFiltrarUsuario.TabIndex = 12;
            // 
            // txtFiltrarNome
            // 
            txtFiltrarNome.AutoSize = true;
            txtFiltrarNome.Dock = DockStyle.Top;
            txtFiltrarNome.Location = new Point(0, 0);
            txtFiltrarNome.Name = "txtFiltrarNome";
            txtFiltrarNome.Size = new Size(50, 20);
            txtFiltrarNome.TabIndex = 9;
            txtFiltrarNome.Text = "Nome";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(59, 8);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.MaxLength = 40;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 27);
            textBox1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(229, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(685, 397);
            dataGridView1.TabIndex = 6;
            // 
            // frmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCadastroUsuario";
            Text = "Cadastro de usuários";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label txtNome;
        private TextBox txtChassi;
        private Label label4;
        private TextBox txtMarca;
        private Label label5;
        private TextBox txtModelo;
        private Panel panel1;
        private Button btnSair;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnSalvar;
        private Panel panel2;
        private Button btnPesquisarUsuario;
        private Label label2;
        private TextBox txtFiltrarUsuario;
        private Label txtFiltrarNome;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}