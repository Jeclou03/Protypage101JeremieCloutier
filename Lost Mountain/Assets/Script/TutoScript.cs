using UnityEngine;
using System.Collections;

public class TutoScript : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject TutoMenuUI;
    public GameObject GreenD;
    public GameObject GreenA;
    public GameObject GreenW;

    private bool dIsGreen = false;
    private bool aIsGreen = false;
    private bool wIsGreen = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            GreenD.SetActive(true);
            dIsGreen = true;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            GreenA.SetActive(true);
            aIsGreen = true;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            GreenW.SetActive(true);
            wIsGreen = true;
        }

        if (wIsGreen == true && aIsGreen == true && dIsGreen == true)
        {
            StartCoroutine(WaitToSetTutoFalse());
        }
    }

    IEnumerator WaitToSetTutoFalse()
    {
        yield return new WaitForSeconds(1f);
        TutoMenuUI.SetActive(false);
    }
}
