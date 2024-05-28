using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroll : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 8f;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }




    private void Update()
    {
        float xinput = Input.GetAxis("Horizontal");
        float zinput = Input.GetAxis("Vertical");

        float xspeed = xinput * speed;
        float zspeed = zinput * speed;

        Vector3 newvelocity = new Vector3(xspeed, 0, zspeed);
        rb.velocity = newvelocity;

    
    
    
    
    
    
    
    }

    public void die()
    {
        gameObject.SetActive(false);

        GameManager gameManager = FindAnyObjectByType<GameManager>();
        gameManager.Endgame();
    }
}
