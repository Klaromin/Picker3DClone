using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int ballNumber;
    public bool isFirstCheckpoint = false;
    public bool isLastCheckpoint = false;
    private static GameManager _instance = null;
    
    public static GameManager Instance
    {
        get { if(_instance is null)
            {
                _instance = new GameObject("GameManager").AddComponent<GameManager>();
            }
            return _instance; }
    }
}
