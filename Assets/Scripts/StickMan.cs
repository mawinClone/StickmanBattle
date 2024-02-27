using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickMan : MonoBehaviour
{
    public string enemyTag;
    public string enemyWeapon;
    public string TagToIgnore;
    public int hp;
    public Weapon weapon;
    [Header("Stat")]
    [Space(10)]
    public float speed;
    float originSpeed;
    
    [Header("Setting")]
    [Space(10)]
    public Animator anim;
    public GameObject rayObj;
    public bool isFound = false;
    Rigidbody2D rb;

    bool isStop;
    bool isRun;
    bool isAttack;
    

    public enum State{
        None,
        Stop,
        Run,
        Attack
    }
    public State state;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        

        speed = speed + Random.Range(-0.5f, 0.5f);

        originSpeed = speed;
    }

    
    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;

        //move state
        switch(state){
            case State.Stop: state = State.None;
                speed = 0;
                anim.SetTrigger("Stop");
                break;
            case State.Run: state = State.None;
                speed = originSpeed;
                anim.SetTrigger("Run");
                break;
            case State.Attack: state = State.None;
                speed = 0;
                anim.SetTrigger("Attack");
                break;
            default: break;
        }
    }

    private void FixedUpdate() {
        RaycastHit2D hit = Physics2D.Raycast(rayObj.transform.position, Vector2.up);
        Debug.DrawRay(rayObj.transform.position, Vector2.up * 2, Color.red);
        
        if (hit != null )
        {

            if (hit.distance <= 2.0f)
            {
                if(hit.collider!=null)
                {
                    if (hit.collider.gameObject.tag == enemyTag && !isAttack) // found enemy
                    {
                        ClearBool();
                        isAttack = true;
                        state = State.Attack;
                    }else if(hit.collider.gameObject.tag == TagToIgnore && isStop) // fix bug weapon detect later 
                    {
                        ClearBool();
                        isRun = true;
                        state = State.Run;
                    }
                    else if(hit.collider.gameObject.tag != enemyTag && isStop )
                    {
                        ClearBool();
                        isRun = true;
                        state = State.Run;
                    }
                }else if(isStop){
                    ClearBool();
                    isRun = true;
                    state = State.Run;
                }else if(!isRun){
                    
                    ClearBool();
                    isRun = true;
                    state = State.Run;
        
                }
            }else if(isAttack)
            {
                ClearBool();
                state = State.Run;
            }
        }
    }

    public void ClearBool()
    {
        isAttack = false;
        isRun = false;
        isStop = false;
    }

    public void StickManOnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == enemyWeapon && collision.gameObject.GetComponent<Weapon>().canAttack)
        {
            hp--;
            if(hp <=0 )
            {
                Destroy(gameObject);
            }
            // Knockback(collision.gameObject.transform);
            Knockback(collision.gameObject.GetComponent<Weapon>().attackerTransform);
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == TagToIgnore )
        {
            Physics2D.IgnoreCollision( collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        } 
    } 

    public void Knockback(Transform t)
    {
        // Vector3 dir = new Vector3(1,1,0); // show use from attacker
        // rb.velocity = dir.normalized * 5f;
        Debug.Log("hit");
        Vector2 direction =  new Vector2(transform.position.x,transform.position.y)  - new Vector2(t.position.x, t.position.y*2)  ;
        rb.AddForce(direction * 40) ;
    }

    


    public void AttackOn()
    {
        weapon.SetAttackStatus(true);
    }

    public void AttackOff()
    {
        weapon.SetAttackStatus(false);
    }
}