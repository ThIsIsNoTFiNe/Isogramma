# Isogramma
L'esercizio chiede, una volta data in ingresso una parola, se le lettere al suo interno ci si trovano lettere uguali. In caso ci siano lettere uguali ritorna ***false*** altrimenti ***true***. Ricorda che i segni e li spazi ripertuti sono ammessi.

# Spegazione passo a passo del problema:

Come prima cosa inizializziamo una variabile ***lung*** dal quale tramite la funzione ***.Lenght*** calcoliamo la lunquezza della stringa data in ingresso (***word***). Subito creiamo un for che cicli l'intera parola e che tramite la funzione ***.ToLower*** renda tutta la parola minuscola. Una volta fatto ciò tramite sempre un altro for, che scorrerà anche quest'ultimo l'intera lunghezza della stringa data. All'interno di quest'ultimo ci si troverà un if il quale controllera se la lettera della posizione corrente è uguale a uno spazio o ad un trattino (-), in caso questo sia  vero tramite la funzione ***continue*** salterà subito alla iterazione successiva. Nella successiva iterazione ci sarà ci sarà un for(int j) sempre annidato nel primo for (int i) che scorrerà l'intera lunghezza della stringa, partendo da una posizione in più della lettera precedente, controllando se le due lettere sono uguali tramite un ulteriore if annidato nel for. In caso sia vero ritornerà ***false*** e concluderà il programma in caso contrario continuerà con il primo for (int i) per verificare che le altre lettere non siano ripetute ulteriormente e concluderà riportando come detto all'inizio un ***true***

```C#
    public static class Isogramma
    {
        public static bool Verifica(string word)
        {

            int lung= word.Length;
            for (int i = 0; i < lung; i++)
            {
                word = word.ToLower();
            }

            for (int i = 0; i < lung; i++) {
                if (word[i] == ' ' || word[i] == '-') {
                continue;
                }
                for (int j = i + 1; j < lung; j++) {
                    if (word[i] == word[j]) {
                        return false;
                    }
                }
            }
            return true;
        }
    }

```
