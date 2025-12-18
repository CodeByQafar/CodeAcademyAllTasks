namespace EmployeeManagementSystem_Exceptions
{
    public class FileLoadException : Exception
    {
        public FileLoadException(string message)
            : base(message)
        {
        }
    }
}