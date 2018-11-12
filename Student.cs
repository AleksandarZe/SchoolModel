namespace MultipleClasses
{
    public class Student
    {
        private string firstName;
        private string lastName;

        public string Name
        {
            get { return this.firstName + " " + this.lastName; }
        }

        public Student(string firstName,string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
