using System.Runtime.InteropServices;

namespace InterfaceExercicio
{
    public abstract class ArquivoBase
    {
        public virtual void Nome()
        {
            Console.WriteLine("Definir o nome do arquivo");
        }
    }
}
