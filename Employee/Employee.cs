namespace Employee {
    class Employee{

        public delegate void LogMessageDelegate(string methodName);
        public Employee(int Id, string Name, string DepartmentName)
        {
            this.Id = Id;
            this.Name = Name;
            this.DepartmentName = DepartmentName;
        }

        // Method to print User Id
        public int GetId(){
            LogMethodCalled("GetId()");
            return this.Id;
        }

        // Overloaded method to update user Id
        public void GetId(int userId){
            this.Id = userId;
        }

        // Method to print User Name
        public string GetName(){
            LogMethodCalled("GetName()");
            return this.Name;
        }
        // Overloaded method to update user name
        public void GetName(string name){
            this.Name = name;
        }

        // Method to print Department Name
        public string GetDepartmentName(){
            LogMethodCalled("GetDepartmentName()");
            return this.DepartmentName;
        }

        // Overloaded method to update department name
        public void GetDepartmentName(string name){
            this.DepartmentName = name;
        }

        public event LogMessageDelegate LogMethodCalled;
        private int Id;
        private string Name;
        private string DepartmentName;
    }
}