using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace List_colection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _exit = "/";
            string _slovo = "";
            Shifer Code = new Shifer();
            DeShifer DCode = new DeShifer();
            while (true) {
                Console.WriteLine("//Ваше слово://--------------------------------------------------------------------------");
                _slovo = Console.ReadLine();
                if (_exit == _slovo) { break; }
                string slovoshifer = Code.CreateCode(_slovo);
                Console.WriteLine("//DeCoding//-----------------------------------------------------------------------------");
                DCode.CreateDeCode(slovoshifer);
                Console.WriteLine("//=======================================================================================");
            }
            //Console.ReadKey();

        }
    }

    class Alphavite
    {
        private string[] Nabor = new string[] 
        {
            "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ",
            "абвгдежзийклмнопрстуфхцчшщъыьэюя",
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ", 
            "abcdefghijklmnopqrstuvwxyz"
        };
        public Dictionary<char, char> alpha = new Dictionary<char, char>()
        {
            {'Ё',  'Ё'},
            {'ё',  'ё'},
            {' ',  ' '}
        };

        public Alphavite() { }

        public void initial()
        {
            foreach(string Nabor_bukv in Nabor)
            {
                int Leng = Nabor_bukv.Length;
                int L_two = Leng / 2;

                for(int i = 0; i < L_two; i++)
                {
                    alpha.Add(Nabor_bukv[i+L_two], Nabor_bukv[i]);
                }
                for (int i = L_two; i < Leng; i++)
                {
                    alpha.Add(Nabor_bukv[i - L_two], Nabor_bukv[i]);
                }
            }
            //foreach(KeyValuePair<char, char> keyValue in alpha) { Console.WriteLine(keyValue.Key + " - " + keyValue.Value); }

        }
    }

    class Shifer 
    {
        protected string n;
        protected string newcode;
        public Alphavite Code = new Alphavite();
        
        

        public Shifer() 
        {
            
            string n = "";
            string newcode = "";
            Code.initial();

        }

        public string CreateCode(string _n)
        {

            Console.WriteLine("//Codirovanie//--------------------------------------------------------------------------");
            string n = _n;

            string newcode = "";

            foreach (char bukva in n)
            {
                newcode += Code.alpha[bukva];
            }
            Dis(newcode);
            return newcode;
        }

        public virtual void Dis(string newcode)
        {
            Console.WriteLine(newcode);
        }
       
    }

    class DeShifer : Shifer
    {
        protected string newcode;
        protected string n;

        public DeShifer()
        {
            string n = "";
            string newcode = "";
        }

        public string CreateDeCode(string _n)
        {
            string n = _n;
            string newcode = "";

            foreach (char bukva in n)
            {
                newcode += Code.alpha[bukva];
            }
            Dis(newcode);
            return newcode;
        }

        public virtual void Dis(string newcode)
        {
            Console.WriteLine(newcode);
        }
    }
}
