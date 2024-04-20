using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Complete_controller : MonoBehaviour
{

public GameObject LevelCompleteUI;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.GetComponent<PlayerController>() != null)

        {
            Debug.Log("Level Completed....!!");
            LevelManager.Instance.SetCurrentLevelComplete();
            LevelCompleteUI.SetActive(true);
        }  

        PlayerController playerController= other.GetComponent <PlayerController>();
        playerController.enabled = false;
    }




}
