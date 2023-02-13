namespace global
{
    class main{
        static void Main(string[] args) {
            double x_ = 0;
            double y_ = 0;
            double z_ = 0;
            Console.WriteLine("Введите x:");
            if(!double.TryParse(Console.ReadLine(), out x_)) {
                Console.WriteLine("{0} не число", x_);
            }
            Console.WriteLine("Введите y:");
            if(!double.TryParse(Console.ReadLine(), out y_)) {
                Console.WriteLine("{0} не число", y_);
            }
            Console.WriteLine("Введите z:");
            if(!double.TryParse(Console.ReadLine(), out z_)) {
                Console.WriteLine("{0} не число", z_);
            }
            double g1 = (Math.Pow(y_,x_+1)/(Math.Cbrt(Math.Abs(y_-2)) +3));
            double g2 = (x_ + y_/2)/(2*Math.Abs(x_+y_));
            double g3 = Math.Pow(x_+1,(-1/Math.Sin(z_)));
            Console.WriteLine("G = {0}",g1+g2*g3);
        }
    }
}