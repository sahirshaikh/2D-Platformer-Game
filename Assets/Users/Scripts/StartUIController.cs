using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUIController : MonoBehaviour
{
    [SerializeField] private GameObject LevelSelectionUI;
    [SerializeField] private GameObject StartUpUI;

    public void PlayGame()
    {
        SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);
        LevelSelectionUI.SetActive(true);
        StartUpUI.SetActive(false);
    }
}
