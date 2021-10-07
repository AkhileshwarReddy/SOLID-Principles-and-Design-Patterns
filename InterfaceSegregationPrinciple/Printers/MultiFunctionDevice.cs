using System;
using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple.Printers
{
    class MultiFunctionDevice : IMultiFunctionDevice
    {
        private IPrinter _printer;
        private IScanner _scanner;

        public MultiFunctionDevice(IPrinter printer, IScanner scanner)
        {
            if (printer == null)
            {
                throw new ArgumentNullException(nameof(printer));
            }

            if (scanner == null)
            {
                throw new ArgumentNullException(nameof(scanner));
            }

            _printer = printer;
            _scanner = scanner;
        }
        public void Print(Document doc)
        {
            _printer.Print(doc);
        }

        public void Scan(Document doc)
        {
            _scanner.Scan(doc);
        }
    }
}
