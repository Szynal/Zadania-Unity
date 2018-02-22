using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    /// <summary>
    /// Zatrzymuje grę w przypadku przyciśnięcia klawisza [DELETE] lub [ESCAPE]
    /// </summary>
    public class PauseMenu : MonoBehaviour
    {

        public GameObject PauseUI;

        public bool Paused = true;

        // Use this for initialization
        void Start()
        {
            SetActive();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Delete))
            {
                Paused = !Paused;
            }

            if (Paused)
            {
                Time.timeScale = 0;
                PauseUI.SetActive(true);

            }

            else if (!Paused)
            {
                Time.timeScale = 1;
                PauseUI.SetActive(false);
            }
        }

        /// <summary>
        /// Dla przycisku Start
        /// </summary>
        public void StartUI()
        {
            PauseUI.transform.GetChild(0).gameObject.SetActive(false);
            PauseUI.transform.GetChild(1).gameObject.SetActive(true);
            Paused = false;
        }
        /// <summary>
        /// Dla przycisku Resume 
        /// </summary>
        public void Resume()
        {
            Paused = false;
        }
        /// <summary>
        /// Dla przycisku MainMenuz 
        /// </summary>
        public void MainMenu()
        {
            SceneManager.LoadScene(0);
        }

        /// <summary>
        /// Dla przycisku Quit 
        /// </summary>
        public void Quit()
        {
            Debug.Log("Quit the game!");
            Application.Quit();
        }

        private void SetActive()
        {
            PauseUI.SetActive(true);
            PauseUI.transform.GetChild(0).gameObject.SetActive(true);
            PauseUI.transform.GetChild(1).gameObject.SetActive(false);
            PauseUI.transform.GetChild(2).gameObject.SetActive(true);
            PauseUI.transform.GetChild(3).gameObject.SetActive(true);
        }
    }
}
