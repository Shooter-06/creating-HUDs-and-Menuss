using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  

public class GameManager : MonoBehaviour
{
     
    private static GameManager instance;

    public int score;
    public Text MyText;

    public static GameManager Instance {
        get {
            if(instance==null) {
                instance = new GameManager();
            }
 
            return instance;
        }
    }
    
 
    void Awake()
    {
        instance = this;
    }

    void start()
    {
        MyText.text = "";
    }

    public void UpdateScore()
    {
        score = score + 1;
        MyText.text = "Score: " + score;
        if(score == 10){
            SceneManager.LoadScene(0);  
        }
    }
}
