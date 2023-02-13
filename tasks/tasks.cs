using System.Collections;

namespace Global {
    class Tasks {
        private int id = 0;
        private bool exist = false;
        public ArrayList TaskList = new ArrayList();
        private bool selected = false;
        public Tasks() {
            taskDecide task15 = new taskDecide("123",15);
            
            TaskList.Add(task15);
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public bool isExist() {
            if(this.selected.Equals(true)) {
                foreach (taskDecide task in TaskList) {
                    Console.WriteLine("Задача:" + this.id);
                    if(task.GetId() == this.id) {
                        setExist(true);
                    } else {
                        setExist(false);
                    }
                 } 
            }
            return this.exist;
        }
        public void setExist(bool val) {
            this.exist = val;
        }
        public taskDecide? GetTask() {
            
            if(this.selected.Equals(true)) {
                foreach (taskDecide task in TaskList) {
                    if(this.id == task.GetId()) {
                        return task;
                    } else {
                        return null;
                    }
                } 
            } 
            return null;
        }
        public bool IsSelected() { return this.selected;}
        public void setSelect(bool val) {
            this.selected = val;
        }
        
    }
}