using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS.Oid.DNA
{
    class Program
    {
        static void Main(string[] args)
        {
            NCL.CL _cl = new NCL.CL();
            int j = ((NCL.IDNA)_cl).DNA();      //   обращаемся к ДНК внешнего объекта
        }
    }
}

namespace NCA
{
    using NCL;

    public interface IDNA                       //  декларация тогоже интерфейса в другом пространстве имен, но с той же сигнатурой
    {                                           //  в качестве включаемого объекта 
        int DNA();                              //  таким образом извне разные программные модули видят один и тот же 
    }                                           //  интерфейс, относящийся к разным областям разрешения имен
}
