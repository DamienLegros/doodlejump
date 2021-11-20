using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    private void LateUpdate()
    {
        if (target.position.y > transform.position.y)
        {
            Vector3 newPosition = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPosition;
        }


        ScoreScript.scoreValue = (int)transform.position.y;
        YourScore.YourscoreValue = (int)transform.position.y;
        if (ScoreScript.scoreValue > highscore.HscoreValue)
        {
            highscore.HscoreValue = ScoreScript.scoreValue;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
