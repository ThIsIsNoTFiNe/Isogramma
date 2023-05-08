using System;
using System.Linq;

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
                continue;  // Salta alla iterazione dopo senza finire la corrente.
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

