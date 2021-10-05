using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class some : MonoBehaviour
{
    public float time;

    void Update()
    {
        Invoke("destroi", time);
    }
    void destroi(){
        Destroy(gameObject);
    }
}
