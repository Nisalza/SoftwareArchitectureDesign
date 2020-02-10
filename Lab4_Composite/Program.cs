namespace Lab4_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component mainGrid = new Composite("Grid");
            Component searchGrid = new Composite("Grid");
            mainGrid.Add(searchGrid);
            Component searchTextBox = new Leaf("TextBox");
            searchGrid.Add(searchTextBox);
            Component searchButton = new Leaf("Button");
            searchGrid.Add(searchButton);
            Component productsStackPanel = new Composite("StackPanel");
            mainGrid.Add(productsStackPanel);
            Component addProductButton = new Leaf("Button");
            mainGrid.Add(addProductButton);
            Component exportProductsButton = new Leaf("Button");
            mainGrid.Add(exportProductsButton);
            Component binButton = new Leaf("Button");
            mainGrid.Add(binButton);
        }
    }
}
