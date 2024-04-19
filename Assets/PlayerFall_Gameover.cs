using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFall_Gameover : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        // if(other.gameObject.GetComponent<PlayerController>() != null)
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Fall... Game Over...!!");
        }   
    }
}
