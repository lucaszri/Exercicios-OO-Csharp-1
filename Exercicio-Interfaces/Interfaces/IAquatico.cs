using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces.Interfaces
{
    public interface IAquatico
    {
       public bool ViveTerra { get; }
       public bool Mergulha { get; }
       public bool AguaDoce { get; }
    }
}
