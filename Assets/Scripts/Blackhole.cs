using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Blackhole : MonoBehaviour
{
    public GameObject doodler;
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, doodler.transform.position) <= 1.1)
        {
            Destroy(doodler);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
