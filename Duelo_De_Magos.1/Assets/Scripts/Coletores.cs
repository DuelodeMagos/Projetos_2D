using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletores : MonoBehaviour
{
    public static int ContFogo;
    public static int ContAgua;
    public static int ContTerra;
    public static int ContAr;
    public static int ContGravidade;
    public static int ContRaio;
    public static int ContSombras;


    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name=="Runa_Fogo"){
            ContFogo++;
        }
        if(col.gameObject.name=="Runa_Agua"){
            ContAgua++;
        }
        if(col.gameObject.name=="Runa_Terra"){
            ContTerra++;
        }
        if(col.gameObject.name=="Runa_Ar"){
            ContAr++;
        }
        if(col.gameObject.name=="Runa_Gravidade"){
            ContGravidade++;
        }
        if(col.gameObject.name=="Runa_Sombras"){
            ContSombras++;
        }
        if(col.gameObject.name=="Runa_Raio"){
            ContRaio++;
        }
        Debug.Log(col.gameObject.name);
    }
}
