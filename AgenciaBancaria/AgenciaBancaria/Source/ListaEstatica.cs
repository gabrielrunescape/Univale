using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgenciaBancaria.Source {
    public class ListaEstatica {
        //Constantes
        public const int NULO = -1;
        public const int MAX = 30;
        
        //Dados
        public Caixa[] vetor;
        public int fim;
        
        // Inicializa a lista 
        public void Inicializar() {
            fim = NULO;
            vetor = new Caixa[MAX];
        }

        // Verifica se a lista está vazia 
        public bool Vazia() {
            return ((fim == NULO) ? true : false);
        }
        // funcao basica para inserir //
        public void Inserir(Caixa x, int i) {
            int j;
            for (j = fim + 1; j >= i + 1; j--) {
                vetor[j] = vetor[j - 1];
            }
            vetor[i] = x;
            fim = fim + 1;
        }

        //Elimina o elemento de indice i
        public void Excluir(int i) {
            int j;
            for (j = i; j <= fim - 1; j++) {
                vetor[j] = vetor[j + 1];
            }
            fim = fim - 1;
        }

        // Retorna a quantidade de elementos da lista
        public int Quant_elem() {
            return (fim + 1);
        }
        /// Retorna o conteúdo do elemento de índice i
        public Caixa Elemento(int i) {
            return (vetor[i]);
        }

        public int busca_bin(int chave) {
            int inf = 0, sup = fim, pos = -1, meio;
            while (inf <= sup) {
                meio = (inf + sup) / 2;
                if (vetor[meio].Número == chave) {
                    pos = meio;
                    inf = sup + 1;
                } else if (vetor[meio].Número < chave)
                    inf = meio + 1;
                else
                    sup = meio - 1;
            }
            return pos;
        }

        /*public void Quick() {
            Ordenar(vetor, 0, fim);
        }
        private void Ordenar(Caixa[] vetor, int inicio, int fim) {
            if (inicio < fim) {
                int posicaoPivo = Separar(vetor, inicio, fim);
                Ordenar(vetor, inicio, posicaoPivo - 1);
                Ordenar(vetor, posicaoPivo + 1, fim);
            }
        }
        private int Separar(Caixa[] vetor, int inicio, int fim) {
            Caixa pivo = vetor[inicio];
            int i = inicio + 1, f = fim;
            while (i <= f) {
                if (vetor[i].codigo <= pivo.codigo) {
                    i++;
                } else if (pivo.codigo < vetor[f].codigo) {
                    f--;
                } else {
                    Caixa troca = vetor[i];
                    vetor[i] = vetor[f];
                    vetor[f] = troca;
                    i++;
                    f--;
                }
            }
            vetor[inicio] = vetor[f];
            vetor[f] = pivo;
            return f;
        }*/
    }
}
