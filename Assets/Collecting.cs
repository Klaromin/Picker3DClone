using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collecting : MonoBehaviour
{
    [SerializeField] GameObject picker;
    RaycastHit hit;
    Vector3 targetPosition;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "Player")
        //{
        //    collision.transform.parent = this.transform;
        //}

    }
    private void Start()
    {
        //targetPosition = picker.transform.position;
    }
    private void Update()
    {
       
        //int layermask = ~(0 << 12); // Layer of colliders he can pass through (should include himself)

        //if (Physics.Linecast(transform.position, targetPosition, out hit, layermask))
        //{
        //    targetPosition = hit.point;
        //    targetPosition = Vector3.Lerp(transform.position, targetPosition, .001f);
        //}
    }




 }


