using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField]
    float cooldown;
    [SerializeField]
    GameObject ammoObj;
    void Start()
    {
        InvokeRepeating("Shoot", cooldown/2, cooldown);
    }

    void Update()
    {
        
    }

    void Shoot()
    {
        Instantiate(ammoObj, transform.position, transform.rotation);
    }
}
