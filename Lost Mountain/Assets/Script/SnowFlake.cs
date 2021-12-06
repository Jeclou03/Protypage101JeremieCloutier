using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowFlake : MonoBehaviour
{
    playerhealth isSuffocate;
    
    void Update()
    {
        if (transform.position.x <= -3.68f)
        {
            transform.position = new Vector3(-3.69f, gameObject.transform.position.y, gameObject.transform.position.z);
        }

        if (transform.position.x >= -3.70f)
        {
            transform.position = new Vector3(-3.70f, gameObject.transform.position.y, gameObject.transform.position.z);
        }

        if (isSuffocate == true)
        {
            Destroy(this.gameObject);
        }
    }
}
