using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundSunSc : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject pivotObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pivotObject.transform.position, new Vector3(0f, 1f, 0f), rotationSpeed * Time.deltaTime);
    }
}
