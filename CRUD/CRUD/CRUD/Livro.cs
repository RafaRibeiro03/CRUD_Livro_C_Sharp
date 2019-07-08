using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Livro
    {
        private int codigo;

        private String nome;

        private String autor;

        private int qtde_paginas;

        public Livro(int codigo, string nome, string autor, int qtde_paginas)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.autor = autor;
            this.qtde_paginas = qtde_paginas;
        }

        public int GetCodigo()
        {
            return this.codigo;
        }

        public void SetCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetAutor()
        {
            return this.autor;
        }

        public void SetAutor(string autor)
        {
            this.autor = autor;
        }

        public int GetQtde_Paginas()
        {
            return this.qtde_paginas;
        }

        public void SetQtde_Paginas(int qtde_paginas)
        {
            this.qtde_paginas = qtde_paginas;
        }

    }
}
