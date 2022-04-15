using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacionUsuario35
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            Validador.Bienvenida();

            int numero = Validador.PedirInt("\n Ingrese un número");

            Console.Clear();
            Console.WriteLine("\n El número ingresado fue *" + numero + "*.");

            Validador.Despedida();

        }
       
        public void Iniciar()
        {
            MenuPrincipal();
        }


    }
}
