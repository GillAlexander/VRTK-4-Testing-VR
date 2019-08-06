using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRocket : MonoBehaviour
{
    public GameObject Rocket;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(Rocket, this.transform, true);
        }
    }
}
