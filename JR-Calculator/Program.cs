/*Dai input cate set-uri ai avut si el te intreaba cate secunde a durat fiecare set
La final converteste timpul total de sarit din secunde in minute*/

int setulCurent = 0;
int secundeTotale = 0;

Console.WriteLine("Cate seturi?");
int numarSeturi = Convert.ToInt32(Console.ReadLine());

// for loop care ruleaza pana cand i este egal cu numarul de seturi impus de user
/* spui programului cate secunde a durat set-ul
secundele fiecarui set se stocheaza in variabila "secunde"
in varibila "secundeTotale" se adauga valoare variabilei "secunde" dupa fiecare set*/
for (int i = 0; i < numarSeturi; i++)
{
    Console.WriteLine($"Cate secunde a durat set-ul {++setulCurent}?");
    int secunde = Convert.ToInt32(Console.ReadLine());
    secundeTotale += secunde;
}

float minute = secundeTotale / 60f; // converteste secunde in minute

Console.WriteLine($"Timp total de sarit: {minute} minute");