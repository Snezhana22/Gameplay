using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable: MonoBehaviour
{
    [SerializeField]
    private float _speedRotate = 0.6f;
    public float SpeedRotate => _speedRotate;
    void Start()
    {
        Debug.Log("Start game");
    }

    
    void Update()
    {
       
        transform.Rotate(0, _speedRotate * Time.deltaTime, 0); 
    }
}
