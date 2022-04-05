/*
 Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile,
ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via.
A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti 
a mano dall’utente esternamente. Rieseguire il programma con l’input preso esternamente dall’utente.


 */

void stampaArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        Console.WriteLine(" elemento " + array[i]);
    }
}









//vi restituisca il quadrato del numero passato come parametro.

int quadrato(int numero)
{
    numero = (int)Math.Pow(numero, 2);
    Console.WriteLine("Il risultato del tuo numero elevato al quadrato è: " + numero);
    return numero;
}




//preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato

int[] elevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();
    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = quadrato(copiaArray[i]);

    }

    return copiaArray;
}



//preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

int sommaElementiArray(int[] array)
{
    int somma = 0;
    int[] copiaArray = (int[])array.Clone();
    for (int i = 0; i < copiaArray.Length; i++)
    {
        somma += copiaArray[i];

    }
    Console.WriteLine("Il risultato della somma di tutti gli elementi dell'array è: " + somma);
    return somma;
}



int sommaDiElevamentoArray(int[] array)
{

    array = elevaArrayAlQuadrato(array);
    int somma = sommaElementiArray(array);
    return somma;


}









Console.Write("Quanti elementi vuoi inserire nell'array? ");
int elementi = int.Parse(Console.ReadLine());


int[] array = new int[elementi];


for (int i = 0; i < array.Length; i++)
{
    Console.Write(" Elemento " + (i + 1) + " = ");

    int numeri = int.Parse(Console.ReadLine());
    array[i] = numeri;
}







Console.WriteLine("Stampa array");
stampaArray(array);

Console.WriteLine("Array al quadrato");
elevaArrayAlQuadrato(array);

Console.WriteLine("Somma degli elementi dell'array");
sommaElementiArray(array);


Console.WriteLine("somma degli elementi dell'array al quadrato");
sommaDiElevamentoArray(array);


stampaArray(array);
