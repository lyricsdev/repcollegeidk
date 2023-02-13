// See https://aka.ms/new-console-template for more information
using Global;
using System.Collections;
namespace Global
{
    class main {
        public static Tasks taskig = new Tasks();
     
        static void Main(string[] args)
        {   
            foreach(taskDecide task in taskig.TaskList) {
                Console.WriteLine(string.Format("Задача id {0}",task.GetId()));

            }
           while(taskig.IsSelected() == false)
           {
            
            try
            {
                Console.WriteLine("Введите номер задачи:");
                string newtaskid = Console.ReadLine();
                taskig.Id = int.Parse(newtaskid);
                taskig.setSelect(true);

                if(taskig.isExist()) {
                    Console.WriteLine(String.Format("Вы выбрали задачу: {0}",taskig.Id));
                    taskig.GetTask().setDecide(true);
                } else {
                Console.WriteLine("Такой задачи не существует");
                    taskig.setSelect(false);
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
           }
            
        }
    }
}