using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickManCollider : MonoBehaviour
{
    public StickMan stickMan;

    void OnTriggerEnter2D(Collider2D collision)
    {
        stickMan.StickManOnTriggerEnter2D(collision);
    }

    // void OnCollisionEnter2D(Collision2D collision){
    //     if(collision.gameObject.tag == stickMan.TagToIgnore )
    //     {
    //         Physics2D.IgnoreCollision( collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    //     } 
    // } 
}
