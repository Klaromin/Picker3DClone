using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCounter : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collectables")
        {
            GameManager.Instance.ballNumber++;
            Debug.Log(GameManager.Instance.ballNumber);
            other.gameObject.tag = "Collected";
        }
    }

}
