namespace Lab4_Composite
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {

        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
