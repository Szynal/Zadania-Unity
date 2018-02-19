using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject PauseUI;

    private bool _Paused = true;

    // Use this for initialization
    void Start()
    {
        PauseUI.SetActive(true);
        PauseUI.transform.GetChild(0).gameObject.SetActive(true);
        PauseUI.transform.GetChild(1).gameObject.SetActive(false);
        PauseUI.transform.GetChild(2).gameObject.SetActive(true);
        PauseUI.transform.GetChild(3).gameObject.SetActive(true);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Delete))
        {
            _Paused = !_Paused;
        }

        if (_Paused)
        {
            PauseUI.SetActive(true);
        }

        else if (!_Paused)
        {
            PauseUI.SetActive(false);
        }
    }


    public void StartUI()
    {
        PauseUI.transform.GetChild(0).gameObject.SetActive(false);
        PauseUI.transform.GetChild(1).gameObject.SetActive(true);
        _Paused = false;

    }

    public void Resume()
    {
        _Paused = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }


    public void Quit()
    {
        Debug.Log("Quit the game!");
        Application.Quit();
    }

    IEnumerator Enumerator()
    {
        yield return new WaitForSeconds(15.0F);
        PauseUI.transform.GetChild(7).gameObject.SetActive(false);
        PauseUI.transform.GetChild(8).gameObject.SetActive(false);

    }

}
