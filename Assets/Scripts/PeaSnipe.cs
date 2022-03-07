using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeaSnipe : MonoBehaviour
{
    private float cldwnRate = 1.5f;
    private float cooldown = 0f;
    public Transform recept;
    public Transform Look;
    public GameObject toInit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void OnTriggerStay(Collider other)
    {
        if (other.name == "Zomb"){
            Look.transform.LookAt(other.gameObject.transform.position);
            if (cooldown < Time.time){
                cooldown = cldwnRate + Time.time;
                GameObject obj = Instantiate(toInit, recept.transform.position, Quaternion.identity) as GameObject;
                obj.transform.SetParent(recept.gameObject.transform);
                obj.layer = 7;
                obj.GetComponent<Bullet>().toSee = other.gameObject.transform;
                Destroy(obj, 4f);
            }
        }
    }
}
