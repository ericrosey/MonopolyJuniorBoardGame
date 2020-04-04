using System;
using System.Windows.Forms;

public class Space
{
    private int spaceId;
    private int rent;
    private string spaceType;
    private string spaceName;
    private System.Drawing.Color spaceColor;
    private bool isOwned;

    public Space()
    {
    }
        public Boolean createSpaceObject(string s)
        {
        Space thisSpace = this;
        string[] spaceString = s.Split('*');
        int i;

        int spaceStringSize = spaceString.GetLength(0);

        for(i = 0; i < spaceStringSize; i++)
        {
            spaceString = spaceString[i].Trim();

        }
        if(spaceString[0].Length > 2)//space id
        {
            MessageBox.Show("spaceId is not right length");
            return false;
        }
        try
        {
            spaceId = Convert.ToInt32(spaceString[0]);
           
        }
        catch
        {
            MessageBox.Show("not valid integer");
            return false;
        }
        spaceId = Convert.ToInt32(spaceString[0]);

        if (spaceId >=24 || spaceId < 0)
        {
            MessageBox.Show("not between 0-24");
        }

       
        if(spaceString[1].Length != 1)//
        {
            MessageBox.Show(" rent incorrect format");
            return false;
        }
        try
        {
            rent = Convert.ToDecimal(spaceString[1]);
        }
        catch
        {
            MessageBox.Show("rent is not in the right format");
            return false;
        }

        spaceType = spaceString[2];
        if(spaceType = ""|| spaceType = " ")
        {
            MessageBox.Show("Type is empty");
            return false;
        }

        spaceName = spaceString[3];
        if(spaceName = ""||spaceName = " ")
        {
            MessageBox.Show("Name is empty");
            return false;
        }/*
        try check space color
        {
            
        }
        catch{}
        */
        return true;
        } 


	
    public Boolean isOwned(int ID)
    {
        Space space = this;
        
        if(ID == space.spaceId)
        {
            spaceId = space.spaceId;
            rent = space.rent;
            spaceType = space.spaceType;
            spaceName = space.spaceType;
            spaceColor = space.spaceColor;
            isOwned = space.isOwned;
            if(isOwned == false)
            {
                return true;
            }
        }
        else
        {
            return;
        }
    }

    
    public Boolean isBothOwned(string color)
    {
        Space space = this;
        

    }

    public isChance(int ID)
    {
        Space space = this;

        if(space.spaceType == "chance")
        {
            //do chance
        }
    }
    public isOther(int ID)
    {
        Space space = this;

        if (ID == space.spaceId)
        {
            spaceId = space.spaceId;
            if(space.spaceType == "Jail")
            {
                spaceId = 6;
            }
            if(space.spaceType == "Go To Jail")
            {
                spaceId = 6;
            }
            if(space.spaceId == "Free Parking")
            {
                spaceId = 12;
            }

        }
    }

}
