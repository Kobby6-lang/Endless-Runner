using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
     int score;
    public static GameManager inst;

    [SerializeField] Text ScoreText;
    [SerializeField] PlayerMovement playerMovement;
    public void IncrementScore ()
    {
        score++;
        ScoreText.text = "SCORE: " + score;
        // Increase the player's speed
        playerMovement.speed += playerMovement.speedIncreasePerPoint;
    }

    private void Awake() 
    {
        inst = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Something happen");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
