using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public float jumpForce = 1f;
    public Animator JumperAnim;
    private AudioSource JumperAudio;
    public AudioClip jumperSound;
    // Start is called before the first frame update

    void Start()
    {
        JumperAnim = GetComponent<Animator>();
        JumperAudio = GetComponent<AudioSource>();
    }

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
                JumperAnim.SetTrigger("Bound_trig");
                JumperAudio.PlayOneShot(jumperSound, 1.0f);
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
