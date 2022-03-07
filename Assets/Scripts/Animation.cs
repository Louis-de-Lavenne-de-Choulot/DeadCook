using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public GameObject activate;
    public GameObject activateIno;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
            animator.SetTrigger("Start");
    }

    // Update is called once per frame
    void Update()
    {
        float NTime = (animator.GetCurrentAnimatorStateInfo(0)).normalizedTime;
        if(NTime > 1.0f)
        {
            gameObject.SetActive(false);
            activateIno.SetActive(true);
            activate.SetActive(true);
        }
    }
}
