using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    /// <summary>
    /// Główne menu aplikacji
    /// </summary>
    public class MenuManager : MonoBehaviour
    {
        public void StartFirstTastk()
        {
            SceneManager.LoadScene(1); // Zadanie nr 1
        }
        public void StartSecondTask()
        {
            SceneManager.LoadScene(2); // Zadanie nr 2 
        }
        /// <summary>
        /// Wyłączanie gry
        /// </summary>
        public void QuitGame()
        {
            Debug.Log("Quit the game!");
            Application.Quit();
        }
    }
}