using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int GamePlayed = 0;
    private static GameManager instance;
    public int NbrOfCollectible;
    moveplayer Jump;

    private void Awake()
    {
        //DontDestroyOnLoad(gameObject);

        ///if (instance != null)
        //{
            //Destroy(gameObject);
        //}
        //else
        //{
            //instance = this;
           // DontDestroyOnLoad(this.gameObject);
       // }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddGameplayed()
    {
        GamePlayed++;
        Debug.Log("Game Played: " + GamePlayed);
    }
    
    // habiliter qui reste a la mort du joueur.






}
