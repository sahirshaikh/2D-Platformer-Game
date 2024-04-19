using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gamercontroller : MonoBehaviour
{
    public void PlayGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

    }

    public void QuitGame()
{
    Application.Quit();
}

public void ReloadGame()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}

}
