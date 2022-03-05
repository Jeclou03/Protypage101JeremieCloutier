using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public GameObject GameOverMenuUi;
    public static GameOverMenu Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            return;
        }
        Instance = this;
    }
    //lors de la mort du joueur
    public void GameOver()
    {
        GameOverMenuUi.SetActive(true);
    }
    //possiblite de restart la partie vas etre possible dans la version final
    public void Restart()
    {
        GameOverMenuUi.SetActive(false);
        
    }
    //possiblite de retourner au menu principale
    public void ReturnToMainMenu()
    {
        GameOver();
        SceneManager.LoadScene("MainMenu");
    }

}

