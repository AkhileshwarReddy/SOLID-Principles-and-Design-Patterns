namespace LiskovSubstitutionPrinciple.Interfaces
{
    interface IMachine
    {
        void Print(Document document);
        void Scan(Document document);
        void Fax(Document document);
    }
}
