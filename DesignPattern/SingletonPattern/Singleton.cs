using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Threading.Thread;

namespace SingletonPattern
{
    class Singleton
    {
        private static Singleton _firstInstance = null;

        private static string[] scrabbleLetters =
        {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U","V", "W", "X", "Y", "Z",
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U",
            "A", "B", "C", "D", "E", "F", "G", "H",  "R", "S", "T", "U","V", "W", "X", "Y", "Z",
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U","V", "W", "X", "Y", "Z",
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U","V", "W", "X", "Y", "Z",
            "A", "B", "C", "D", "E", "N", "O", "P", "Q", "R", "S", "T", "U","V", "W", "X", "Y", "Z"
        };

        private List<string> _letterList = new List<string>(scrabbleLetters.ToList());

        private static Boolean firstThread;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (_firstInstance == null)
            {
                if (firstThread)
                {
                    firstThread = false;
                    CurrentThread.Start();
                    Sleep(1000);
                }

                _firstInstance = new Singleton();
            }

            return _firstInstance;
        }

        public List<string> GetLetterList()
        {
            return _firstInstance._letterList;
        }

        public List<string> GetTiles(int howManyTiles)
        {
            List<string> tilesToSend = new List<string>();

            for (int i = 0; i <= howManyTiles; i++)
            {
                tilesToSend.Add(_firstInstance._letterList.);

                
            }

           return tilesToSend;
        }



    }
}
