using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.tabuleiro
{
    class Peca
    {
        public posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qntdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }
        public Peca(posicao posicao, Tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qntdMovimentos = 0;
        }

    }
}
