using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mecanica_Conjuracao : MonoBehaviour
{    
    public GameObject Fogo;
    public GameObject Agua;
    public GameObject Ar;
    public GameObject Terra;
    public GameObject Raio;
    public GameObject Gravidade;
    public GameObject Sombras;
    public GameObject F;
    public GameObject G;
    public int cont=0;
    public static bool fogo;
    public static bool agua;
    public static bool ar;
    public static bool terra;
    public static bool gravidade;
    public static bool sombras;
    public static bool raio;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Z)&&Coletores.ContFogo>0){
           Fogo.SetActive(true);
           fogo=true;
           cont++;
       }
       if(Input.GetKeyDown(KeyCode.X)&&Coletores.ContAgua>0){
           Agua.SetActive(true);
           agua=true;
           cont++;
       }
       if(Input.GetKeyDown(KeyCode.C)&&Coletores.ContAr>0){
           Ar.SetActive(true);
           ar=true;
           cont++;
       }
       if(Input.GetKeyDown(KeyCode.V)&&Coletores.ContTerra>0){
           Terra.SetActive(true);
           terra=true;
           cont++;
       }
       if(Input.GetKeyDown(KeyCode.N)&&Coletores.ContGravidade>0){
           Gravidade.SetActive(true);
           gravidade=true;
           cont++;
       }
       if(Input.GetKeyDown(KeyCode.B)&&Coletores.ContRaio>0){
           Raio.SetActive(true);
           raio=true;
           cont++;
       }
       if(Input.GetKeyDown(KeyCode.M)&&Coletores.ContSombras>0){
           Sombras.SetActive(true);
           sombras=true;
           cont++;
       }
       if(cont>1){
           F.SetActive(true);
           G.SetActive(true);
       }
       if(Input.GetKeyDown(KeyCode.G)||Input.GetKeyDown(KeyCode.F)){
           Fogo.SetActive(false);
           Agua.SetActive(false);
           Ar.SetActive(false);
           Terra.SetActive(false);
           Gravidade.SetActive(false);
           Raio.SetActive(false);
           Sombras.SetActive(false);
           F.SetActive(false);
           G.SetActive(false);
           cont=0;
       }
       if(Input.GetKeyDown(KeyCode.F)){
           Fogo.SetActive(false);
           Agua.SetActive(false);
           Ar.SetActive(false);
           Terra.SetActive(false);
           Gravidade.SetActive(false);
           Raio.SetActive(false);
           Sombras.SetActive(false);
           F.SetActive(false);
           G.SetActive(false);
           cont=0;
       }
    }
}
