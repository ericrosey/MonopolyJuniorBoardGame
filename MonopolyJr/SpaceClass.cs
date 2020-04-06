using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class SpaceClass
{
    //attributes of spaces
    private int spaceId;
    private int rent;
    private string spaceType;
    private string spaceName;
    private System.Drawing.Color spaceColor;
    private bool isOwned;

    public SpaceClass()//constructor
    {
        isOwned = false;//isOwned fault false
    }
    public string displaySpace()//displays name and rent
    {
        return spaceName + "\n$"  + rent.ToString();
    } 
    public Boolean createSpaceObject(string s)//creates object from text file
    {
        SpaceClass thisSpace = this;//creates object
        string[] spaceString = s.Split('*');//splits object by *. splits objects into seperate attributes
        int i;//decclares variable

        int spaceStringSize = spaceString.GetLength(0);//gets length

        for (i = 0; i < spaceStringSize; i++)//loops thru each
        {
            spaceString[i] = spaceString[i].Trim();
        }
        if (spaceString[0].Length > 2)//space id
        {
            MessageBox.Show("spaceId is not right length");
            return false;//returns false if id is not the correct length
        }
        try//trys to convert space id
        {
            spaceId = Convert.ToInt32(spaceString[0]);//for id

        }
        catch//if id cannot be converted we no it is not the right format
        {
            MessageBox.Show("Id is not valid integer");
            return false;
        }
        try//tries to convert rent
        {
            rent = Convert.ToInt32(spaceString[1]);//for rent
        }
        catch
        {
            MessageBox.Show("Rent is not in the right format");
            return false;//returns false if it isntt a number
        }
        
        spaceType = spaceString[2];//for space type
        if (spaceType == "")//makes sure it is not empty
        {
            MessageBox.Show("Type is Empty");
            return false;//returns false if it is
        }
        spaceName = spaceString[3];
        if (spaceName == "")//makes sure soace has a name
        {
            MessageBox.Show("Name is empty");
            return false;
        }
        try//tries to convert systemColor into a color
        {
            spaceColor = System.Drawing.Color.FromName(spaceString[4]);
        }
        catch
        {
            MessageBox.Show("Color is not a color");//makes sure it is a color
        }
        return true;
    }
    public void setOwn(bool owned)//setter
    {
        isOwned = owned;
    }
    public Boolean getOwn()//getter
    {
        return isOwned;
    }

    public Boolean checkSpaceID(int ID)//to get space in list for SpaceListClass
    {
        SpaceClass space = this;//for object

        if (ID == space.spaceId)//for a space, get its spaceid
        {
            //gets evey attribute for object
            spaceId = space.spaceId;
            rent = space.rent;
            spaceType = space.spaceType;
            spaceName = space.spaceName;
            spaceColor = space.spaceColor;
            isOwned = space.isOwned;
            MessageBox.Show(space.displaySpace());
            if (!isOwned && spaceType == "property")//checks for unowned properties
            {
                if (!MonopolyJr.MonopolyBoardGame.turn)
                {
                    MonopolyJr.MonopolyBoardGame.user.buyProperty(rent, space);
                    MonopolyJr.MonopolyBoardGame.turn = true;
                }
                else
                {
                    MonopolyJr.MonopolyBoardGame.player2.buyProperty(rent, space);
                    MonopolyJr.MonopolyBoardGame.turn = false;
                }
            }

            else if(spaceType == "chance")//call find card, get random card instance == to random card call display 
            {
                if (!MonopolyJr.MonopolyBoardGame.turn)//player1 turn
                {
                    //MonopolyJr.MonopolyBoardGame.user.userPayRent(rent, space);
                    MonopolyJr.CardClass chanceCard1 = MonopolyJr.MonopolyBoardGame.cardList.randomCard();
                    MessageBox.Show(chanceCard1.displayCard());
                    MonopolyJr.MonopolyBoardGame.user.doChanceCard(chanceCard1);
                    MonopolyJr.MonopolyBoardGame.turn = true;
                }
                else
                {
                    //MonopolyJr.MonopolyBoardGame.player2.player2PayRent(rent, space);
                    MonopolyJr.CardClass chanceCard2 = MonopolyJr.MonopolyBoardGame.cardList.randomCard();
                    MessageBox.Show(chanceCard2.displayCard());
                    MonopolyJr.MonopolyBoardGame.player2.doChanceCard(chanceCard2);
                    MonopolyJr.MonopolyBoardGame.turn = false;
                }

            }

            else if(isOwned && spaceType == "property")//this handles owned prop
            {
                MessageBox.Show("Somebody owns this space");//this is where you will pay others
                if (!MonopolyJr.MonopolyBoardGame.turn)//player1 turn
                {
                    MonopolyJr.MonopolyBoardGame.user.userPayRent(rent, space);
                    MonopolyJr.MonopolyBoardGame.turn = true;
                }
                else
                {
                    //player 2 turn
                    MonopolyJr.MonopolyBoardGame.player2.player2PayRent(rent, space);
                    MonopolyJr.MonopolyBoardGame.turn = false;
                }

            }
            else
            {
                if (!MonopolyJr.MonopolyBoardGame.turn)
                {
                    MonopolyJr.MonopolyBoardGame.turn = true;
                }
                else
                {
                    MonopolyJr.MonopolyBoardGame.turn = false;
                }
            }
            return true;
        }

        else
        {
            return false;
        }
    }
    public string getName()//getter
    {
        return spaceName;
    }
    public SpaceClass getSpace()//getter
    {
        return this;
    }
    public Boolean isOwn()//is own is default false. it checks if the current space is not owned and if not it changes value
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
            MessageBox.Show("chance card");
            return true;
        }
        return false;
    }
    public Boolean isOther(int ID)//checks if current space is go to jail
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
        if(ID == 18)//go to jail space id
        {
            //changes id to jail id
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