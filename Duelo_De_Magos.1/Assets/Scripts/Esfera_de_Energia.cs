using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera_de_Energia : MonoBehaviour
{
    Vector3 clickPos;
    //we will use this vector as velocity for Rigidbody2D (direction and speed)
    Vector3 move;
    //variable for players speed
    public float speed = 1;
    //we will need reference to Players Rigidbody2D
    Rigidbody2D rb;
    // Start is called before the first frame update
    public Transform point1;
    public Transform point2;
    public Transform point3;
    public Transform point4;
    public Transform point5;
    public static int contEsferas;

   void Start () {
        //reference to Players Rigidbody2D
        rb = GetComponent < Rigidbody2D > ();
        //player should stay on its place at game start (or it will move to clickPos (0,0,0) as default Vector3)
        clickPos = transform.position;
    }

    // Update is called once per frame
   void Update () {
        //check if left mouse button is pressed
        if (Input.GetMouseButton (0)) {
        //transform mouse screen position to world position
        clickPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
        }
        //calculate direction vector from ship to clicked point
        move = clickPos - transform.position;
        
    }

    void FixedUpdate () {
        //change velocity to calculated moving vector
        //z will stay zero. Our ship should not move on Z-Axe
        rb.velocity = new Vector2 (move.x, move.y) * speed;
    }
}
