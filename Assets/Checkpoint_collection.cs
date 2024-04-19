using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint_collection : MonoBehaviour
{
        public Animator keyanimator;


    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.GetComponent<PlayerController>() != null)

        {
            Debug.Log("Near Checkpoint..!!");
            keyanimator.SetTrigger("FadeOut");
            PlayerController playerController = other.gameObject.GetComponent<PlayerController>();
            playerController.Pickupkey();
            Destroy(gameObject);

        }   
    }
}
