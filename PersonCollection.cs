using System.Collections;
using System.Collections.Generic;

namespace OverloadOperator
{
    public class PersonCollection : IEnumerable
    {
        List<Person> arPeople = new List<Person>();
        public Person GetPerson(int pos) => (Person)arPeople[pos];

        public void AddPerson(Person p)
        { arPeople.Add(p); }

        public void ClearPeople()
        { arPeople.Clear(); }

        public int Count => arPeople.Count;
        IEnumerator IEnumerable.GetEnumerator() => arPeople.GetEnumerator();

        //добавим индексатор к существующему определению класса
        public Person this[int index]
        {
            get => (Person)arPeople[index];
            set => arPeople.Insert(index, value);
        }
    }
}
