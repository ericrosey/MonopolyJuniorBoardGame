using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonopolyJr
{
    class SpaceListClass
    {
        private SpaceClass Space = new SpaceClass();
        private int index;

        private List<SpaceClass> InternalList;

        public SpaceListClass()
        {
            InternalList = new List<SpaceClass>(24);
        }
        
        public Boolean initializeEntireList()
        {
            string nextSpace;
            Boolean isEndOfFile = true;
            Boolean success;
            int countSpaces = 0;

            nextSpace = MonopolyBoardGame.readFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                countSpaces++;
                SpaceClass space = new SpaceClass();
                success = space.createSpaceObject(nextSpace);
                if(success != true)
                {
                    MessageBox.Show("unable to create spaceObject");
                    return false;
                }
                InternalList.Add(space);
                nextSpace = MonopolyBoardGame.readFile.getNextRecord(ref isEndOfFile);
                
            }
            if (countSpaces > 0)
                return true;
            else
                return false;

        }

        public bool getSpaceInList( int spaceID)
        {
            index = 0;
            foreach(SpaceClass space in InternalList)
            {
                if(space.checkSpaceID(spaceID) == true)
                    return true;
                else
                    index++;
            }
            return false;
        }
        
        
    }

}
