
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    #region
    public string LevelLostMountain;

    #endregion

    //switch de scene � SampleScene(lostMountain)
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
    
}
