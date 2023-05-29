using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    private Rigidbody2D rb;
    private float movePosition;
    public float gameAreaWidth;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager = GameObject.FindAnyObjectByType<GameManager>();


    }

    // Update is called once per frame
    void Update()
    {
        movePosition  = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {

        Vector2 newPosition = rb.position + Vector2.right * movePosition * moveSpeed * Time.deltaTime;
        newPosition.x =  Mathf.Clamp(newPosition.x, -gameAreaWidth, gameAreaWidth);
        rb.MovePosition(newPosition);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.endGame();
    }



}
