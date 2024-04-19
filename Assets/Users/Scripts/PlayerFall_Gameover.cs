using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class PlayerFall_Gameover : MonoBehaviour
{

    public Animator animator;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.GetComponent<PlayerController>() != null)

        {
            Debug.Log("Player Fall... Game Over...!!");
            animator.SetTrigger("Death");
            Invoke("ReloadGame",2f);



        }  
    }
    private void ReloadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
