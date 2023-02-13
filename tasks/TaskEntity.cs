namespace Global {
    class TaskEntity {
        private string name = "";
        public int id {get;set;} = 0;
        public TaskEntity(string name,int id) {
            this.id = id;
            this.name = name;
        }
        
    }
    partial class taskDecide : TaskEntity
    {
        private bool decided = false;
        public void deciding () {
            
        }
        public taskDecide(string name, int id) : base(name, id)
        {
        }
        public void setDecide(bool val) {
            Console.Write("Введите массу в кг:");
            string ans = Console.ReadLine();
            try
            {
                int massa = Convert.ToInt32(ans);
                Console.WriteLine("Ответ: {0} полных тон",massa/1000);
                this.decided = true;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Решение задачи не возможно");
                this.decided = false;

                throw;
            }
        }
        public int GetId() {
            return this.id;
        }
       
    }
}