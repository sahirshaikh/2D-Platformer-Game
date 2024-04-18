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

    void Start()
    {
        BSize = BCol.size;
        BOff = BCol.offset;
    }

    void Update()
    {
        float speed = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("Speed", Mathf.Abs(speed));
        Debug.Log("Speed: " + speed);
        Vector3 scale = transform.localScale;

        float speed2 = Input.GetAxisRaw("Vertical");
        Debug.Log("Speed2: "+speed2);
        PlayJumpAnimation(speed2);
        

        if(speed<0)
        {

            scale.x = -1 * Mathf.Abs(scale.x);  
        } else if(speed>0)
        {
            scale.x = Mathf.Abs(scale.x);
        }
        transform.localScale = scale; 

        if(Input.GetKey(KeyCode.LeftControl))
        {
            Crouch(true);

        }
        else{
            Crouch(false);
        }
    }

    public void PlayJumpAnimation(float VerticalInput)
    {
        if(VerticalInput>0)
        {
            animator.SetTrigger("Jump");
        }
    }

    public void Crouch(bool Crouch)
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
}
