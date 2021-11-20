using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jetpack : MonoBehaviour
{
    public float jumpForce = 100f;
    private AudioSource JepackAudio;
    public AudioClip jetSound;


    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            Animator anim = collision.gameObject.GetComponent<Animator>();
            AudioSource audio = collision.gameObject.GetComponent<AudioSource>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
                anim.SetTrigger("Jetpack_trig");
                audio.PlayOneShot(jetSound, 1.0f);
                Destroy(gameObject);
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
