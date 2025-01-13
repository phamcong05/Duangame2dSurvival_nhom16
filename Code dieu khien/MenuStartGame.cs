using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStartGame : MonoBehaviour
{
   public void Newgame()
    { 
        SceneManager.LoadScene(1);
    }
   public void Exit()
        {
        SceneManager.LoadScene(0);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void Setting()
    {
        SceneManager.LoadScene(2);
    }
}
