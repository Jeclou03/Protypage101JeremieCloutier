using UnityEngine;

public class GameManager : MonoBehaviour
{
    // mis a jour dans la prochaine version
    public int GamePlayed = 0;
    public int NbrOfCollectible;

    //le joueur revie apres sa mort
    public void AddGameplayed()
    {
        GamePlayed++;
        Debug.Log("Game Played: " + GamePlayed);
    }

}
