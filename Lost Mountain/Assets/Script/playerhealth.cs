using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealth : MonoBehaviour
{
    #region
    public int MaxOxygen = 100;
    public int CurrentOxygen;
    public oxygenbar OxygenBar;

    #endregion
    private bool canTake = true;
    private bool isSuffocate = false;
    private bool isDead = false;
    private Rigidbody rbPlayer;
    //---------------------------------------------
    void Start()
    {
        //l'oxygene max en commancant le jeu
        CurrentOxygen = MaxOxygen;
        OxygenBar.SetMaxHealth(MaxOxygen);
        rbPlayer = this.GetComponent<Rigidbody>();
    }

    void Update()
    {   
        //suffocation du joueur
        if (isSuffocate == false && CurrentOxygen <= 0)
        {
            rbPlayer.constraints = RigidbodyConstraints.None;
            isSuffocate = true;
        }

        //mort du joueur apres suffocation
        if (CurrentOxygen < -20 && isDead == false)
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            isDead = true;
        }

        // system de perte d'oxygene par seconde (1/3)
        if (canTake == true)
        {
            TakeDamage(5);
            canTake = false;
            StartCoroutine(WaitToTake());
        }
    }

    IEnumerator WaitToTake()
    {
        // (2/3)
        yield return new WaitForSeconds(1);
        canTake = true;
    }

    void TakeDamage(int damage)
    {
        // (3/3)
        CurrentOxygen -= damage;
        OxygenBar.SetHealth(CurrentOxygen);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // remise au max de l'oxygene lors d'une collision avec "oxygen bottle"
        if (collision.gameObject.tag == "Oxygen")
        {
            OxygenBar.SetMaxHealth(MaxOxygen);
            CurrentOxygen = MaxOxygen;
        }
    }
}



