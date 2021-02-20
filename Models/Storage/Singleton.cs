using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomGenerics.Structures;
using Laboratorio_01_Implementación_y_análisis_de_estructuras__lineales;



namespace Laboratorio_01_Implementación_y_análisis_de_estructuras__lineales.Models.Storage
{
    public class Singleton
    {
        
       
    
        private readonly static Singleton _instance = new Singleton();
        public LinkedList<Jugadores> Ljugadores;
        public LinkedList<Jugadores> LArtesanalJ;
        public List<Jugadores> PlayerList;

        private Singleton()
        {
            Ljugadores = new LinkedList<Jugadores>();
            LArtesanalJ = new LinkedList<Jugadores>();
            PlayerList = new List<Jugadores>();
        }
        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }

        public delegate bool DelString(Jugadores val1, string Val2);
        public delegate int DelInt(Jugadores val1, int val2);

       public static bool CompareName(Jugadores val1, string val2)
        {
            if(val1.Name == val2)
            {
                return true;
            }
            return false;
        }
        public static bool ComparePosition(Jugadores val1, string val2)
        {
            if (val1.Pos == val2)
            {
                return true;
            }
            return false;
        }

        public static int CompareSalary(Jugadores val1, int val2)
        {
            if (val1.Salary > val2)
            {
                return 1;
            }
            else if (val1.Salary == val2)
            {
                return 0;
            }
            return -1;
        }

        public static bool CompareClub(Jugadores val1, string val2)
        {
            if (val1.Club == val2)
            {
                return true;
            }
            return false;
        }

        public static List<Jugadores> BuscarLArtesanal(string ValB, string R, DelString delString)
        {
            List<Jugadores> ListF = new List<Jugadores>();
            foreach (var item in Storage.Singleton.Instance.LArtesanalJ)
            {
                if(delString(item, ValB))
                {
                    ListF.Add(item);
                }
            }
            return ListF;
        }

        public static List<Jugadores> BuscarLArtesanalS(int ValB, string R, DelInt delInt)
        {
            List<Jugadores> ListF = new List<Jugadores>();
            foreach (var item in Storage.Singleton.Instance.LArtesanalJ)
            {
                switch(R)
                {
                    case "m":
                        if(delInt(item, ValB)<0)
                        {
                            ListF.Add(item);
                        }
                        break;
                    case "N":
                        if (delInt(item, ValB) == 0)
                        {
                            ListF.Add(item);
                        }
                        break;
                    case "M":
                        if (delInt(item, ValB) > 0)
                        {
                            ListF.Add(item);
                        }
                        break;

                }
            }
            return ListF;
        }

    }
}
