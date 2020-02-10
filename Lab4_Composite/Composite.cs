using System.Collections.Generic;

namespace Lab4_Composite
{
    public class Composite : Component
    {
        public List<Component> Children { get; }

        public Composite(string name) : base(name)
        {
            Children = new List<Component>();
        }

        public override void Add(Component component)
        {
            Children.Add(component);
        }

        public override void Remove(Component component)
        {
            Children.Remove(component);
        }

        public override bool IsComposite()
        {
            return true;
        }
    }
}
