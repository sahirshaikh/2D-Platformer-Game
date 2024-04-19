using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartGame_fall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
 if(other.gameObject.GetComponent<PlayerController>() != null)

        {
            Debug.Log("Restart Game");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }  
    }

}
