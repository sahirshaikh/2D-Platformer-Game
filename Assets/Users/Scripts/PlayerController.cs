using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    [SerializeField] private BoxCollider2D BCol;
    private Vector2 BSize;
    private Vector2 BOff;
    public float Speed;
    
    private Rigidbody2D RB;
    public float jump;
    public ScoreController SC;


    void Start()
    {
        BSize = BCol.size;
        BOff = BCol.offset;
        RB = this.gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");
        PlayerAction(Horizontal, Vertical);
        PlayerMovement(Horizontal, Vertical);


        if (Input.GetKey(KeyCode.LeftControl))
        {
            Crouch(true);
        }
        else
        {
            Crouch(false);
        }
    }

    public void PlayerMovement(float h, float v)
    {
            Vector2 Pos = transform.position;
            Pos.x = Pos.x + h*Speed*Time.deltaTime;
            transform.position = Pos;
            // Debug.Log("Move: " + Pos.x); 

            if(v>0)
            {
                RB.AddForce(new Vector2 (0f,jump),ForceMode2D.Force);
            }   
    }

    private void PlayerAction(float H, float V)
    {
        animator.SetFloat("Speed", Mathf.Abs(H));
        // Debug.Log("Speed: " + H);
        Vector3 scale = transform.localScale;

        if (H < 0)
        {
            scale.x = -1 * Mathf.Abs(scale.x);
        }
        else if (H > 0)
        {
            scale.x = Mathf.Abs(scale.x);
        }
        transform.localScale = scale;
        // Debug.Log("Speed2: " + V);
        PlayJumpAnimation(V);
    }

    public void PlayJumpAnimation(float VerticalInput)
    {
        if(VerticalInput>0)
        {
            animator.SetTrigger("Jump");
        }
    }

    private void Crouch(bool Crouch)
    {
        animator.SetBool("Crouch", Crouch);

        if (Crouch == true)
        {
            float offx=-0.1124f;
            float offy=0.6017f;
            float sizex = 0.9826f;
            float sizey = 1.3613f;

            BCol.size = new Vector2(sizex, sizey);
            BCol.offset = new Vector2(offx, offy);
        }
        else{
        BCol.size = BSize;
        BCol.offset = BOff;
        }
    }

    internal void Pickupkey()
    {
        Debug.Log("Key PickUp Successfully");
        SC.Scoreincrement(10);
    }
}
