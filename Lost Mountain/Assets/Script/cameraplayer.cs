using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraplayer : MonoBehaviour
{
    #region
    public GameObject Player;
    public int CamX;
    public int OffsetCamY;

    #endregion
    //-------------------
    void Update()
    {
        if (Player != null)
        { 
            //si gameobject(Player) n'est pas "Destroy", la camera suit le joueur
            this.transform.position = new Vector3(CamX, Player.transform.position.y + OffsetCamY, Player.transform.position.z + 10); 
        }
    }
}
