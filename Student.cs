using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1._1b
{
    internal class Student:IEquatable<Student>, 
        IComparable<Student>
    {
        private int brIndeksa;
        public Dictionary<string, int> ocene 
            = new Dictionary<string, int>();
        public int BrIndeksa
        {
            get { return brIndeksa; }
            set { brIndeksa = value; }
        }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public int CompareTo(Student other)
        {
            return (this.Prezime + this.Ime)
                .CompareTo(other.Prezime + other.Ime);
        }

        public bool Equals(Student other)
        {
            return this.BrIndeksa.Equals(other.BrIndeksa);
        }

        public override string ToString()
        {
            return BrIndeksa + ": " + Ime + " " + Prezime;

        }
    }
}
