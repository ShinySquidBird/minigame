using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFast : MonoBehaviour
{
    private float speed = 10f;

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
            Invoke("ResetSpeed", 2);
        }

    }
    private void ResetSpeed ()
    {
        speed = 10f;
    }
}
