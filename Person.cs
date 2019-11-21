namespace OverloadOperator
{
    /// <summary>
    /// This class describes peoples cards entities.
    /// </summary>
    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName, string lastNmae, int age)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastNmae;
        }

        public override string ToString() => $"Name:{FirstName} {LastName}, Age: {Age}";

        public override bool Equals(object obj) => obj.ToString() == this.ToString();
        public override int GetHashCode() => this.ToString().GetHashCode();

        public static bool operator ==(Person p1, Person p2) => p1.Equals(p2);

        public static bool operator !=(Person p1, Person p2) => !p1.Equals(p2);

    }
}
