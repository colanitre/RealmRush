using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField] List<Waypoint> path;
    [SerializeField] float dwellTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(FollowPath());
    }

    IEnumerator FollowPath()
    {
        print("Starting patrol");
        foreach (Waypoint waypoint in path)
        {
            transform.position = waypoint.transform.position;
            print("Visiting block:" + waypoint);
            yield return new WaitForSeconds(dwellTime);
        }
        print("Ending patrol");
    }
}
