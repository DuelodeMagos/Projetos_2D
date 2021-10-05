using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frutas : MonoBehaviour
{
    public GameObject collected;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="Player")
        {
            collected.SetActive(true);
            Invoke("DestroyFruta", 0.2f);
        }    
    }
    
    void DestroyFruta(){
        Destroy(gameObject);
    }
}
