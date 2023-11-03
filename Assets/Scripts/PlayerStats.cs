using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [SerializeField]
    int healthPoints;
    [SerializeField]
    Text healthText;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "EProjectile")
        {
            healthPoints--;
            healthText.text = "Health: " + healthPoints.ToString();

            if (healthPoints == 0)
            {
                GameManager.Instance.playerDead = true;
                Destroy(this.gameObject);
            }
        }
    }
   
    void Start()
    {
        healthText.text = "Health: " + healthPoints.ToString();
    }

    void Update()
    {
        
    }
}
