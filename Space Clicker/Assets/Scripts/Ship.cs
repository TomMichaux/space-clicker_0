using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{

    private float shipWidth;

    [SerializeField] private float resetXPosition;

    [SerializeField] private float speedX;

    private GameManager game;

    [SerializeField] int scoreAmount;

    void Start()
    {
        game = FindFirstObjectByType<GameManager>();

        shipWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        transform.position = transform.position + new Vector3(speedX * Time.deltaTime, 0f, 0f);

        if (transform.position.x + (shipWidth / 2f) < -10)
        {

            transform.position = new Vector3(resetXPosition, transform.position.y, transform.position.z);
        }
    }   

    private void OnMouseDown()
    {
    
        game.AddScore(scoreAmount);

        
        transform.position = new Vector3(resetXPosition, Random.Range(-4, 4), transform.position.z);
    }
}
