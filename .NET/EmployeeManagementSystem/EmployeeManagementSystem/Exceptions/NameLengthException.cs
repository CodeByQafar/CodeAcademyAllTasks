namespace EmployeeManagementSystem_Exceptions
{
    public class NameLengthException : Exception
    {
        public NameLengthException(string message)
            : base(message)
        {
        }
    }
}