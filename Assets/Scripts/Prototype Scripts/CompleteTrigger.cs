using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CompleteTrigger : MonoBehaviour
{
    [SerializeField] GameObject pusher; //gereksiz
    [SerializeField] GameObject plane;
    
    private float _stopPoint;
    private void Start()
    {
        _stopPoint = plane.GetComponent<MeshRenderer>().bounds.max.x;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Collectables"))
        {
            other.gameObject.transform.parent = null;
            other.attachedRigidbody.constraints = RigidbodyConstraints.None;

            

        }
        
        if(other.gameObject.tag == "Player")
        {
            
            pusher.transform.DOMoveX(_stopPoint, 2.5f).OnComplete(() =>pusher.transform.DOLocalMoveX(-5.76f, 2.5f));
            
        }
        
    }

}
