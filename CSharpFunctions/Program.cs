/*
 In questo esercizio vi chiedo di definire qualche funzione di utilità 
che poi potete usare per poter fare operazioni complesse nei vostri programma principale.
Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:
void StampaArray(int[] array): che preso un array di numeri interi, stampa a video 
il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”. 
Potete prendere quella fatta in classe questa mattina :faccia_leggermente_sorridente:
int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca 
un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, 
e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca 
la somma totale di tutti gli elementi dell’array.
Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] 
già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
Stampare l’array di numeri fornito a video
Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato 
(Verificare che l’array originale non sia stato modificato, ristampo nuovamente l’array originale 
e verificando che sia rimasto [2, 6, 7, 5, 3, 9])
Stampare la somma di tutti i numeri
Stampare la somma di tutti i numeri elevati al quadrati
 */


//preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”.

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
    for(int i = 0; i < copiaArray.Length; i++)
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
    for(int i = 0; i < copiaArray.Length; i++)
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












int[] arrayNumeri = { 2, 6, 7, 5, 3, 9 };


Console.WriteLine("Stampa array");
stampaArray(arrayNumeri);

Console.WriteLine("Array al quadrato");
elevaArrayAlQuadrato(arrayNumeri);

Console.WriteLine("Somma degli elementi dell'array");
sommaElementiArray(arrayNumeri);

stampaArray(arrayNumeri);


Console.WriteLine("somma degli elementi dell'array al quadrato");
sommaDiElevamentoArray(arrayNumeri);


stampaArray(arrayNumeri);

