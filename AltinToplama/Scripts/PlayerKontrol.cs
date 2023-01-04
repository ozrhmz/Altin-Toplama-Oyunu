using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKontrol : MonoBehaviour
{
public float hareketHizi;
public float ziplamaHizi;
private bool ziplamaDurum;
private float move=0;
private Rigidbody2D rb;
private Animator anim;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        anim=GetComponent<Animator>();     
    }

    void Update()
    {
        move =Input.GetAxis("Horizontal");
        rb.velocity=new Vector2(move*hareketHizi,rb.velocity.y);
        if (move<0)
        {
            transform.eulerAngles=new Vector3(0,180,0);
        }else if (move>0)
        {
            transform.eulerAngles=new Vector3(0,0,0);
        }
        if (Input.GetButtonDown("Jump") && !ziplamaDurum)
        {
            rb.AddForce(new Vector2(rb.velocity.x,ziplamaHizi));
            ziplamaDurum=true;
        }
        RunAnimations();
    }
    void RunAnimations()
    {
        anim.SetFloat("Hareket",Mathf.Abs(move));
        anim.SetBool("ziplamaDurum",ziplamaDurum);
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Zemin"))
        {
            ziplamaDurum=false;
        }
    }
}
