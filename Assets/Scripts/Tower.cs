using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{

    [SerializeField] Transform objectToPan;
    [SerializeField] Transform targetEnemy;
    [SerializeField] float attackRange = 30f;
    [SerializeField] GameObject bullet;


    // Update is called once per frame
    void Update()
    {
        objectToPan.LookAt(targetEnemy);
        bullet.SetActive(!targetEnemy.Equals(null) && Vector3.Distance(targetEnemy.transform.position, gameObject.transform.position) < attackRange);
        //bullet.SetActive(targetEnemy.gameObject.activeSelf == true && Vector3.Distance(targetEnemy.position, objectToPan.position) < attackRange);
    }
}
