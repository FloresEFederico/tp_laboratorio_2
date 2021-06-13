using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface IBugs
    {
        int BugsDeFabrica { get; }

        int CalcularBugs();

        bool FixearBugs();
    }
}
