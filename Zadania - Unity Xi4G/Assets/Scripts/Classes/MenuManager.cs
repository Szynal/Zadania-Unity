using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class MenuManager : MonoBehaviour
    {
        public void StartFirstTastk()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        public void StartSecondTask()
        {
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }

        public void QuitGame()
        {
            Debug.Log("Quit the game!");
            Application.Quit();
        }
    }
}