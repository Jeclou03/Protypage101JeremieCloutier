using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oxygenbottle : MonoBehaviour
{
    #region
    public oxygenbar OxygenBar;
    public int MaxOxygen = 100;
    
    #endregion
    //--------------------------------------------
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //si collision avec le joueur, max d'oxygene et detruire ce "gameObject"
            OxygenBar.SetMaxHealth(MaxOxygen);
            Destroy(this.gameObject);
        }
    }
}