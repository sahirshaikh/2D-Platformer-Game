using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyController : MonoBehaviour
{


    public PlayerLifeController Life;


    private void OnCollisionEnter2D(Collision2D other) {
    if(other.gameObject.GetComponent<PlayerController>() != null)

        {
            Debug.Log("Enemy Attack Player...!");
            Life.LifeDecrement();

        }  
    }


}
