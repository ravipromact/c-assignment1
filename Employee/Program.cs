namespace Employee {
    class Program{
        static void Main() {
            var userId = EnterUserID();
            var userName = EnterUserName();
            var departmentName = EnterDepartmentName();
            var emp = new Employee(int.Parse(userId),userName,departmentName);
            emp.LogMethodCalled += LogMessage;
            // Print user input for emp details
            Console.WriteLine("User Id: " + emp.GetId());
            Console.WriteLine("User Name: " + emp.GetName());
            Console.WriteLine("Department Name: " + emp.GetDepartmentName());

            // Update user detail using method overloading and print output
            emp.GetId(344);
            emp.GetName("John Doe");
            emp.GetDepartmentName("QA Department");
            Console.WriteLine("Updated User Id: " + emp.GetId());
            Console.WriteLine("Updated User Name: " + emp.GetName());
            Console.WriteLine("Updated Department Name: " + emp.GetDepartmentName());
        }

        static string EnterUserID(){
            string id;
            while(true){
                Console.WriteLine("Enter user Id");
                var input = Console.ReadLine();
                if(!string.IsNullOrEmpty(input)){
                    id = input;
                    break;
                }
            }
            return id;
        }
        static string EnterUserName(){
            string userName;
            while(true){
                Console.WriteLine("Enter user name");
                var input = Console.ReadLine();
                if(!string.IsNullOrEmpty(input)){
                    userName = input;
                    break;
                }
            }
            return userName;
        }
        static string EnterDepartmentName(){
            string department;
            while(true){
                Console.WriteLine("Enter department name");
                var input = Console.ReadLine();
                if(!string.IsNullOrEmpty(input)){
                    department = input;
                    break;
                }
            }
            return department;
        }

        static void LogMessage(string methodName){
            Console.WriteLine($"{methodName} method called");
        }
    }
}
