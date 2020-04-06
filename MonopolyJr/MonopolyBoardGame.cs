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
        public static SpaceListClass spaceList = new SpaceListClass();

        private static string currentRecordFilePath = @"MonopolyBoard.txt";
        private static string currentCardFilePath = @"CardFile.txt";

        public static ReadFileClass readFile = new
            ReadFileClass(currentRecordFilePath);

        public static ReadFileClass readCardFile = new
            ReadFileClass(currentCardFilePath);
    }
}
