using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerFall_Gameover : MonoBehaviour
{

    public Animator animator;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.GetComponent<PlayerController>() != null)

        {
            Debug.Log("Player Fall... Game Over...!!");
            animator.SetTrigger("Death");

        }   
    }
}
