using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestSortTableau
{
    class Personne:IComparable,IComparable<Personne>,ICloneable
    {
        int age;

        public Personne(int age)
        {
            this.age = age;
        }

        public Personne(Personne personneARecopier)
        {
            this.age = personneARecopier.age;
        }

        public object Clone()
        {
            return new Personne(this);
        }

        public int CompareTo(object obj)
        {
            Personne personneAComparer = obj as Personne;
            if (personneAComparer != null)
            {
                //if (this.age < personneAComparer.age)
                //{
                //    return -1;
                //}
                //else if (this.age > personneAComparer.age)
                //{
                //    return 1;
                //}
                //else if (this.age == personneAComparer.age)
                //{
                //    return 0;
                //}

                return this.age.CompareTo(personneAComparer.age);
            }
            else
            {

                throw new ArgumentException("Un objet de type Personne état attendu en argument", "obj");
            }

        }

        public int CompareTo(Personne other)
        {
            return this.age.CompareTo(other.age);
        }
    }
}
