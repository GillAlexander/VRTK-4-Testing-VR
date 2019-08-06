using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliceColission : MonoBehaviour
{
    float timer = 0;
    void Update()
    {
        timer += Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (timer > 1)
        {

            SliceScript.Cut(collision.transform, transform.position);
            timer = 0;
        }
    }
}
