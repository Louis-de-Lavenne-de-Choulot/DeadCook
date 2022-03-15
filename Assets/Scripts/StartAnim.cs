using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnim : MonoBehaviour
{
    public GameObject activate;
    public GameObject activateZomb;
    public GameObject activatePlant;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float AnTime = (anim.GetCurrentAnimatorStateInfo(0)).normalizedTime;
        if(AnTime > 1.0f)
        {
            gameObject.SetActive(false);
            activateZomb.SetActive(true);
            activatePlant.SetActive(true);
            activate.SetActive(true);
        }
    }
}
