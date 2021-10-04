using LiskovSubstitutionPrinciple.Interfaces;
using System;

namespace LiskovSubstitutionPrinciple
{
    class OldFashionedPrinter : IMachine
    {
        public void Fax(Document document)
        {
            throw new NotImplementedException();
        }

        public void Print(Document document)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document document)
        {
            throw new NotImplementedException();
        }
    }
}
