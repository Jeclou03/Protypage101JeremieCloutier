
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    #region
    public string LevelLostMountain;
    public bool TwoPlayerIsLoad = false;
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
    
    // jouer avec un ami
    public void WithAFriend()
    {
        SceneManager.LoadScene(LevelLostMountain);
        TwoPlayerIsLoad = true;
    }
}
