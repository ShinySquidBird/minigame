using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float speed = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
