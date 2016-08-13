using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgenciaBancaria.Source {
    public class Lista {
        // Estruta da Lista
        public Cellule Primeiro;
        public int tamanho;

        // Inicia a Lista
        public void Inicializar() {
            Primeiro = null;
            tamanho = 0;
        }

        // Verifica se a lista é vazia ou não
        public bool Vazia() {
            return Primeiro == null;
        }

        // Insere um elemento no início da lista
        public void Inserir(Caixa info) {
            Cellule aux = new Cellule();
            
            aux.Information = info;
            aux.Suivant = Primeiro;
            Primeiro = aux;

            tamanho++;
        }

        // Busca um elemento através de seu indíce
        /*public void Inserir_Posição(int pos, Caixa info) {
            Cellule cell;
            cell = Primeiro;

            int posição = 0;

            while ((cell != null) && (posição < pos)) {
                cell = cell.Suivant;
                posição++;
            }

            if (cell != null) {
                cell.Information;
            } else {
                null;
            }
        }*/

        // Exclui o primeiro elemento da lista 
        public void Excluir() {
            Cellule cell;
            cell = Primeiro;
            Primeiro = Primeiro.Suivant;

            tamanho--;
        }

        // Retorna o número de elementos que existem na lista
        public int Quantidade() {
            return tamanho;
        }

        // Retorna o primeiro elemento da lista
        public Object Inicial() {
            if (Primeiro != null) {
                return Primeiro.Information;
            } else {
                return null;
            }
        }

        // Busca um elemento através de seu indíce
        public Object Elemento(int pos) {
            Cellule cell;
            cell = Primeiro;

            int posição = 0;

            while ((cell != null) && (posição < pos)) {
                cell = cell.Suivant;
                posição++;
            }

            if (cell != null) {
                return cell.Information;
            } else {
                return null;
            }
        }
    }
}
