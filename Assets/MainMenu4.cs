
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu4 : MonoBehaviour
{

   public void PlayGame(){
    SceneManager.LoadSceneAsync(4);
   }
        

        public void QuitGame(){
         Application.Quit();
        }
    
}
