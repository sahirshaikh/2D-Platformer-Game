using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gamercontroller : MonoBehaviour
{
    
    public void QuitGame()
{
    Application.Quit();
}

public void ReloadGame()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}

public void NextLevelGame()
{
    int SCno = SceneManager.GetActiveScene().buildIndex;
    SceneManager.LoadScene(SCno+1);
}

public void LobbyLoading()
{
    SceneManager.LoadScene(0);
}



}
