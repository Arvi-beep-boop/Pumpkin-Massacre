using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    GameObject followObj;
    [SerializeField]
    float speed; 

    Vector3 direction;

    void Start()
    {
        followObj = GameObject.FindGameObjectWithTag("Player");
        InvokeRepeating("DirectionVec", 0, 1);

    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    void DirectionVec()
    {
        direction = (followObj.transform.position - transform.position).normalized; 
    }

}
