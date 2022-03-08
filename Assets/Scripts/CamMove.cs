using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    private float right = 32F;
    private float left = 38.9F;
    private float top = 4F;
    private float bottom = 11.2F;

    void Update () {
        transform.position = new Vector3 (Mathf.Clamp (transform.position.x, right, left), transform. position.y, Mathf.Clamp (transform.position.z, top, bottom));
    }
}

// Not fully developped because not useful for now
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class CamMove : MonoBehaviour
// {
//     public Transform player;

//     void Update () {
//         transform.position = new Vector3 (Mathf.Clamp (player.position.x, player.position.x+2, player.position.x), transform. position.y, Mathf.Clamp (player.position.z, player.position.z+10, player.position.z));
//     }
// }
