using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oxygenbottle : MonoBehaviour
{

    //--------------------------------------------
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}