namespace Trabalho_Programação__Colections___Orientação_de_Objetos_
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGVListar = new System.Windows.Forms.DataGridView();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.tBoxValor = new System.Windows.Forms.TextBox();
            this.cBoxCategoria = new System.Windows.Forms.ComboBox();
            this.tBoxNome = new System.Windows.Forms.TextBox();
            this.tBoxID = new System.Windows.Forms.TextBox();
            this.lblMedida = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastrarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cBoxMedida = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVListar)).BeginInit();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGVListar
            // 
            this.dataGVListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVListar.Location = new System.Drawing.Point(330, 27);
            this.dataGVListar.Name = "dataGVListar";
            this.dataGVListar.Size = new System.Drawing.Size(458, 417);
            this.dataGVListar.TabIndex = 31;
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(190, 48);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(124, 28);
            this.btnRemover.TabIndex = 30;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(60, 382);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 28);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(60, 348);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(124, 28);
            this.btnCadastrar.TabIndex = 28;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // tBoxValor
            // 
            this.tBoxValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxValor.Location = new System.Drawing.Point(60, 266);
            this.tBoxValor.Name = "tBoxValor";
            this.tBoxValor.Size = new System.Drawing.Size(124, 22);
            this.tBoxValor.TabIndex = 26;
            // 
            // cBoxCategoria
            // 
            this.cBoxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxCategoria.FormattingEnabled = true;
            this.cBoxCategoria.Items.AddRange(new object[] {
            "Panificação",
            "Confeitaria",
            "Lanches",
            "Salgados",
            "Bebidas Geladas",
            "Bebidas Quentes"});
            this.cBoxCategoria.Location = new System.Drawing.Point(60, 215);
            this.cBoxCategoria.Name = "cBoxCategoria";
            this.cBoxCategoria.Size = new System.Drawing.Size(124, 24);
            this.cBoxCategoria.TabIndex = 25;
            // 
            // tBoxNome
            // 
            this.tBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNome.Location = new System.Drawing.Point(60, 160);
            this.tBoxNome.Name = "tBoxNome";
            this.tBoxNome.Size = new System.Drawing.Size(124, 22);
            this.tBoxNome.TabIndex = 24;
            // 
            // tBoxID
            // 
            this.tBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxID.Location = new System.Drawing.Point(60, 48);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(124, 22);
            this.tBoxID.TabIndex = 23;
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedida.Location = new System.Drawing.Point(57, 299);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(209, 16);
            this.lblMedida.TabIndex = 22;
            this.lblMedida.Text = "Informar Unidade de Medida:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(57, 247);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(105, 16);
            this.lblValor.TabIndex = 21;
            this.lblValor.Text = "Informar Valor";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(57, 196);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(140, 16);
            this.lblCategoria.TabIndex = 20;
            this.lblCategoria.Text = "Informar Categoria:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(57, 141);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(113, 16);
            this.lblNome.TabIndex = 19;
            this.lblNome.Text = "Informar Nome:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(57, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 16);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "ID:";
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarProdutosToolStripMenuItem,
            this.editarProdutosToolStripMenuItem,
            this.removerProdutosToolStripMenuItem,
            this.pesquisarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.MenuPrincipal.TabIndex = 16;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // cadastrarProdutosToolStripMenuItem
            // 
            this.cadastrarProdutosToolStripMenuItem.Name = "cadastrarProdutosToolStripMenuItem";
            this.cadastrarProdutosToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.cadastrarProdutosToolStripMenuItem.Text = "Cadastrar Produtos";
            this.cadastrarProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutosToolStripMenuItem_Click);
            // 
            // editarProdutosToolStripMenuItem
            // 
            this.editarProdutosToolStripMenuItem.Name = "editarProdutosToolStripMenuItem";
            this.editarProdutosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.editarProdutosToolStripMenuItem.Text = "Editar Produtos";
            this.editarProdutosToolStripMenuItem.Click += new System.EventHandler(this.editarProdutosToolStripMenuItem_Click);
            // 
            // removerProdutosToolStripMenuItem
            // 
            this.removerProdutosToolStripMenuItem.Name = "removerProdutosToolStripMenuItem";
            this.removerProdutosToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.removerProdutosToolStripMenuItem.Text = "Remover Produtos";
            this.removerProdutosToolStripMenuItem.Click += new System.EventHandler(this.removerProdutosToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem.Click += new System.EventHandler(this.pesquisarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cBoxMedida
            // 
            this.cBoxMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxMedida.FormattingEnabled = true;
            this.cBoxMedida.Items.AddRange(new object[] {
            "Quilo",
            "Unidade",
            "Cento"});
            this.cBoxMedida.Location = new System.Drawing.Point(60, 318);
            this.cBoxMedida.Name = "cBoxMedida";
            this.cBoxMedida.Size = new System.Drawing.Size(124, 24);
            this.cBoxMedida.TabIndex = 32;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(60, 76);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(124, 28);
            this.btnMostrar.TabIndex = 33;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(12, 110);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(233, 28);
            this.btnPesquisar.TabIndex = 34;
            this.btnPesquisar.Text = "Pesquisar Produtos";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.cBoxMedida);
            this.Controls.Add(this.dataGVListar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tBoxValor);
            this.Controls.Add(this.cBoxCategoria);
            this.Controls.Add(this.tBoxNome);
            this.Controls.Add(this.tBoxID);
            this.Controls.Add(this.lblMedida);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.MenuPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVListar)).EndInit();
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVListar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox tBoxValor;
        private System.Windows.Forms.ComboBox cBoxCategoria;
        private System.Windows.Forms.TextBox tBoxNome;
        private System.Windows.Forms.TextBox tBoxID;
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerProdutosToolStripMenuItem;
        private System.Windows.Forms.ComboBox cBoxMedida;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnPesquisar;
    }
}

