using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lowerWeaponShot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //this is where we work with all our shooting stuff 
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    }
}