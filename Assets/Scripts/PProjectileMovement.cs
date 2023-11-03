using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PProjectileMovement : MonoBehaviour
{
    [SerializeField]
    float speed;

    float verticalBoundary = 10f;
    float horizontalBoundary = 15f;

    Vector3 destination;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy") 
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        destination.z = 0; 
        destination = destination.normalized;
    }

    void Update()
    {
        transform.Translate(destination * speed * Time.deltaTime);
        DontGoOffScreen();
    }
    void DontGoOffScreen()
    {
        if (transform.position.y > verticalBoundary)
            Destroy(gameObject);
        else if (transform.position.y < -verticalBoundary)
            Destroy(gameObject);
        else if (transform.position.x < -horizontalBoundary)
            Destroy(gameObject);
        else if (transform.position.x > horizontalBoundary)
            Destroy(gameObject);
    }
}
