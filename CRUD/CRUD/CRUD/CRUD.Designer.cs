namespace CRUD
{
    partial class CRUD
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtQtdePaginas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grdLivros = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde_Paginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(20, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(40, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Click += new System.EventHandler(this.TxtCodigo_Click);
            this.txtCodigo.LostFocus += new System.EventHandler(this.TxtCodigo_LostFocus);
            // 
            // txtQtdePaginas
            // 
            this.txtQtdePaginas.Location = new System.Drawing.Point(404, 28);
            this.txtQtdePaginas.Name = "txtQtdePaginas";
            this.txtQtdePaginas.Size = new System.Drawing.Size(35, 20);
            this.txtQtdePaginas.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Qtde. páginas:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(255, 28);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(133, 20);
            this.txtAutor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Autor:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(76, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(173, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome:";
            // 
            // grdLivros
            // 
            this.grdLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Autor,
            this.Qtde_Paginas});
            this.grdLivros.Location = new System.Drawing.Point(22, 68);
            this.grdLivros.Name = "grdLivros";
            this.grdLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLivros.Size = new System.Drawing.Size(455, 85);
            this.grdLivros.TabIndex = 5;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 45;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 150;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.Width = 150;
            // 
            // Qtde_Paginas
            // 
            this.Qtde_Paginas.HeaderText = "Qt. p";
            this.Qtde_Paginas.Name = "Qtde_Paginas";
            this.Qtde_Paginas.Width = 60;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(242, 170);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(404, 170);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(323, 170);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 205);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.grdLivros);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQtdePaginas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Name = "CRUD";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.CRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtQtdePaginas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grdLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde_Paginas;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
    }
}

