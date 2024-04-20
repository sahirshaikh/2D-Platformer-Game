using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUIController : MonoBehaviour
{
    public GameObject LevelSelectionUI;
    public GameObject StartUpUI;

    public void PlayGame()
    {
        LevelSelectionUI.SetActive(true);
        StartUpUI.SetActive(false);



    }
}
