using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackActivation : MonoBehaviour
{
    [SerializeField] private Animator Enemyanimator;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.GetComponent<PlayerController>() != null)

        {
            Debug.Log("Player Enter into Enemy Bondary...!!");
            Enemyanimator.SetBool("Attack",true);
        }   
    }

    
    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.GetComponent<PlayerController>() != null)

        {
            Debug.Log("Player Exit Enemy Bondary...!!");
            Enemyanimator.SetBool("Attack",false);
        }   
    }
}
