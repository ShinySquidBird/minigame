using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMedium : MonoBehaviour
{
    private float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
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

        if (other.gameObject.CompareTag("Squid"))
        {
            if (speed == 0)
            {
                Destroy(gameObject);
                ScoreManager.instance.AddPoints();
                ScoreManager.instance.AddPoints();
            }
        }

    }
    private void ResetSpeed()
    {
        speed = 5f;
    }

}
