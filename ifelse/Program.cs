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
            double fx = Math.Pow(x_,2);
            double q = Math.Max(fx + y_ + z_,x_*y_*z_) / Math.Min(fx  + y_ + z_,x_*y_*z_);
            Console.WriteLine("U = {0}",q);
        }
    }
}