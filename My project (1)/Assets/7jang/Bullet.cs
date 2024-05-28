using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    Rigidbody rb;
   
    public float speed = 8f;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            playercontroll playercontroll = other.GetComponent<playercontroll>();
            if(playercontroll != null)
            {
                playercontroll.die();
            }
        
        
        }







    }







}
