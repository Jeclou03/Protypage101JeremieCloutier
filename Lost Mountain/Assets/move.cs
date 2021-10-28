using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripting_02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Modify these variables values to get the expected result: Every boolean expressions should return True
        int a = 60;
        int b = 30;
        int c = 6;
        int d = 660;
        int e = 10;
        int f = 60;

        // Blooean Expressions: Don't change them
        Debug.Log(a == b + b);
        Debug.Log(b == a - b);
        Debug.Log(b == c * 5);
        Debug.Log(c == a / 10);
        Debug.Log(c == a % 9);
        Debug.Log(d == a * e + f);
        Debug.Log(d != f * e);
        Debug.Log(b > e);
        Debug.Log(c < e);
        Debug.Log(d >= f);
        Debug.Log(a <= f);
        Debug.Log(f > 5 && e < 10);
        Debug.Log(d > 5 || f < 25);
        Debug.Log(!(a < 5 && a < 10));

    }

}
