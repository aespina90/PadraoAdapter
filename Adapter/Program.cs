using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {

            //A sacada do Adapter é adaptar uma api ou sistema antigo do sistema,
            //para uma interface nova ou usual para sua necessidade.
            RelogioDoSistema data = new RelogioDoSistema();

            Console.WriteLine(data.hoje());
        }
    }
}
