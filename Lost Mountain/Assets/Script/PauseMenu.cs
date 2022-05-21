using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public string SetMainMenu;
    public GameObject PauseMenuUI;
    public GameObject TutoMenuUi;
    public AudioMixer audiomixer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
    }

    void Paused()
    {
        TutoMenuUi.SetActive(false);
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        gameIsPaused = true;
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        gameIsPaused = false;
    }
    
    public void MainMenu()
    {
        Resume();
        SceneManager.LoadScene("MainMenu");
    }

    public void SetMusic(float volume)
    {
        audiomixer.SetFloat("Music", volume);
    }

    public void SetSound(float volume)
    {
        audiomixer.SetFloat("Sound", volume);
    }
}
