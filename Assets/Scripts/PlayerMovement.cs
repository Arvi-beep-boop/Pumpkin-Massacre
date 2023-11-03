using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float speed = 5;

    float verticalBoundary = 5f;
    float horizontalBoundary = 8f;
    void Start()
    {
        
    }

    void Update()
    {
        HandleMovement();
    }
    private void FixedUpdate()
    {
        /*if(transform.position.x > horizontalBoundary)
        {
            transform.position = new Vector3(horizontalBoundary, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -horizontalBoundary)
        {
            transform.position = new Vector3(-horizontalBoundary, transform.position.y, transform.position.z);
        }
        else if (transform.position.y > verticalBoundary)
        {
            transform.position = new Vector3(transform.position.x, verticalBoundary, transform.position.z);
        }
        else if (transform.position.x < -verticalBoundary)
        {
            transform.position = new Vector3(transform.position.x, -verticalBoundary, transform.position.z);
        }*/
    }

    private void HandleMovement()
    {
        float horizotal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector2 direction = new Vector2(horizotal, vertical).normalized;
        transform.Translate(direction * Time.deltaTime * speed);
    }
}
