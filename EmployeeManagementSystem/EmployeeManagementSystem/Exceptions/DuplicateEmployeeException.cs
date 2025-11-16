namespace EmployeeManagementSystem_Exceptions
{
    public class DuplicateEmployeeException : Exception
    {
  
        public DuplicateEmployeeException(string message)
            : base(message)
        {
        }
   
    }
}