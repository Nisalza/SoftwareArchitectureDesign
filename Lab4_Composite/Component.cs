using System;

namespace Lab4_Composite
{
    public abstract class Component
    {
        public string Name { get; private set; }

        protected Component(string name)
        {
            Name = name;
        }

        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
