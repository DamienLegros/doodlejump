using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "RightWall")
            transform.position = new Vector3(-3f, transform.position.y, transform.position.z);

        if (other.gameObject.tag == "LeftWall")
            transform.position = new Vector3(3f, transform.position.y, transform.position.z);
    }

}
