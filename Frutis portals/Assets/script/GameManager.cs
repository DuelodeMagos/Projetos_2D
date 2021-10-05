using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject game;
    public GameObject gameOver;
    public GameObject menu;

    void Start(){
        gameOver.SetActive(false);
    }

    void Update() {
        if(PlayerControl.vida == 0f){
            gameOver.SetActive(true);
        }

   }
   public void menuStart(){
        game.SetActive(true);
        menu.SetActive(false);
        PlayerControl.vida = 10;
   }
 
   public void restart (){
        gameOver.SetActive(false);
        game.SetActive(false);
        menu.SetActive(true);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }

}
