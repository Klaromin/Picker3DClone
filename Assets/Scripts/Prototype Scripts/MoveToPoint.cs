using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class MoveToPoint : MonoBehaviour
{
    private Touch _touch;
    private float _dragSpeed = 1.2f;
    private float _cycleLength = 15f;
    private float _limitZ = 10f;
    [SerializeField] Rigidbody _rb;
    [SerializeField] GameObject plane;
    [SerializeField] GameObject plane1;
    private float _stopPoint1;
    private float _stopPoint2;
    public bool isComplete = false;

    void Start()
    {

        Movement();
        
        Debug.Log(plane.GetComponent<MeshRenderer>().bounds.max.x);
        _stopPoint1 = plane.GetComponent<MeshRenderer>().bounds.max.x;
        _stopPoint2 = plane1.GetComponent<MeshRenderer>().bounds.max.x;
        Debug.Log(_stopPoint1);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        Debug.Log(GameManager.Instance.isFirstCheckpoint);
        StartCoroutine(Movement2());
        //Movement2();
        DragControl();
        CheckPointController();
       
        
        //Debug.Log("Transform Position: "+ (Math.Round(transform.position.x,1) + " Stop Point1 " + (_stopPoint1 - 7.5f)));
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Collectables")
    //    {
    //        collision.gameObject.transform.SetParent(this.transform);
    //        collision.rigidbody.AddForce(-1, 0, 0);

    //    }

    //}

    public void DragControl()
    {



        if (Input.touchCount > 0)
        {
            _touch = Input.GetTouch(0);

            if (_touch.phase == TouchPhase.Moved)
            {
                Vector3 pos = transform.position;
                //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + _touch.deltaPosition.x * (-_dragSpeed));
                _rb.velocity = new Vector3(transform.position.x, transform.position.y, transform.position.z + _touch.deltaPosition.x * (-_dragSpeed));
                //_rb.AddForce(new Vector3(transform.position.x, transform.position.y, transform.position.z + _touch.deltaPosition.x * (-_moveSpeed)));
                pos.z = Mathf.Clamp(transform.position.z, -_limitZ, _limitZ);
                transform.position = pos;
            }

        }
    }

    public void Movement()
    {

        transform.DOLocalMoveX(_stopPoint1+49f, _cycleLength);


        

    }
    IEnumerator Movement2()
    {
        yield return new WaitForSeconds(10f);
        if (GameManager.Instance.isFirstCheckpoint)
        {
            transform.DOLocalMoveX(_stopPoint2 - 2.5f, _cycleLength);

        }
    }
    //public void Movement2()
    //{
 
    //}

    public void CheckPointController()
    {
        if (Math.Round(transform.position.x,1) >= (_stopPoint1 -5.5f))
        {
            Debug.Log("oldum?");
            FindObjectOfType<Elevate>().Elevator();
        }
    }

}
