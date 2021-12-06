using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    #region
    public int MyInt = 1;

    #endregion

    private int[] myNum = { 0, 1, 3 };

    void Start()
    {
        // pratique "switch"
        for (int i = MyInt; i < 9; i++)
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

        Debug.Log(Multiply(5,10));

        for (int i = 0; i < myNum.Length; i++)
        {
            Debug.Log(myNum[i]);
        }
    }

    void Update()
    {

    }
    string printConsoleMessage()
    {
        return "hello";
    }

    int Multiply(int a, int b)
    {
        int result;

        result = a * b;
        return result;
    }
}


