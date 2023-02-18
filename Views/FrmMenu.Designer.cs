
namespace Projeto_controle_de_vendas.Views
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.novaVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 82);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::Projeto_controle_de_vendas.Properties.Resources._134216_menu_lines_hamburger_icon;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "       Menu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCliente,
            this.menuFuncionario,
            this.menuFornecedor,
            this.menuProduto,
            this.menuVenda,
            this.menuConfig});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCliente
            // 
            this.menuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroCliente,
            this.consultaCliente});
            this.menuCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCliente.Image = global::Projeto_controle_de_vendas.Properties.Resources.user48;
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(75, 21);
            this.menuCliente.Text = "Cliente";
            // 
            // cadastroCliente
            // 
            this.cadastroCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroCliente.Image = global::Projeto_controle_de_vendas.Properties.Resources._3017948_add_extra_fill_more_plus_icon;
            this.cadastroCliente.Name = "cadastroCliente";
            this.cadastroCliente.Size = new System.Drawing.Size(178, 22);
            this.cadastroCliente.Text = "Cadastro de Cliente";
            this.cadastroCliente.Click += new System.EventHandler(this.cadastroCliente_Click);
            // 
            // consultaCliente
            // 
            this.consultaCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaCliente.Image = global::Projeto_controle_de_vendas.Properties.Resources._3440850_find_glass_magnifier_magnifying_search_icon;
            this.consultaCliente.Name = "consultaCliente";
            this.consultaCliente.Size = new System.Drawing.Size(178, 22);
            this.consultaCliente.Text = "Consulta de Cliente";
            this.consultaCliente.Click += new System.EventHandler(this.consultaCliente_Click);
            // 
            // menuFuncionario
            // 
            this.menuFuncionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroFuncionario,
            this.consultaFuncionario});
            this.menuFuncionario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFuncionario.Image = global::Projeto_controle_de_vendas.Properties.Resources._4714992_avatar_man_people_person_profile_icon;
            this.menuFuncionario.Name = "menuFuncionario";
            this.menuFuncionario.Size = new System.Drawing.Size(103, 21);
            this.menuFuncionario.Text = "Funcionário";
            // 
            // cadastroFuncionario
            // 
            this.cadastroFuncionario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroFuncionario.Image = global::Projeto_controle_de_vendas.Properties.Resources._3017948_add_extra_fill_more_plus_icon;
            this.cadastroFuncionario.Name = "cadastroFuncionario";
            this.cadastroFuncionario.Size = new System.Drawing.Size(209, 22);
            this.cadastroFuncionario.Text = "Cadastro de Funcionários";
            this.cadastroFuncionario.Click += new System.EventHandler(this.cadastroFuncionario_Click);
            // 
            // consultaFuncionario
            // 
            this.consultaFuncionario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaFuncionario.Image = global::Projeto_controle_de_vendas.Properties.Resources._3440850_find_glass_magnifier_magnifying_search_icon;
            this.consultaFuncionario.Name = "consultaFuncionario";
            this.consultaFuncionario.Size = new System.Drawing.Size(209, 22);
            this.consultaFuncionario.Text = "Consulta de Funcionários";
            this.consultaFuncionario.Click += new System.EventHandler(this.consultaFuncionario_Click);
            // 
            // menuFornecedor
            // 
            this.menuFornecedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroFornecedor,
            this.consultaFornecedor});
            this.menuFornecedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFornecedor.Image = global::Projeto_controle_de_vendas.Properties.Resources._3827713_color_delivery_lineal_sale_shipping_icon;
            this.menuFornecedor.Name = "menuFornecedor";
            this.menuFornecedor.Size = new System.Drawing.Size(103, 21);
            this.menuFornecedor.Text = "Fornecedor";
            // 
            // cadastroFornecedor
            // 
            this.cadastroFornecedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroFornecedor.Image = global::Projeto_controle_de_vendas.Properties.Resources._3017948_add_extra_fill_more_plus_icon;
            this.cadastroFornecedor.Name = "cadastroFornecedor";
            this.cadastroFornecedor.Size = new System.Drawing.Size(201, 22);
            this.cadastroFornecedor.Text = "Cadastro de Fornecedor";
            this.cadastroFornecedor.Click += new System.EventHandler(this.cadastroFornecedor_Click);
            // 
            // consultaFornecedor
            // 
            this.consultaFornecedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaFornecedor.Image = global::Projeto_controle_de_vendas.Properties.Resources._3440850_find_glass_magnifier_magnifying_search_icon;
            this.consultaFornecedor.Name = "consultaFornecedor";
            this.consultaFornecedor.Size = new System.Drawing.Size(201, 22);
            this.consultaFornecedor.Text = "Consulta de Fornecedor";
            this.consultaFornecedor.Click += new System.EventHandler(this.consultaFornecedor_Click);
            // 
            // menuProduto
            // 
            this.menuProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroProduto,
            this.consultaProduto});
            this.menuProduto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProduto.Image = global::Projeto_controle_de_vendas.Properties.Resources._299088_bag_icon;
            this.menuProduto.Name = "menuProduto";
            this.menuProduto.Size = new System.Drawing.Size(83, 21);
            this.menuProduto.Text = "Produto";
            // 
            // cadastroProduto
            // 
            this.cadastroProduto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroProduto.Image = global::Projeto_controle_de_vendas.Properties.Resources._3017948_add_extra_fill_more_plus_icon;
            this.cadastroProduto.Name = "cadastroProduto";
            this.cadastroProduto.Size = new System.Drawing.Size(184, 22);
            this.cadastroProduto.Text = "Cadastro de Produto";
            this.cadastroProduto.Click += new System.EventHandler(this.cadastroProduto_Click);
            // 
            // consultaProduto
            // 
            this.consultaProduto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaProduto.Image = global::Projeto_controle_de_vendas.Properties.Resources._3440850_find_glass_magnifier_magnifying_search_icon;
            this.consultaProduto.Name = "consultaProduto";
            this.consultaProduto.Size = new System.Drawing.Size(184, 22);
            this.consultaProduto.Text = "Consulta de Produto";
            this.consultaProduto.Click += new System.EventHandler(this.consultaProduto_Click);
            // 
            // menuVenda
            // 
            this.menuVenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaVenda,
            this.historicoVenda});
            this.menuVenda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVenda.Image = global::Projeto_controle_de_vendas.Properties.Resources._299107_money_icon;
            this.menuVenda.Name = "menuVenda";
            this.menuVenda.Size = new System.Drawing.Size(72, 21);
            this.menuVenda.Text = "Venda";
            // 
            // novaVenda
            // 
            this.novaVenda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novaVenda.Image = global::Projeto_controle_de_vendas.Properties.Resources._6586120_add_buy_cart_ecommerce_shop_icon;
            this.novaVenda.Name = "novaVenda";
            this.novaVenda.Size = new System.Drawing.Size(179, 22);
            this.novaVenda.Text = "Nova Venda";
            this.novaVenda.Click += new System.EventHandler(this.novaVenda_Click);
            // 
            // historicoVenda
            // 
            this.historicoVenda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historicoVenda.Image = global::Projeto_controle_de_vendas.Properties.Resources._3440850_find_glass_magnifier_magnifying_search_icon;
            this.historicoVenda.Name = "historicoVenda";
            this.historicoVenda.Size = new System.Drawing.Size(179, 22);
            this.historicoVenda.Text = "Histórico de Vendas";
            this.historicoVenda.Click += new System.EventHandler(this.historicoVenda_Click);
            // 
            // menuConfig
            // 
            this.menuConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trocarDeUsuárioToolStripMenuItem,
            this.sairDoSistemaToolStripMenuItem});
            this.menuConfig.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuConfig.Image = global::Projeto_controle_de_vendas.Properties.Resources._49386_settings_icon;
            this.menuConfig.Name = "menuConfig";
            this.menuConfig.Size = new System.Drawing.Size(120, 21);
            this.menuConfig.Text = "Configurações";
            // 
            // trocarDeUsuárioToolStripMenuItem
            // 
            this.trocarDeUsuárioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trocarDeUsuárioToolStripMenuItem.Image = global::Projeto_controle_de_vendas.Properties.Resources._4850500_collaboration_communication_discussion_media_online_icon;
            this.trocarDeUsuárioToolStripMenuItem.Name = "trocarDeUsuárioToolStripMenuItem";
            this.trocarDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.trocarDeUsuárioToolStripMenuItem.Text = "Trocar de Usuário";
            this.trocarDeUsuárioToolStripMenuItem.Click += new System.EventHandler(this.trocarDeUsuárioToolStripMenuItem_Click);
            // 
            // sairDoSistemaToolStripMenuItem
            // 
            this.sairDoSistemaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairDoSistemaToolStripMenuItem.Image = global::Projeto_controle_de_vendas.Properties.Resources._330399_bad_cancel_clear_close_decline_icon;
            this.sairDoSistemaToolStripMenuItem.Name = "sairDoSistemaToolStripMenuItem";
            this.sairDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.sairDoSistemaToolStripMenuItem.Text = "Sair do Sistema";
            this.sairDoSistemaToolStripMenuItem.Click += new System.EventHandler(this.sairDoSistemaToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtData,
            this.toolStripStatusLabel3,
            this.txtHora,
            this.toolStripStatusLabel5,
            this.txtUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel1.Text = "Data Atual:";
            // 
            // txtData
            // 
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(118, 17);
            this.txtData.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel3.Text = "Hora Atual:";
            // 
            // txtHora
            // 
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(118, 17);
            this.txtHora.Text = "toolStripStatusLabel4";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel5.Text = "Usuário Logado:";
            // 
            // txtUser
            // 
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(118, 17);
            this.txtUser.Text = "toolStripStatusLabel6";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_controle_de_vendas.Properties.Resources.logo_pdmenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroCliente;
        private System.Windows.Forms.ToolStripMenuItem consultaCliente;
        private System.Windows.Forms.ToolStripMenuItem cadastroFuncionario;
        private System.Windows.Forms.ToolStripMenuItem consultaFuncionario;
        private System.Windows.Forms.ToolStripMenuItem cadastroFornecedor;
        private System.Windows.Forms.ToolStripMenuItem consultaFornecedor;
        private System.Windows.Forms.ToolStripMenuItem cadastroProduto;
        private System.Windows.Forms.ToolStripMenuItem consultaProduto;
        private System.Windows.Forms.ToolStripMenuItem novaVenda;
        private System.Windows.Forms.ToolStripMenuItem historicoVenda;
        private System.Windows.Forms.ToolStripMenuItem trocarDeUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairDoSistemaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel txtHora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        public System.Windows.Forms.ToolStripMenuItem menuCliente;
        public System.Windows.Forms.ToolStripMenuItem menuFuncionario;
        public System.Windows.Forms.ToolStripMenuItem menuFornecedor;
        public System.Windows.Forms.ToolStripMenuItem menuProduto;
        public System.Windows.Forms.ToolStripMenuItem menuVenda;
        public System.Windows.Forms.ToolStripMenuItem menuConfig;
        public System.Windows.Forms.ToolStripStatusLabel txtUser;
        private System.Windows.Forms.Timer timer1;
    }
}