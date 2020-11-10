using UnityEngine.SceneManagement;
    using UnityEngine;

public class LevelManager : MonoBehaviour
{
   public void Nextlevel(string nameLv)
    {
        SceneManager.LoadScene(nameLv);
    
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("MENU");
      }
    public void Quit()
    {
    
        Application.Quit();
    }

}
