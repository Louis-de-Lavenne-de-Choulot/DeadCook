using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCount : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.childCount > 0){
            anim.SetBool("Food", true);
        }else{
            anim.SetBool("Food", false);
        }
    }
}
