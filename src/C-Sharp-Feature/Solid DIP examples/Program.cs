// https://code-maze.com/dependency-inversion-principle/



















//public class Employee
//{
//    public int ID { get; set; }
//    public string Name { get; set; }
//    public string Department { get; set; }
//    public int Salary { get; set; }
//}
//public class EmployeeBusinessLogic
//{
//    EmployeeDataAccess _EmployeeDataAccess;
//    public EmployeeBusinessLogic()
//    {
//        _EmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
//    }
//    public Employee GetEmployeeDetails(int id)
//    {
//        return _EmployeeDataAccess.GetEmployeeDetails(id);
//    }
//}



//public class DataAccessFactory
//{
//    public static EmployeeDataAccess GetEmployeeDataAccessObj()
//    {
//        return new EmployeeDataAccess();
//    }
//}

//public class EmployeeDataAccess
//{
//    public Employee GetEmployeeDetails(int id)
//    {
//        // In real time get the employee details from db
//        //but here we are hard coded the employee details
//        Employee emp = new Employee()
//        {
//            ID = id,
//            Name = "Pranaya",
//            Department = "IT",
//            Salary = 10000
//        };
//        return emp;
//    }
//}














//static void Main(string[] args)
//{



//    int[] arr = { 1, 2, 3, 4, 5 };

//    int target = 9;


//}

//public class Solution
//{
//    public int[] TwoSum(int[] nums, int target)
//    {

//        for (int i = 0; i < nums.Length; i++)
//        {
//            for (int j = i + 1; j < nums.Length; j++)
//            {
//                if (nums[i] + nums[j] == target)
//                {

//                    return new int[] { i, j };
//                }
//            }
//        }
//        return null;

//    }
//}


