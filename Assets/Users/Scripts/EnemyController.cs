using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyController : MonoBehaviour
{
    public Animator EnemyAnimator;
    public Animator PlayerAnimator;


    private void OnCollisionEnter2D(Collision2D other) {
    if(other.gameObject.GetComponent<PlayerController>() != null)

        {
            Debug.Log("Enemy Killed Player");
            PlayerAnimator.SetTrigger("Death");
            Invoke("ReloadGame",2f);



        }  
    }
    private void ReloadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
