using System;

namespace DependencyInjectionPrinciple
{
    class Research
    {
        public Research(IRelationshipBrowser browser)
        {
            foreach (var person in browser.FindAllChildrenOf(new Person { Name = "John" }))
            {
                Console.WriteLine($"John has a child called {person.Name}");
            }
        }
    }
}
