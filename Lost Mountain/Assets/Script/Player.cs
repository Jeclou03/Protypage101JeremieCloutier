using UnityEngine;

public class Player : MonoBehaviour
{
    //variable de reference
    public GameObject FlakePrefab;
    public GameObject FlakeInstance;
    public bool CanWalk = true;
    public void Start()
    {
        //flocons de neige apparaisant sur le joueur
        FlakeInstance = Instantiate(FlakePrefab, transform);
    }
}

