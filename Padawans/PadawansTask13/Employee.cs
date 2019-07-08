namespace PadawansTask13
{
    class Employee
    {
        private string surname;
        private int age;

        public Employee()
        {
            surname = string.Empty;
            age = 20;
        }

        public Employee(string surname, int age)
        {
            this.surname = surname;
            this.age = age;
        }

        private string Age()
        {
            return age.ToString();
        }

        public void ChangeSurname(string newSurname)
        {
            surname = newSurname;
        }

        public string GetInfo()
        {
            return $"Surname: {surname}, Age: {age}";
        }
    }
}
