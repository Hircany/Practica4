
using System; 
string Nombre;
            Console.WriteLine("Dame un Nombre :");
            Nombre = Console.ReadLine();
            string r = string.Join("Hircany", Nombre.ToArray());
            Console.WriteLine("Su Nombre Divido : " + r);
            