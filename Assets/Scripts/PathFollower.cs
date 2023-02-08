using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    //[SerializeField]
    //private WaypointPath path;          // the path we are following
    //private Transform sourceWP;         // the waypoint transform we are travelling from
    //private Transform targetWP;         // the waypoint transform we are travelling to
    //private int targetWPIndex = 0;      // the waypoint index we are travelling to

    //private float totalTimeToWP;        // the total time to get from source WP to targetWP
    //private float elapsedTimeToWP = 0;  // the elapsed time (sourceWP to targetWP)
    //private float speed = 3.0f;         // movement speed
    

     void Start()
    {
        
    }

    void Update()
    {
        
    }


    // Determine what waypoint we are going to next, and set associated variables
    private void TargetNextWaypoint()
    {
        // reset the elapsed time

        // determine the source waypoint

        // determine the target waypoint

        // if we exhausted our waypoints, go the to first waypoint

        // calculate source to target distance

        // calculate time to waypoint
    }

    // Travel towards the target waypoint (call this from FixedUpdate())
    private void MoveTowardsWaypoint()
    {
        // calculate the elapsed time spent on the way to this waypoint

        // calculate percent complete

        // move

        // check if we've reached our waypoint (based on time). If so, target the next waypoint
    }
}
