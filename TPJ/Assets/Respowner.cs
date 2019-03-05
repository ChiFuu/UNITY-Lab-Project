using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]

public class Respowner : MonoBehaviour
{
    public AudioSource audioData;
    public float maxHealth;
    private float currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth=maxHealth;  
    }

     void OnCollisionEnter(Collision collision)
        {
        
           if (collision.collider.tag=="Bullet")
            {
                currentHealth-=20;
                Debug.Log(currentHealth);
            }
            
        }
    // Update is called once per frame
    void Update()
    {
       var yposition=this.transform.position.y;
        if ((yposition<-15 )|| (currentHealth <= 0))
        {
           SceneManager.LoadScene(SceneManager.GetActiveScene().name,LoadSceneMode.Single);
        audioData.Play(0);
        }
        
    }
}
