
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu3 : MonoBehaviour
{

   public void PlayGame(){
    SceneManager.LoadSceneAsync(3);
   }
        

        public void QuitGame(){
         Application.Quit();
        }
    
}
