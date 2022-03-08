using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    public Transform toSee;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (toSee != null){
            transform.Translate(Vector3.Normalize(toSee.position-transform.position) * 0.8F);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
