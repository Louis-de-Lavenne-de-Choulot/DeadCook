using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookTowardMouse : MonoBehaviour {

    public Transform Inosuke;
    Animator anim;
    Rigidbody rb;
    public int dash;
    private float cldwnRate = 1.5f;
    private float cooldown = 0f;
    private Vector3 lastPos;

    void Start () 
    {
        lastPos = transform.position;
        anim = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody>();
    }

     // Update is called once per frame
    void Update () 
    {

         //Get the Screen positions of the object
        Vector2 positionOnScreen = Camera.main.WorldToViewportPoint (transform.position);

         //Get the Screen position of the mouse
        Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);

         //Get the angle between the points
        float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);

        double ScreenPos = System.Math.Round(positionOnScreen.normalized[0],3);
        double MousePos = System.Math.Round(mouseOnScreen.normalized[0],3);
        double ScreenPos2 = System.Math.Round(positionOnScreen.normalized[1],3);
        double MousePos2 = System.Math.Round(mouseOnScreen.normalized[1],3);

         //Ta Daaa
        if (Input.GetKey("z") && ScreenPos != MousePos && ScreenPos2 != MousePos2){
            if (Input.GetKeyDown(KeyCode.LeftShift) && cooldown < Time.time){
                rb.AddForce(transform.forward * dash);
                rb.drag = 3;
                cooldown = cldwnRate + Time.time;
            }
            rb.rotation = Quaternion.Euler (new Vector3(0f,-angle+90,0f));
            rb.position += transform.forward * Time.deltaTime * 3f;
            Camera.main.transform.position += transform.forward * Time.deltaTime * 2F;
            anim.SetBool("Run", true);
        }else{
            anim.SetBool("Run", false);
        }
    }

    float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
         return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}
