using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    #region
    public int MyInt = 1;

    #endregion
    void Start()
    {
        // pratique "switch"
        for (int i = MyInt; i <9; i++)
        {

            switch (i)
            {
                case 4:

                Debug.Log("mamadou");
                    break;

                case 6:

                Debug.Log("papadou");
                    break;

                case 8:

                Debug.Log("grandmamadou");
                    break;

                default:

                break;
            }
        }
    }
    void Update()
    {

    }
}

