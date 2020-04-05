using System;
using System.Windows.Forms;

public class SpaceClass
{
    private int spaceId;
    private int rent;
    private string spaceType;
    private string spaceName;
    private System.Drawing.Color spaceColor;
    private bool isOwned;

    public SpaceClass()
    {
    }
    public Boolean createSpaceObject(string s)
    {
        SpaceClass thisSpace = this;
        string[] spaceString = s.Split('*');
        int i;

        int spaceStringSize = spaceString.GetLength(0);

        for (i = 0; i < spaceStringSize; i++)
        {
            spaceString[i] = spaceString[i].Trim();

        }
        if (spaceString[0].Length > 2)//space id
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

        if (spaceId >= 24 || spaceId < 0)
        {
            MessageBox.Show("not between 0-24");
        }


        if (spaceString[1].Length != 1)//
        {
            MessageBox.Show(" rent incorrect format");
            return false;
        }
        try
        {
            rent = Convert.ToInt32(spaceString[1]);
        }
        catch
        {
            MessageBox.Show("rent is not in the right format");
            return false;
        }

        spaceType = spaceString[2];
        if (spaceType == "" || spaceType == " ")
        {
            MessageBox.Show("Type is empty");
            return false;
        }

        spaceName = spaceString[3];
        if (spaceName == "" || spaceName == " ")
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



    public Boolean checkSpaceID(int ID)//to get space in list for SpaceListClass
    {
        SpaceClass space = this;

        if (ID == space.spaceId)
        {
            spaceId = space.spaceId;
            rent = space.rent;
            spaceType = space.spaceType;
            spaceName = space.spaceType;
            spaceColor = space.spaceColor;
            isOwned = space.isOwned;
            return true;
        }

        else
        {
            return false;
        }
    }

    public Boolean isOwn()
    {
        SpaceClass space = this;
        if(space.isOwned == false)
        {
            isOwned = true;
        }
        
        return false;
    }

    public Boolean isBothOwned()
    {
        SpaceClass space = this;

        return true;
    }

    public Boolean isChance(int ID)
    {
        SpaceClass space = this;

        if (space.spaceType == "chance")
        {
            //do chance
        }
        return true;
    }
    public Boolean isOther(int ID)
    {
        SpaceClass space = this;
        ID = space.spaceId;

        /*
        if(ID == 6)
        {
            spaceId = space.spaceId;
            rent = space.rent;
            spaceType = space.spaceType;
            spaceName = space.spaceType;
            spaceColor = space.spaceColor;
            isOwned = space.isOwned;
        }
        if(ID == 12)/
        {
            spaceId = space.spaceId;
            rent = space.rent;
            spaceType = space.spaceType;
            spaceName = space.spaceType;
            spaceColor = space.spaceColor;
            isOwned = space.isOwned;
        }*/
        if(ID == 18)
        {
            spaceId = 6;//jail
            rent = 2;
            spaceType = space.spaceType;
            spaceName = space.spaceType;
            spaceColor = space.spaceColor;
            isOwned = space.isOwned;
        }

        return true;
    }

}