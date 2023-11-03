using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    GameObject ammoObj;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1") )//&& !SpawnManager.instance.suppressActions)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(ammoObj, transform.position, transform.rotation);
    }
}
