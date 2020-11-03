using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
   public void StartGame() 
    {
        print("開始遊戲");
        SceneManager.LoadScene("LEVEL 1");   //場景
    }   //SceneManager.LoadScene(1)                //編號

   public void QuitGame() 
    { 
        print("結束遊戲");
        Application.Quit();
    }
}
