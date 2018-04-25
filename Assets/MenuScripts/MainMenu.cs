using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void StartGame()
    {
        Debug.Log("Starting.");
        SceneManager.LoadScene(1);
    }

    public void PlayGame()
    {
        Debug.Log("Playing Game. ");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    } 
     
    public void RestartGame()
    {
        Debug.Log("Restarting.");
        SceneManager.LoadScene(0);
    }
	
}
