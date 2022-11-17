namespace DW_Test.HashModels
{
    public class Student
    {
        public string StudentID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public int GPA { get; set; }

        public string key;

        public string getKey()
        {
            key = StudentID;

            return key.GetHashCode().ToString();
        }

        public void setKey(string key)
        {
            this.key = key;
        }

        public string value;

        public string getValue()
        {
            value = Name + "_" + Age + "_" + GPA;

            return value.GetHashCode().ToString();
        }

        public void setValue(string value)
        {
            this.value = value;
        }

        public void update(Student student)
        {
            StudentID = student.StudentID;
            Name = student.Name;
            Age = student.Age;
            GPA = student.GPA;
            key = student.key;
            value = student.value;
        }
    }
}
