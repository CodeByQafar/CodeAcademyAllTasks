namespace EmployeeManagementSystem_Exceptions
{
    public class NameEmptyException : Exception
    {
        public NameEmptyException(string message)
            : base(message)
        {
        }
    }
}