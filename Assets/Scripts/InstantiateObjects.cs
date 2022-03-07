using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObjects : MonoBehaviour
{
    public GameObject toInstantiate;
    public GameObject ParentGmeObjt;
    // Start is called before the first frame update
    void Start()
    {
    }

    void OnTriggerStay(Collider other){
        if (Input.GetKeyDown("a") && ParentGmeObjt.transform.childCount == 0){
            GameObject obj = Instantiate(toInstantiate, ParentGmeObjt.transform.position, Quaternion.identity);
            obj.transform.SetParent(ParentGmeObjt.transform);
            obj.layer = 7;
        }
    }
}
