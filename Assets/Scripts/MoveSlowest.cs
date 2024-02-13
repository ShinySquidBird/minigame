using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSlowest : MonoBehaviour
{
    private float speed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ink"))
        {
            speed = 0f;
            Invoke("ResetSpeed", 5);

        }

    }

    private void ResetSpeed()
    {
        speed = 2.5f;
    }

}
