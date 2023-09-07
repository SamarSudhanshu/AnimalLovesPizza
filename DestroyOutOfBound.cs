using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    private float rightSideBound = 20.0f;
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }


    // Update is called once per frame
    void Update()
    {
        OutOfBound();
    }

    // If an object goes past the player view in the game, remove that object
    void OutOfBound()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            gameManager.AddLives(-1);
        }
        if (transform.position.x > rightSideBound)
        {
            
            Destroy(gameObject);
            gameManager.AddLives(-1);
        }
        if (transform.position.x < -rightSideBound)
        {
            
            Destroy(gameObject);
            gameManager.AddLives(-1);
        }
    }
}
