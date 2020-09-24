namespace Prova_Programação__Colections___Orientação_de_Objetos_
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
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastrarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCadastrados = new System.Windows.Forms.Label();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.tBoxNomeProcurar = new System.Windows.Forms.TextBox();
            this.tBoxNome = new System.Windows.Forms.TextBox();
            this.cBoxCategoria = new System.Windows.Forms.ComboBox();
            this.tBoxValor = new System.Windows.Forms.TextBox();
            this.mTBoxData = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dataGVListar = new System.Windows.Forms.DataGridView();
            this.paginaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVListar)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginaInicialToolStripMenuItem,
            this.cadastrarProdutosToolStripMenuItem,
            this.editarProdutosToolStripMenuItem,
            this.removerProdutosToolStripMenuItem});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.MenuPrincipal.TabIndex = 0;
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
            // lblCadastrados
            // 
            this.lblCadastrados.AutoSize = true;
            this.lblCadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrados.Location = new System.Drawing.Point(206, 44);
            this.lblCadastrados.Name = "lblCadastrados";
            this.lblCadastrados.Size = new System.Drawing.Size(233, 25);
            this.lblCadastrados.TabIndex = 1;
            this.lblCadastrados.Text = "Informar Quantidade:";
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEditar.Location = new System.Drawing.Point(79, 85);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(210, 16);
            this.lblNomeEditar.TabIndex = 2;
            this.lblNomeEditar.Text = "Procurar Pelo Nome na Lista:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(79, 139);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(113, 16);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Informar Nome:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(79, 194);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(140, 16);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Informar Categoria:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(79, 245);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(105, 16);
            this.lblValor.TabIndex = 5;
            this.lblValor.Text = "Informar Valor";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(79, 297);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(184, 16);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Informar Data Fabricação";
            // 
            // tBoxNomeProcurar
            // 
            this.tBoxNomeProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNomeProcurar.Location = new System.Drawing.Point(82, 104);
            this.tBoxNomeProcurar.Name = "tBoxNomeProcurar";
            this.tBoxNomeProcurar.Size = new System.Drawing.Size(124, 22);
            this.tBoxNomeProcurar.TabIndex = 7;
            // 
            // tBoxNome
            // 
            this.tBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNome.Location = new System.Drawing.Point(82, 158);
            this.tBoxNome.Name = "tBoxNome";
            this.tBoxNome.Size = new System.Drawing.Size(124, 22);
            this.tBoxNome.TabIndex = 8;
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
            this.cBoxCategoria.Location = new System.Drawing.Point(82, 213);
            this.cBoxCategoria.Name = "cBoxCategoria";
            this.cBoxCategoria.Size = new System.Drawing.Size(124, 24);
            this.cBoxCategoria.TabIndex = 9;
            // 
            // tBoxValor
            // 
            this.tBoxValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxValor.Location = new System.Drawing.Point(82, 264);
            this.tBoxValor.Name = "tBoxValor";
            this.tBoxValor.Size = new System.Drawing.Size(124, 22);
            this.tBoxValor.TabIndex = 10;
            // 
            // mTBoxData
            // 
            this.mTBoxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTBoxData.Location = new System.Drawing.Point(82, 316);
            this.mTBoxData.Mask = "00/00/0000";
            this.mTBoxData.Name = "mTBoxData";
            this.mTBoxData.Size = new System.Drawing.Size(124, 22);
            this.mTBoxData.TabIndex = 11;
            this.mTBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(82, 356);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(124, 28);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(82, 390);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 28);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(212, 101);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(124, 28);
            this.btnRemover.TabIndex = 14;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // dataGVListar
            // 
            this.dataGVListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVListar.Location = new System.Drawing.Point(378, 108);
            this.dataGVListar.Name = "dataGVListar";
            this.dataGVListar.Size = new System.Drawing.Size(410, 330);
            this.dataGVListar.TabIndex = 15;
            // 
            // paginaInicialToolStripMenuItem
            // 
            this.paginaInicialToolStripMenuItem.Name = "paginaInicialToolStripMenuItem";
            this.paginaInicialToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.paginaInicialToolStripMenuItem.Text = "Pagina Inicial";
            this.paginaInicialToolStripMenuItem.Click += new System.EventHandler(this.paginaInicialToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGVListar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.mTBoxData);
            this.Controls.Add(this.tBoxValor);
            this.Controls.Add(this.cBoxCategoria);
            this.Controls.Add(this.tBoxNome);
            this.Controls.Add(this.tBoxNomeProcurar);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblNomeEditar);
            this.Controls.Add(this.lblCadastrados);
            this.Controls.Add(this.MenuPrincipal);
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerProdutosToolStripMenuItem;
        private System.Windows.Forms.Label lblCadastrados;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox tBoxNomeProcurar;
        private System.Windows.Forms.TextBox tBoxNome;
        private System.Windows.Forms.ComboBox cBoxCategoria;
        private System.Windows.Forms.TextBox tBoxValor;
        private System.Windows.Forms.MaskedTextBox mTBoxData;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView dataGVListar;
        private System.Windows.Forms.ToolStripMenuItem paginaInicialToolStripMenuItem;
    }
}

