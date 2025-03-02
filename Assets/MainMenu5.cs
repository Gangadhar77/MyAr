
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu5 : MonoBehaviour
{

   public void PlayGame(){
    SceneManager.LoadSceneAsync(5);
   }
        

        public void QuitGame(){
         Application.Quit();
        }
    
}
