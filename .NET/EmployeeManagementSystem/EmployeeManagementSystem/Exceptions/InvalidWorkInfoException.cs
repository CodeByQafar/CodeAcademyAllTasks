namespace EmployeeManagementSystem_Exceptions
{
    public class InvalidWorkInfoException : Exception
    {
        public InvalidWorkInfoException(string message)
            : base(message)
        {
        }
    }
}