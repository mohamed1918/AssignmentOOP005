
namespace AssignmentOOP005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.WriteLine("Q1");
            IShape circle = new Circle(5);

            IShape rectagle = new Rectangle(5,10);

            circle.DisplayShapeInfo();
            rectagle.DisplayShapeInfo();
            #endregion
        }
    }
}
