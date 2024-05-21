using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunnerEnemyController : MonoBehaviour
{

    [SerializeField] private PlayerLifeController Life;
    [SerializeField] private Transform PointA;
    [SerializeField] private Transform PointB;
    [SerializeField] private float GunnerSpeed;
    [SerializeField] private Animator Gunneranim;
    [SerializeField] private int changedirection;


    void Update()
    {

        Vector2 Currentpos = this.transform.position;
        Vector2 scale = this.transform.localScale;

        if(Currentpos.x > PointA.position.x)
        {
            changedirection=-1; 
        }
        else if(Currentpos.x < PointB.position.x)
        {
            changedirection=1;
        }
        transform.Translate(changedirection*GunnerSpeed*Vector2.right*Time.deltaTime);
        scale.x= -changedirection*Mathf.Abs(scale.x);  
        this.transform.localScale = scale;  
    }



        private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.GetComponent<PlayerController>() != null)
        {
            Debug.Log("Enemy Attack Player...!");
            Life.LifeDecrement();
        }  
    }
}
