using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetObject : MonoBehaviour
{
    public GameObject ParentGmeObjt;
    public GameObject Parent2;
    public GameObject tomatosalad;
    public GameObject tomatoSoup;
    public GameObject tomatoBread;
    public GameObject brainBread;
    public GameObject hotBrain;
    private float cldwnRate = 0.5f;
    private float cooldown = 0f;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("a") && ParentGmeObjt.transform.childCount > 0 && cooldown < Time.time){
            if (Parent2.transform.childCount == 0){
                Debug.Log("iuiuiuiuiyiyuyhuigvguvfycftxdxd");
                ParentGmeObjt.transform.GetChild(0).transform.SetParent(Parent2.transform);
                Parent2.transform.GetChild(0).transform.position = Parent2.transform.position;
            }
            else if(Parent2.transform.GetChild(0).name == "Plate"){
                string cooked = Parent2.transform.GetChild(0).transform.GetChild(0).name;
                if (cooked == "Tomatoes(Clone)")
                {
                    if(ParentGmeObjt.transform.GetChild(0).name == "BSalad(Clone)") {
                            Destroy(ParentGmeObjt.transform.GetChild(0));
                            Destroy(Parent2.transform.GetChild(0).transform.GetChild(0));
                            GameObject obj = Instantiate(tomatosalad, Parent2.transform.GetChild(0).transform.position, Quaternion.identity) as GameObject;
                            obj.transform.SetParent(Parent2.transform);
                    }
                }
                else if (cooked == "BSalad(Clone)")
                {
                    if(ParentGmeObjt.transform.GetChild(0).name == "Tomatoes(Clone)") {
                            Destroy(ParentGmeObjt.transform.GetChild(0));
                            Destroy(Parent2.transform.GetChild(0).transform.GetChild(0));
                            GameObject obj = Instantiate(tomatosalad, Parent2.transform.GetChild(0).transform.position, Quaternion.identity) as GameObject;
                            obj.transform.SetParent(Parent2.transform);
                    }
                }
                else if (cooked == "Soup(Clone)"){
                    switch(ParentGmeObjt.transform.GetChild(0).name) {
                        case "Soup(Clone)" :
                            Destroy(ParentGmeObjt.transform.GetChild(0));
                            Destroy(Parent2.transform.GetChild(0).transform.GetChild(0));
                            GameObject obj = Instantiate(tomatoSoup, Parent2.transform.GetChild(0).transform.position, Quaternion.identity) as GameObject;
                            obj.transform.SetParent(Parent2.transform);
                            break;
                        case "Bread(Clone)":
                            Destroy(ParentGmeObjt.transform.GetChild(0));
                            Destroy(Parent2.transform.GetChild(0).transform.GetChild(0));
                            GameObject obj1 = Instantiate(tomatoBread, Parent2.transform.GetChild(0).transform.position, Quaternion.identity) as GameObject;
                            obj1.transform.SetParent(Parent2.transform);
                            break;
                    }
                }
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
