using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //--------------------------------------------------
    //Technique pour faire des enumeration

    public enum Direction
    {
        None = 0,
        North = 1,
        South = 2,
        East,//...
        West//...
    }

    public Direction dir;

    public void Shoot(Direction direction)
    {
        // sw
        switch (direction)
        {
            case Direction.North:
                //fire in this direction
                break;
        }
    }
    //---------------------------------------------------
    // forloop
    public int[] ints = { 1, 3, 6, 9, 12 };

    public void ParseArray()
    {
        // lArray va rouler jusqua la valeur 6 (0+1,1+2,2+3,3+4,...)
        for(var i = 0; i < 6; i++)
        {
            Debug.Log(ints[i]);
        }
    }
    //-------------------------------------------------
}
