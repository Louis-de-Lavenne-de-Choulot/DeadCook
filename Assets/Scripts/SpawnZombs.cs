using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombs : MonoBehaviour
{
    public GameObject toInit;
    public GameObject toInit2;
    float invocationNumber;
    public Transform recept;
    public Transform end;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ZombsInvocation", 0f, 25f);
    }

    // Update is called once per frame
    
    private void ZombsInvocation()
    {
        if (invocationNumber%10 == 0){
            GameObject obj = Instantiate(toInit2, recept.position, Quaternion.identity) as GameObject;
            UnityEngine.AI.NavMeshAgent nobj = obj.GetComponent<UnityEngine.AI.NavMeshAgent>();
            nobj.speed = 1;
            nobj.destination = end.position;
            obj.transform.SetParent(gameObject.transform);
            obj.layer = 7;
        }
        else{
            GameObject obj = Instantiate(toInit, recept.position, Quaternion.identity) as GameObject;
            UnityEngine.AI.NavMeshAgent nobj = obj.GetComponent<UnityEngine.AI.NavMeshAgent>();
            nobj.speed = 1;
            nobj.destination = end.position;
            obj.transform.SetParent(gameObject.transform);
            obj.layer = 7;
        }
        invocationNumber++;
    }
}
