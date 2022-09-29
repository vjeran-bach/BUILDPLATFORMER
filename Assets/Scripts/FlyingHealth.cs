using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingHealth : MonoBehaviour


{

    public float health = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (health < 1)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(Input.GetKey(KeyCode.W))
        {
            if (other.gameObject.tag == "Player")
            {
                health -= 3;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            health -= 1f;
            Destroy(other.gameObject);
        }
    }

}
