using System;

namespace CommandPrompt
{
    class Aplicacion
    {
        private Consola Consola = new Consola(@"C: \Users\Juan Pablo\Desktop\");

        public void Iniciar()
        {
            Console.WriteLine("Bienvenido a nuestra aplicación. \n Esta es una consola para explorar ficheros y hacer operaciones con los mismos. \n ");

            while(true)
            {
                Consola.Mostrar();
            }           
        }
    }
}
