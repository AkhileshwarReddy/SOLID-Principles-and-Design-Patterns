using LiskovSubstitutionPrinciple.Interfaces;
using System;

namespace LiskovSubstitutionPrinciple.Printers
{
    class MultiFunctionMachine : IMultiFunctionDevice
    {
        private IPrinter _printer;
        private IScanner _scanner;

        public MultiFunctionMachine(IPrinter printer, IScanner scanner)
        {
            if(_printer == null)
            {
                throw new ArgumentNullException(nameof(_printer));
            }

            if (_scanner == null)
            {
                throw new ArgumentNullException(nameof(_scanner));
            }

            _printer = printer;
            _scanner = scanner;
        }

        public void Print(Document document)
        {
            _printer.Print(document);
        }

        public void Scan(Document document)
        {
            _scanner.Scan(document);
        }
    }
}
