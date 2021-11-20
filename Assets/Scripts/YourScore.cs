using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class YourScore : MonoBehaviour
{
    public static int YourscoreValue = 0;
    public TMP_Text Hscore;
    // Start is called before the first frame update
    void Start()
    {
        Hscore = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Hscore.text = "Your Score : " + YourscoreValue;
    }
}
