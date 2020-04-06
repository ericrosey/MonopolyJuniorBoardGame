using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonopolyJr
{
    class MonopolyBoardGame
    {
        public static PlayerClass user = new PlayerClass();
        public static PlayerClass player2 = new PlayerClass();
        public static SpaceListClass spaceList = new SpaceListClass();
        public static SpaceClass space = new SpaceClass();

        public static bool turn;

        private static string currentRecordFilePath = @"MonopolyBoard.txt";


        public static ReadFileClass readFile = new
            ReadFileClass(currentRecordFilePath);

    }
}
