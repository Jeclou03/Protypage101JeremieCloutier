using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject FlakePrefab;
    public GameObject FlakeInstance;
    public bool CanWalk = true;
    public void Start()
    {
        FlakeInstance = Instantiate(FlakePrefab, transform);
    }
}

