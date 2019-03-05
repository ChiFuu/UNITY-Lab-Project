using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class Shooter : MonoBehaviour
{   
    public AudioSource audioData;
    
    public GameObject bulletprefab;
    public Transform firepoint;
    private Rigidbody rb;
    private GameObject cannonball,cannonball2;
    
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;

    public float Power;

    void Update()
    {
        
        
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Shoot();
            Destroy(cannonball,2f);
        }
    
    }
    private GameObject Shoot(){
        cannonball=Instantiate(bulletprefab,firepoint.position, firepoint.rotation);
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        rb=cannonball.GetComponent<Rigidbody>();
        rb.AddForce(Power, 0,0, ForceMode.Impulse);
        return cannonball;
    }
}
