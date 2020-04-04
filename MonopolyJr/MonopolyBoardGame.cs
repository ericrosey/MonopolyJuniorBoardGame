using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyJr
{
    class MonopolyBoardGame
    {
        public static PlayerClass user = new PlayerClass();

        private static string currentRecordFilePath = @"C:\Users\maxro\Desktop\monopolyjr\MonopolyBoard.txt";


        public static ReadFileClass readFile = new
            ReadFileClass(currentRecordFilePath);
    }
}
