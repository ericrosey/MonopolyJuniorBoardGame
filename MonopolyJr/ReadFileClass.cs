using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonopolyJr
{
    class ReadFileClass
    {
        private string currentfilePath;
        private System.IO.StreamReader fileStreamReader;   // Reference variable of type SR
        private int recordReadCount;


        public ReadFileClass(string filePath)//constructor
        {
            recordReadCount = 0;
            currentfilePath = filePath;

            try
            {
                fileStreamReader = new System.IO.StreamReader(currentfilePath);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Cant open file");
            }
        }//end constructor

        public string getNextRecord(ref Boolean endOfFileFlag)
        {
            string nextRecord;
            endOfFileFlag = false;
            nextRecord = fileStreamReader.ReadLine();

            if(nextRecord == null)
            {
                endOfFileFlag = true;
            }
            else
            {
                recordReadCount += 1;
            }

            return (nextRecord);
        }

        public void closeFile()
        {
            fileStreamReader.Close();
        }

        public void rewindFile()
        {
            recordReadCount = 0;
            fileStreamReader = new System.IO.StreamReader(currentfilePath);
            fileStreamReader.DiscardBufferedData();
            fileStreamReader.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);

        }
    }

}
