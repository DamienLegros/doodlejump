using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformBroke : MonoBehaviour
{
    public float jumpForce = 10f;
    public Animator plateformAnim;
    private bool is_broken;
    private Vector3 forward;
    private AudioSource plateformAudio;
    public AudioClip crackSound;
    // Start is called before the first frame update
    void Start()
    {
        plateformAnim = GetComponent<Animator>();
        is_broken = false;
        plateformAudio = GetComponent<AudioSource>();

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
               plateformAnim.SetTrigger("Broke_trig");
               plateformAudio.PlayOneShot(crackSound, 1.0f);
               is_broken = true;

            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (is_broken == true)
        {
            forward = new Vector3(0, 1, 0);
            transform.Translate(-forward * Time.deltaTime);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
