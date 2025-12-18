using EmployeeManagementSystem_Exceptions;


namespace EmployeeManagementSystem_Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name{ get; set; }

        public Person(int id, string name)
        {
            Id = id;
            if (string.IsNullOrEmpty(name))
            {
                throw new NameEmptyException("Name can't be null");
            }
            else if (name.Length < 3 || name.Length > 25)
            {
                throw new NameLengthException("Name must contain 3-25 character");
            }
            else
            {
                Name = name;
            }


        }


    }
}
