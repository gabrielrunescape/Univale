using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace AgenciaBancaria.Source {
    public class Caixa {
        public Fila Fila;
        public int Número;
        public double Pagar;
        public double Receber;
        public Pilha Atendimentos;

        public void IniciarCaixa(int id, double pgmts, double rcbmts) {
            Número = id;
            Pagar = pgmts;
            Receber = rcbmts;

            Fila = new Fila();
            Fila.FFVazia();

            Atendimentos = new Pilha();
            Atendimentos.FPVazia();
        }
    }
}
