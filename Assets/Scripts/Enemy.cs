using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    float health;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "PProjectile")
        {
            health -= 1;
        }
        if (health <= 0)
        {
            SpawnManager.instance.enemiesKilled++;
            Debug.Log("Enemies killed in current wave: " + SpawnManager.instance.enemiesKilled);

            Destroy(this.gameObject);
        }
            
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
