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

    public void GameOver()
    {
        GameOverMenuUi.SetActive(true);
    }

    public void Restart()
    {
        GameOverMenuUi.SetActive(false);
        // la possibliter de restert la partie vas etre possible dans la version final
    }

    public void ReturnToMainMenu()
    {
        GameOver();
        SceneManager.LoadScene("MainMenu");
    }

}

