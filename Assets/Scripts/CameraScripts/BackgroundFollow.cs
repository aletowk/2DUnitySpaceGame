using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundFollow : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = target.position + Vector3.forward * 5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + Vector3.forward * 5f;
    }
}
