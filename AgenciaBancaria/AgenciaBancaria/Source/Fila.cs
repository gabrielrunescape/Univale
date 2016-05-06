using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgenciaBancaria.Source {
    /// <summary>
    /// Classe do objeto Fila
    /// 
    /// É usado o algoritmo de fila dinámica para simular as
    /// Pessoas em uma fila bancária
    /// </summary>
    public class Fila {
        // Estrutura Fila
        public Cellule Frente;
        public Cellule Trás;
        public int tamanho;


        // Inicializa a Fila 
        public void FFVazia() {
            Frente = new Cellule();
            Trás = Frente;
            Frente.Suivant = null;
            tamanho = 0;
        }

        // Verifica se a fila está vazia
        public bool Vazia() {
            return Frente == Trás;
        }

        // funcao basica para enfileirar (entrar no final)//
        public void Enfileira(Pessoa info) {
            Trás.Suivant = new Cellule();
            Trás = Trás.Suivant;

            Trás.Information = info;
            Trás.Suivant = null;

            tamanho++;
        }

        //Desenfileira o elemento do inicio da fila
        public Object Desenfileira() {
            Cellule aux;

            if (Vazia() != true) {
                aux = Frente;
                Frente = Frente.Suivant;

                tamanho--;
                return Frente.Information;
            } else {
                return null;
            }
        }

        //Tamanho da Fila
        public int Tamanho() {
            return tamanho;
        }
    }
}
