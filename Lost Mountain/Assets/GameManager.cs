using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int GamePlayed = 0;
    public int NbrOfCollectible;

    //le joueur revie apres sa mort
    public void AddGameplayed()
    {
        GamePlayed++;
        Debug.Log("Game Played: " + GamePlayed);
    }

}
