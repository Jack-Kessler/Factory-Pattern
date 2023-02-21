namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myStick = StickFactory.BuildStick();
            myStick.Shoot();
        }
    }
}
