using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bin : MonoBehaviour
{
    public GameObject ParentGmeObjt;
    // Start is called before the first frame update
    void Start()
    {
    }

    void OnTriggerStay(Collider other){
        if (Input.GetKeyDown("a") && ParentGmeObjt.transform.childCount > 0){
            Destroy(ParentGmeObjt.transform.GetChild(0).gameObject);
        }
    }
}
