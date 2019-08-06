using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectileWithCollision : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Sword")
        {
            this.gameObject.GetComponent<Rigidbody>().velocity = (new Vector2(10, 2));
        }
    }
}
