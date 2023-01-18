using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces.Interfaces
{
    public interface IVoar
    {
       public int AltitudeMaximaEmMetros { get; }
       public double VelocidadeVoo { get; }

        public void Voar() { }
        

    }
}
