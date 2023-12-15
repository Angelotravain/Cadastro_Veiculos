namespace ListaVeiculos
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            painelPrincipal = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pcSair = new PictureBox();
            pcSobre = new PictureBox();
            pcVeiculos = new PictureBox();
            painelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcSair).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcSobre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcVeiculos).BeginInit();
            SuspendLayout();
            // 
            // painelPrincipal
            // 
            painelPrincipal.Controls.Add(label3);
            painelPrincipal.Controls.Add(label2);
            painelPrincipal.Controls.Add(label1);
            painelPrincipal.Controls.Add(pcSair);
            painelPrincipal.Controls.Add(pcSobre);
            painelPrincipal.Controls.Add(pcVeiculos);
            painelPrincipal.Dock = DockStyle.Fill;
            painelPrincipal.Location = new Point(0, 0);
            painelPrincipal.Name = "painelPrincipal";
            painelPrincipal.Size = new Size(800, 446);
            painelPrincipal.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(85, 256);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 5;
            label3.Text = "Veículos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(639, 256);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 4;
            label2.Text = "Sair";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(361, 256);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 3;
            label1.Text = "Sobre";
            // 
            // pcSair
            // 
            pcSair.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcSair.Cursor = Cursors.Hand;
            pcSair.Image = Views.Properties.Resources.sair1;
            pcSair.Location = new Point(595, 129);
            pcSair.Name = "pcSair";
            pcSair.Size = new Size(131, 124);
            pcSair.SizeMode = PictureBoxSizeMode.StretchImage;
            pcSair.TabIndex = 2;
            pcSair.TabStop = false;
            pcSair.Click += pcSair_Click;
            // 
            // pcSobre
            // 
            pcSobre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcSobre.Cursor = Cursors.Hand;
            pcSobre.Image = Views.Properties.Resources.soobre;
            pcSobre.Location = new Point(328, 129);
            pcSobre.Name = "pcSobre";
            pcSobre.Size = new Size(131, 124);
            pcSobre.SizeMode = PictureBoxSizeMode.StretchImage;
            pcSobre.TabIndex = 1;
            pcSobre.TabStop = false;
            pcSobre.Click += pcSobre_Click;
            // 
            // pcVeiculos
            // 
            pcVeiculos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pcVeiculos.Cursor = Cursors.Hand;
            pcVeiculos.Image = Views.Properties.Resources.veiculo1;
            pcVeiculos.Location = new Point(61, 129);
            pcVeiculos.Name = "pcVeiculos";
            pcVeiculos.Size = new Size(131, 124);
            pcVeiculos.SizeMode = PictureBoxSizeMode.StretchImage;
            pcVeiculos.TabIndex = 0;
            pcVeiculos.TabStop = false;
            pcVeiculos.Click += pcVeiculos_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 446);
            Controls.Add(painelPrincipal);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(816, 485);
            MinimumSize = new Size(816, 485);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            FormClosing += Form1_FormClosing;
            Load += Principal_Load;
            painelPrincipal.ResumeLayout(false);
            painelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcSair).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcSobre).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcVeiculos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel painelPrincipal;
        private PictureBox pcVeiculos;
        private PictureBox pcSair;
        private PictureBox pcSobre;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}