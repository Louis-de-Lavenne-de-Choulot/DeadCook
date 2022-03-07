using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadBOOM : MonoBehaviour
{
    GameObject ToDestroy;
    int life = 2;
    // Start is called before the first frame update
    void Start()
    {
        ToDestroy = transform.parent.gameObject;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Pea(Clone)"){
            Destroy(other.gameObject);
            life -= 1;
            if (life < 0){
                Destroy(ToDestroy, 1f);
            }
        }
    }
}
