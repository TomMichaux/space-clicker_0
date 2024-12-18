using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI scoreText;


    private int score;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;

        scoreText.text = "Score: " + score;
    }

    public void AddScore(int amount)
    {
        score = score + amount;

        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
