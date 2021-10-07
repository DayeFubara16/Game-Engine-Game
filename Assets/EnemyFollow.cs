using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;
public class EnemyFollow : MonoBehaviour
{
    [DllImport("GameLaserModifier")]
    private static extern float speedForEnemy();

    [DllImport("GameLaserModifier")]
    private static extern float stoppingDistanceForEnemy();

    //speed that the enemy is going at and a variable that determines the distance 
    //which the enemy is from the its target 
    private float speed;
    private float stoppingDistance;

    //the target that the enemy will look for
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        stoppingDistance = stoppingDistanceForEnemy();
        speed = speedForEnemy();
        //we initialize our target as the player through the player tag 
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Simple if statement that check the distance between player and enemy
        // that will determine the speed at which it will go
        if(Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        
        //else statement slows down the enemy by 2 when "close" (in this case) 
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, (speed/2) * Time.deltaTime);
        }
    }
}
