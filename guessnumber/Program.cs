namespace global
{
    class main{
        static int rnd = new Random().Next(0,100);
        static void Main(string[] args) {
            Console.WriteLine("Угадайте число :)");
            int tempval = 0;
            bool find = false;
            string input = "";
            int val;
            while(!find) {
                input = Console.ReadLine();
               if(int.TryParse(input,out val)) {
                        if(val == rnd) {
                            find = true;
                            Console.WriteLine("Угадали");
                            break;
                        }
                       if(val > rnd) {
                            Console.WriteLine("Слишком Горячо");
                            tempval = val;
                       } else {
                            Console.WriteLine("Слишком холодно");
                            tempval = val;
                       }
               } else {
                    Console.WriteLine("Напиши умоляю число");
               }
            }

        }
       

    }
}