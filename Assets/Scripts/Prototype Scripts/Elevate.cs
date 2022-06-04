using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class Elevate : MonoBehaviour
{
    private int _cycleLength = 2;
    [SerializeField] Transform plane1;
    [SerializeField] Transform plane2;

    public void Elevator()
    {
        Debug.Log("last= " +GameManager.Instance.isLastCheckpoint);
        Debug.Log("first= " +GameManager.Instance.isFirstCheckpoint);
        StartCoroutine(ControlSuccess());
       
    }
    IEnumerator ControlSuccess()
    {
        yield return new WaitForSecondsRealtime(1f);
        if (GameManager.Instance.ballNumber > 10)
        {
            
           
            GameManager.Instance.isFirstCheckpoint = true;
            GameManager.Instance.ballNumber = 0;
            
        }
        if (GameManager.Instance.isFirstCheckpoint)
        {
            
            plane1.transform.DOMoveY(0, _cycleLength);
            if(GameManager.Instance.ballNumber > 10)
            {
                GameManager.Instance.isLastCheckpoint = true;
            }
            if (GameManager.Instance.isLastCheckpoint)
            {
                plane2.transform.DOMoveY(0, _cycleLength);
            }
        }

        else
        {
            yield return new WaitForSecondsRealtime(1f);
            SceneManager.LoadScene(1);
            GameManager.Instance.ballNumber = 0;
        }

    }





}
