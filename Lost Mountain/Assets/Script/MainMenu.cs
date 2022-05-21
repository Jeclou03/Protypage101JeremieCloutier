using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    #region
    public string LevelLostMountain;
    public bool TwoPlayerIsLoad = false;
    public AudioMixer audiomixer;
    #endregion

    //switch de scene à SampleScene(lostMountain)
    public void StartGame()
    {
        SceneManager.LoadScene(LevelLostMountain);
    }

    // option de mettre en full screen
    public void SetFullScreen(bool IsFullScreen)
    {
        Screen.fullScreen = IsFullScreen;
    }

    // quitter le jeu
    public void QuitGame()
    {
        Application.Quit();
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
