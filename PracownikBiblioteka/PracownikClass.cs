using System;
using System.Collections;
using System.Collections.Generic;

namespace PracownikBiblioteka
{
    public interface IPracownik
    {
        public void Add(IPracownik p);
        public string WyswietlInformacje();
        public int Count();
    }
    public class Pracownik : IPracownik
    {
        private string name;
        public Pracownik(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }

        public void Add(IPracownik p)
        {
            return;
        }
        public string WyswietlInformacje()
        {
            return GetName();
        }
        public int Count()
        {
            return 1;
        }
    }
    public class Kierownik : IPracownik, IEnumerable<IPracownik>
    {
        private List<IPracownik> pracownicy = new List<IPracownik>();
        private string name;
        public Kierownik(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }

        public void Add(IPracownik p)
        {
            pracownicy.Add(p);
        }
        public string WyswietlInformacje()
        {
            int i = 0;
            string result = GetName() + ":(";
            foreach (IPracownik p in pracownicy)
            {
                result += p.WyswietlInformacje();
                if (i != pracownicy.Count - 1)
                {
                    result += " + ";
                }
                i++;
            }
            return result + ")";
        }

        public int Count()
        {
            int count = 1;
            foreach (IPracownik p in pracownicy)
            {
                count += p.Count();
            }
            return count;
        }

        public IEnumerator<IPracownik> GetEnumerator()
        {
            return pracownicy.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return pracownicy.GetEnumerator();
        }
    }
}
