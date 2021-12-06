
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    #region
    public string LevelLostMountain;

    #endregion
    public void StartGame()
    {
        SceneManager.LoadScene(LevelLostMountain);
    }
    public void SetFullScreen(bool IsFullScreen)
    {
        Screen.fullScreen = IsFullScreen;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
