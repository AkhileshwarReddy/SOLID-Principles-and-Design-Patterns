using System.Collections.Generic;

namespace DependencyInjectionPrinciple
{
    interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(Person parent);
        IEnumerable<Person> FindParentsOf(Person child);
    }
}
