namespace CSharpLearning.Task21
{
    internal readonly struct CityLocation
    {
        public string Name { get; }
        public int X { get; }
        public int Y { get; }

        public CityLocation(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }
    }
}
