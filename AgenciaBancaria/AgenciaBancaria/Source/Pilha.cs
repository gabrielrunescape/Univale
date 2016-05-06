using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgenciaBancaria.Source {
    public class Pilha {
        //Constantes
        public const int NULO = -1;
        public const int MAX = 30;

        //Dados
        public Object[] vetor;
        public int topo;   //controle do elemento do topo

        /* Inicializa a pilha */
        public void FPVazia() {
            vetor = new Object[MAX];
            topo = NULO;
        }

        /* Verifica se a pilha está vazia */
        public bool Vazia() {
            return (topo == NULO);
        }

        // funcao verifica se pilha esta cheia
        public bool Cheia() {
            return (topo == MAX - 1);
        }

        // funcao basica para empilhar (push) //
        public void Empilha(Object x) {
            if (!Cheia()) {
                vetor[topo + 1] = x;
                topo = topo + 1;
            }
        }

        //Desempilha o elemento da lista (pop)
        public Object Desempilha() {
            Object aux = vetor[topo];
            topo = topo - 1;

            return (aux);
        }

        //Tamanho da pilha
        public int Tamanho() {
            return (topo + 1);
        }
    }
}
