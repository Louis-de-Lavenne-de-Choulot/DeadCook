using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{
    public GameObject tomatoes;
    public GameObject salad;
    public GameObject brain;
    public GameObject ParentGmeObjt;
    public GameObject Parent2;
    private float cldwnRate = 0.5f;
    private float cooldown = 0f;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("a") && ParentGmeObjt.transform.childCount > 0 && Parent2.transform.childCount == 0 && cooldown < Time.time){
            switch(ParentGmeObjt.transform.GetChild(0).name){
                case "Tomato(Clone)":
                    GameObject obj = Instantiate(tomatoes, Parent2.transform.position, Quaternion.identity);
                    obj.transform.SetParent(Parent2.transform);
                    obj.layer = 7;
                    Destroy(ParentGmeObjt.transform.GetChild(0).gameObject);
                    break;
                case "Salad(Clone)":
                    GameObject obj1 = Instantiate(salad, Parent2.transform.position, Quaternion.identity);
                    obj1.transform.SetParent(Parent2.transform);
                    obj1.layer = 7;
                    Destroy(ParentGmeObjt.transform.GetChild(0).gameObject);
                    break;
                case "Brain(Clone)":
                    GameObject obj2 = Instantiate(brain, Parent2.transform.position, Quaternion.identity);
                    obj2.transform.SetParent(Parent2.transform);
                    obj2.layer = 7;
                    Destroy(ParentGmeObjt.transform.GetChild(0).gameObject);
                    break;
            }
            cooldown = cldwnRate + Time.time;
        }
        else if(Input.GetKeyDown("a") && Parent2.transform.childCount > 0 && ParentGmeObjt.transform.childCount == 0 && cooldown < Time.time){
            Parent2.transform.GetChild(0).transform.SetParent(ParentGmeObjt.transform);
            ParentGmeObjt.transform.GetChild(0).transform.position = ParentGmeObjt.transform.position;
            cooldown = cldwnRate + Time.time;
        }
    }
}
