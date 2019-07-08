using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD
{
    public partial class CRUD : Form
    {

        private String connectionString = "Server=.;Database=bd_livro;User Id=sa;Password=epilef;";

        enum enGrid{enCodigo, enNome, enAutor, enQtde_Paginas};

        public CRUD()
        {
            InitializeComponent();
        }

        private void GravarAlterar(Livro livro)
        {
            string sql = string.Empty;

            if(livro.GetCodigo() == 0)
            {
                sql = "INSERT INTO Livro (Nome, Autor, Qtde_Paginas) " +
                    "VALUES(@Nome, @Autor, @Qtde_Paginas)";
            }
            else
            {
                sql = "UPDATE Livro SET Nome = @Nome, Autor = @Autor, Qtde_Paginas = @Qtde_Paginas " +
                    "WHERE Codigo = @Codigo";
            }

            SqlConnection conexao = new SqlConnection(this.connectionString);
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@Codigo", livro.GetCodigo());
            comando.Parameters.AddWithValue("@Nome", livro.GetNome());
            comando.Parameters.AddWithValue("@Autor", livro.GetAutor());
            comando.Parameters.AddWithValue("@Qtde_Paginas", livro.GetQtde_Paginas());
            comando.CommandType = CommandType.Text;
            conexao.Open();

            try
            {
                int i = comando.ExecuteNonQuery();
                if (i > 0)
                {
                    txtCodigo.Focus();
                    MessageBox.Show("Registro gravado com sucesso!");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void TxtCodigo_LostFocus(object sender, EventArgs e)
        {
            if(txtCodigo.Text.Trim() != "" && txtNome.Text.Trim() == "")
            {
                for (int i = 0; i < grdLivros.RowCount; i++)
                {
                    int codigoGrade = Convert.ToInt32("0" + grdLivros.Rows[i].Cells[(int) enGrid.enCodigo].Value.ToString());
                    if (Convert.ToInt32("0" + txtCodigo.Text) == codigoGrade)
                    {
                        txtNome.Text = grdLivros.Rows[i].Cells[(int) enGrid.enNome].Value.ToString();
                        txtAutor.Text = grdLivros.Rows[i].Cells[(int) enGrid.enAutor].Value.ToString();
                        txtQtdePaginas.Text = grdLivros.Rows[i].Cells[(int) enGrid.enQtde_Paginas].Value.ToString();
                    }
                }
                if(txtNome.Text.Trim() != "")
                {
                    HabilitaCampos(false);
                    btnAlterar.Focus();
                }
            }
        }

        private void TxtCodigo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitaCampos(true);
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                int codigo = Convert.ToInt32("0" + txtCodigo.Text);
                string nome = txtNome.Text;
                string autor = txtAutor.Text;
                int qtde_paginas = Convert.ToInt32("0" + txtQtdePaginas.Text);

                Livro livro = new Livro(codigo, nome, autor, qtde_paginas);

                GravarAlterar(livro);
                LimparCampos();
                CarregarGrid();
            }
        }

        private void LimparCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtAutor.Text = "";
            txtQtdePaginas.Text = "";
        }

        private void HabilitaCampos(Boolean flag)
        {
            txtNome.Enabled = flag;
            txtAutor.Enabled = flag;
            txtQtdePaginas.Enabled = flag;

            btnGravar.Enabled = flag;
            btnAlterar.Enabled = !flag;
            btnExcluir.Enabled = !flag;
        }

        private Boolean ValidarCampos()
        {
            Boolean Tudo_Validado = false;

            if (txtNome.Text.Trim() != "")
            {
                if (txtAutor.Text.Trim() != "")
                {
                    if (txtQtdePaginas.Text.Trim() != "")
                    {
                        Tudo_Validado = true;
                    }
                    else
                    {
                        MessageBox.Show("Informe a quantidade de páginas do livro!");
                    }
                }
                else
                {
                    MessageBox.Show("Informe o Autor do livro!");
                }
            }
            else
            {
                MessageBox.Show("Informe o Nome do livro!");
            }

            return Tudo_Validado;
        }

        private void CarregarGrid()
        {
            string sql = "SELECT Codigo, Nome, Autor, Qtde_Paginas FROM Livro";
            SqlConnection conexao = new SqlConnection(this.connectionString);
            SqlCommand comando = new SqlCommand(sql, conexao);
            conexao.Open();

            try
            {
                SqlDataReader dr = comando.ExecuteReader();

                grdLivros.Rows.Clear();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        grdLivros.Rows.Add(new DataGridViewRow());
                        grdLivros.Rows[grdLivros.RowCount - 1].Cells[(int) enGrid.enCodigo].Value = dr["Codigo"];
                        grdLivros.Rows[grdLivros.RowCount - 1].Cells[(int)enGrid.enNome].Value = dr["Nome"];
                        grdLivros.Rows[grdLivros.RowCount - 1].Cells[(int)enGrid.enAutor].Value = dr["Autor"];
                        grdLivros.Rows[grdLivros.RowCount - 1].Cells[(int)enGrid.enQtde_Paginas].Value = dr["Qtde_Paginas"];
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            grdLivros.AllowUserToAddRows = false;
            LimparCampos();
            HabilitaCampos(true);
            CarregarGrid();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            HabilitaCampos(true);
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Excluir(Convert.ToInt32(txtCodigo.Text));
            LimparCampos();
            HabilitaCampos(true);
            CarregarGrid();
        }

        private void Excluir(int codigo)
        {
            string sql = "DELETE FROM Livro WHERE Codigo = @Codigo";
            SqlConnection conexao = new SqlConnection(this.connectionString);
            SqlCommand comando = new SqlCommand(sql,conexao);

            comando.Parameters.AddWithValue("@Codigo", codigo);

            conexao.Open();

            try
            {
                int i = comando.ExecuteNonQuery();
                if(i > 0)
                {
                    txtCodigo.Focus();
                    MessageBox.Show("Registro excluído com sucesso!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
