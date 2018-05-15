using System.Collections.Generic;

namespace VisitorPattern
{
    public class Person : IAsset
    {
        public List<IAsset> Assets = new List<IAsset>();

        public void Accept(IVisitor visitor)
        {
            foreach (var asset in Assets)
            {
                asset.Accept(visitor);
            }
        }
    }
}
