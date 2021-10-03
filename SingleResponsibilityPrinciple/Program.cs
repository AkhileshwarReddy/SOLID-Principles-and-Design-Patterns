namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var journal = new Journal();
            journal.AddEntry("I cried today");
            journal.AddEntry("I ate bug");

            var persistence = new Pesistence();
            var filename = @"c:/temp/journal.txt";
            persistence.SaveToFile(journal, filename, true);
        }
    }
}
