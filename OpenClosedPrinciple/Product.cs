using System;
using static OpenClosedPrinciple.Constants;

namespace OpenClosedPrinciple
{
    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            if(name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            Color = color;
            Size = size;
        }
    }
}
