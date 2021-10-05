using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public static bool gameOver=false;
    public static bool win=false;
    public static float vida = 10;

    private float horizontal;
    private float vertical;

    public float speed;
    public float jumpForce;
    public bool isGround;
    private bool jump=false;

    private Rigidbody2D _Rigidbody;
    private SpriteRenderer _renderer;
    private Animator _Animator;
    public LayerMask LayerGround;
    public Transform groundcheck;

    void Start()
    {
        _Animator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>(); 
        _Rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Moviment();
        OnJump();
        Flip();
    }


    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="Trap")
        {
            vida--;
        }
        else if(other.tag=="Win")
        {
            win=true;
        }
        if(other.tag=="Frutas")
        {
            //GameManager.pontos++;
        }
        if(other.tag == "Portal_1"){
            transform.position = new Vector3(-27.8f , 6f ,-6.26f);
        }
    }

    void OnJump(){
        if (Input.GetKeyDown(KeyCode.Space) && isGround && !jump){
            Jump(true, 2);
        }
        else if(Input.GetKeyDown(KeyCode.Space)&& jump){
             Jump(false, 3);
        }
    }

    void Jump(bool jumpp, int estado){
        _Rigidbody.AddForce (new Vector2(0,jumpForce));
        jump = jumpp;
        _Animator.SetInteger("estado", estado);
    }

    void Flip(){
        if (Input.GetAxisRaw("Horizontal")>0){
            _renderer.flipX = false;
        }
        else if(Input.GetAxisRaw("Horizontal")<0){
             _renderer.flipX = true;          
        }
    }

    void Moviment(){
        isGround = Physics2D.OverlapCircle(groundcheck.position, 0.15f, LayerGround);

        horizontal=Input.GetAxis("Horizontal");
        vertical=Input.GetAxis("Vertical");
        transform.position = new Vector2((horizontal*speed)+transform.position.x,transform.position.y); 

        if(Input.GetAxisRaw("Horizontal") == 0 && isGround){
            _Animator.SetInteger("estado",0);
        }
        if((Input.GetAxisRaw("Horizontal")>0 || Input.GetAxisRaw("Horizontal")<0)){
            _Animator.SetInteger("estado",1);
        } 
        
    }
}

