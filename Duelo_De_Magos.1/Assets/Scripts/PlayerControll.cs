using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public float jumpForce;
    public int defaultAdditionalJumps = 1; 
    int additionalJumps;
    public float rememberGroundedFor; 
    float lastTimeGrounded;
    public float fallMultiplier = 2.5f; 
    public float lowJumpMultiplier = 2f;
    bool isGrounded = false; 
    bool facingRight = false;
    public Transform isGroundedChecker; 
    public float checkGroundRadius; 
    public LayerMask groundLayer;
    public float speed;
    Rigidbody2D rb; 
    Animator m_Animator;
    public Transform portal;
    public Transform spawn; 
    
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
       m_Animator = GetComponent<Animator>();
    }

    void Update() 
    { 
        Move();
        Jump();
        BetterJump();
        CheckIfGrounded();
        Verifica();
    } 
    void Verifica(){
        if(isGrounded==false){
            m_Animator.SetInteger("States", 4);
        }
        if(Input.GetKeyDown(KeyCode.Q)){
            m_Animator.SetInteger("States", 5);
        }
        if(Input.GetKeyDown(KeyCode.F)){
            m_Animator.SetInteger("States", 6);
        }

    }

    void Jump() {
        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded || Time.time - lastTimeGrounded <= rememberGroundedFor || additionalJumps > 0)) {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            additionalJumps--;
            m_Animator.SetInteger("States", 3);
        }
    }
    void BetterJump() {
        if (rb.velocity.y < 0) {
            rb.velocity += Vector2.up * Physics2D.gravity * (fallMultiplier - 1) * Time.deltaTime;
        } else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space)) {
            rb.velocity += Vector2.up * Physics2D.gravity * (lowJumpMultiplier - 1) * Time.deltaTime;
        }   
    }

    void CheckIfGrounded() {
        Collider2D colliders = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer);
        if (colliders != null) {
            isGrounded = true;
            additionalJumps = defaultAdditionalJumps;
        } else {
            if (isGrounded) {
                lastTimeGrounded = Time.time;
            }
            isGrounded = false;
        }
    }

    void Move() { 
        float x = Input.GetAxisRaw("Horizontal"); 
         if (Input.GetAxisRaw ("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f) 
        {
            if (Input.GetAxisRaw ("Horizontal") > 0.5f && !facingRight) 
            {
                Flip ();
                facingRight = true;
            } else if (Input.GetAxisRaw("Horizontal") < 0.5f && facingRight) 
            {
                Flip ();
                facingRight = false;
            }
        }
        m_Animator.SetInteger("States", x == 0 ? 0: 1);
        float moveBy = x * speed; 
        rb.velocity = new Vector2(moveBy, rb.velocity.y); 

    }
    void Flip()
    {
        facingRight = !facingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    
}
