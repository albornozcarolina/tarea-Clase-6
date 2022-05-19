//Generar un número secreto aleatorio con la siguiente instruccion:
 //Genera un numero entero aleatorio de 1 a 20 */

int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);

//Pedir al usuario que ingrese un número y que intente adivinar el número que eligió la computadora.
Console.WriteLine("intenta adivinar el N° que eligio la computadora, Pista... es del 1 al 20");
Console.Write("Por favor ingresa el N°: ");  
int userNumber = int.Parse(Console.ReadLine());

//   declar. cond      paso
for (int i = 1; i < 20; i++)
{
    if (numeroSecreto == userNumber)
    {
        Console.WriteLine("Muy bien adivinaste ! en el " + i + "° intento");
        break;
    }
    else if (numeroSecreto < userNumber)
    {
        Console.WriteLine("El numero secreto es menor al que elegiste");
        Console.WriteLine("Intentalo otra vez... ");    
        userNumber = int.Parse(Console.ReadLine());
    }
    else if (numeroSecreto > userNumber)
    {
        Console.WriteLine("El numero secreto es mayor al que elegiste, intentalo de nuevo");
        Console.WriteLine("Intento número: " + i);
        userNumber = int.Parse(Console.ReadLine());
    }

}




