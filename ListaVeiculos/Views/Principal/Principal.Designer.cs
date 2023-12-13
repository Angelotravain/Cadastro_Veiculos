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
        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = painelPrincipal.Controls.OfType<Forms>().FirstOrDefault();
            formulario = new Forms();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.WindowState = FormWindowState.Maximized;
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.Dock = DockStyle.None;
            painelPrincipal.Controls.Add(formulario);
            painelPrincipal.Tag = formulario;
            formulario.Show();
            formulario.BringToFront();
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeVeículosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeUsuáriosToolStripMenuItem1 = new ToolStripMenuItem();
            filtrosToolStripMenuItem = new ToolStripMenuItem();
            filtorDeVeículosToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            painelPrincipal = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, filtrosToolStripMenuItem, configuraçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(912, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeVeículosToolStripMenuItem, cadastroDeUsuáriosToolStripMenuItem1 });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(88, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastroDeVeículosToolStripMenuItem
            // 
            cadastroDeVeículosToolStripMenuItem.Name = "cadastroDeVeículosToolStripMenuItem";
            cadastroDeVeículosToolStripMenuItem.Size = new Size(234, 26);
            cadastroDeVeículosToolStripMenuItem.Text = "Cadastro de Veículos ";
            cadastroDeVeículosToolStripMenuItem.Click += cadastroDeVeículosToolStripMenuItem_Click;
            // 
            // cadastroDeUsuáriosToolStripMenuItem1
            // 
            cadastroDeUsuáriosToolStripMenuItem1.Name = "cadastroDeUsuáriosToolStripMenuItem1";
            cadastroDeUsuáriosToolStripMenuItem1.Size = new Size(234, 26);
            cadastroDeUsuáriosToolStripMenuItem1.Text = "Cadastro de usuários";
            cadastroDeUsuáriosToolStripMenuItem1.Click += cadastroDeUsuáriosToolStripMenuItem1_Click;
            // 
            // filtrosToolStripMenuItem
            // 
            filtrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { filtorDeVeículosToolStripMenuItem });
            filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            filtrosToolStripMenuItem.Size = new Size(63, 24);
            filtrosToolStripMenuItem.Text = "Filtros";
            // 
            // filtorDeVeículosToolStripMenuItem
            // 
            filtorDeVeículosToolStripMenuItem.Name = "filtorDeVeículosToolStripMenuItem";
            filtorDeVeículosToolStripMenuItem.Size = new Size(204, 26);
            filtorDeVeículosToolStripMenuItem.Text = "Filtro de veículos";
            filtorDeVeículosToolStripMenuItem.Click += filtorDeVeículosToolStripMenuItem_Click;
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem, sobreToolStripMenuItem });
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(118, 24);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(131, 26);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(131, 26);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // painelPrincipal
            // 
            painelPrincipal.Dock = DockStyle.Fill;
            painelPrincipal.Location = new Point(0, 30);
            painelPrincipal.Margin = new Padding(3, 4, 3, 4);
            painelPrincipal.Name = "painelPrincipal";
            painelPrincipal.Size = new Size(912, 559);
            painelPrincipal.TabIndex = 2;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(912, 589);
            Controls.Add(painelPrincipal);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(930, 636);
            MinimumSize = new Size(930, 636);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeVeículosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeUsuáriosToolStripMenuItem1;
        private ToolStripMenuItem filtrosToolStripMenuItem;
        private ToolStripMenuItem filtorDeVeículosToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private Panel painelPrincipal;
    }
}