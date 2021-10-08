using System;
using System.Collections.Generic;
using System.Linq;
using static DependencyInjectionPrinciple.Constants;

namespace DependencyInjectionPrinciple
{
    class Relationships : IRelationshipBrowser
    {
        private List<Tuple<Person, Relationship, Person>> relations = new List<Tuple<Person, Relationship, Person>>();

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add(new Tuple<Person, Relationship, Person>(parent, Relationship.Parent, child));
            relations.Add(new Tuple<Person, Relationship, Person>(child, Relationship.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(Person parent)
        {
            foreach (var relation in relations.Where(x => x.Item1.Name == parent.Name && x.Item2 == Relationship.Parent))
            {
                yield return relation.Item3;
            }
        }

        public IEnumerable<Person> FindParentsOf(Person child)
        {
            foreach (var relation in relations.Where(x => x.Item1.Name == child.Name && x.Item2 == Relationship.Child))
            {
                yield return relation.Item3;
            }
        }

        public List<Tuple<Person, Relationship, Person>> Relations => relations;
    }
}
