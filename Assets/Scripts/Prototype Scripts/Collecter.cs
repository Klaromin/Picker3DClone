using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecter : MonoBehaviour
{
 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Collectables")
        {
            collision.gameObject.transform.SetParent(this.transform);
            //collision.rigidbody.AddForce(-1, 0, 0);

        }

    }
}
