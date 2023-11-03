using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    [SerializeField]
    float speed;

    Vector3 direction;
    float verticalBoundary = 10f;
    float horizontalBoundary = 15f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        GameObject player = GameObject.Find("Player");
        direction = (player.transform.position - transform.position).normalized;
    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
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
