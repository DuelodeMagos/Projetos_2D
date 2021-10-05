using UnityEngine;
using System.Collections;

public class LaserShot : MonoBehaviour {

    //reference variable for Rigidbody2D
    Rigidbody2D rb;
    //variable for force power
    public float x;
    public float y;
    public float z;
    public float time;

    //will be executed once
    void Start () {
        //reference to Rigidbody2D
        rb = GetComponent < Rigidbody2D > ();
        //declare Vector3 with force value on Y-axe
        Vector3 directon = new Vector3 (x, y, z);
        //add force push on rigidbody2D for moving on Y-axe
        rb.AddForce (directon, ForceMode2D.Impulse);
        Invoke("destroi", time);
    }
    //will be executed, if the gameobject is not rendering anymore on the screen
    void OnBecameInvisible () {
        //delete this gameobject from the scene
        Destroy (gameObject);
    }
    void destroi(){
        Destroy (gameObject);
    }
}