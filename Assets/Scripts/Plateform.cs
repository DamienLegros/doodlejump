using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateform : MonoBehaviour
{
    public float jumpForce = 10f;
    private AudioSource plateformAudio;
    public AudioClip jumpSound;

    private void Start()
    {
        plateformAudio = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            Animator anim = collision.gameObject.GetComponent<Animator>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
                anim.SetTrigger("Jump_trig");
                plateformAudio.PlayOneShot(jumpSound, 1.0f);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnBecameInvisible()
    {
        DestroyImmediate(gameObject);
    }
}
