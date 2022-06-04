using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    private float _forceMagnitude = 3f;
    [SerializeField] BoxCollider right;
    [SerializeField]  BoxCollider left;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Collectables")
        {
           collision.gameObject.GetComponent<Rigidbody>().AddForce(0, 0, 3);
        }
    }
}
