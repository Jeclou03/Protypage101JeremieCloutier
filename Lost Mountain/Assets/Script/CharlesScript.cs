using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharlesScript : MonoBehaviour
{
    // Put this code on you Collectible
    // You need to insert this:----- public int NbrOfCollectible; ---- in your Game Manager's variables
    // Make sure you have a Text Component on your canvas which is referenced to in the inspector part of your script

    #region Variables

    public Text CollectibleNbr; // refers to the Canvas component

    private Text collectibles; // private var for canvas

    private bool collectibleGiven; 

    public GameManager GameManagerScript; // your GameManager

    #endregion


    // Start is called before the first frame update
    void Start()
    {
        // sets collectibles to be Your text component
        collectibles = CollectibleNbr.GetComponent<Text>();
        // Refer to Your GameManager Script
        GameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // shows the nbr of collectible which is an int in your game manager script
        collectibles.text = GameManagerScript.NbrOfCollectible.ToString();

        //destroys the collectile and makes sure you can't pick it up a second time
        if (collectibleGiven == true)
        {
            Destroy(gameObject);

            collectibleGiven = false;
        }
    }

	public void OnTriggerEnter(Collider collider) // Gives you a certain number of collectible
	{
        if (collider.gameObject.tag == "Player")
        {
            GameManagerScript.NbrOfCollectible += 1;

            collectibleGiven = true;
        }
    }
}
