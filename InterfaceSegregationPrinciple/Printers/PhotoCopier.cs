using InterfaceSegregationPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Printers
{
    class PhotoCopier : IPrinter, IScanner
    {
        public void Print(Document doc)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document doc)
        {
            throw new NotImplementedException();
        }
    }
}
