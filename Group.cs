using System.Collections.Generic;
using System.Text;

namespace MultipleClasses
{
    public class Group
    {
       public string name { get; set; }
        public List<Student> Students { get; set; }
        public Teacher Teacher { get; set; }

        public Group(string name)
        {
            this.name = name;
            this.Students = new List<Student>();


        }
        public override string ToString()
        {
            StringBuilder groupAsString = new StringBuilder();
            groupAsString.AppendLine("Group: "+this.name);
            groupAsString.AppendLine("Students of this group: " + string.Join(", ",
                this.Students.Select(x => x.Name)));
            if (this.Teacher != null)
            {
                groupAsString.Append("Teacher: " + this.Teacher.Name);
            }
            return groupAsString.ToString();
        }

    }
}
