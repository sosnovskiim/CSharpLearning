namespace CSharpLearning.Task16
{
    abstract internal class Figure
    {
        abstract public double Area();
        abstract public double Perimeter();
        abstract public override bool Equals(object obj);
        abstract public override int GetHashCode();
        abstract public override string ToString();
    }
}
