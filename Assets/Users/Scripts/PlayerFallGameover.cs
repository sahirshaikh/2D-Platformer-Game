using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class PlayerFall_Gameover : MonoBehaviour
{

    [SerializeField] private Animator animator;
    [SerializeField] private GameObject GameOverCanvas;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.GetComponent<PlayerController>() != null)

        {
            Debug.Log("Player Fall... Game Over...!!");
            animator.SetTrigger("Death");


            Invoke("GameOverCanvasactive",1.5f);



        }  
    }
    private void GameOverCanvasactive()
    {
        GameOverCanvas.SetActive(true);
    }

}
