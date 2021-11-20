using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformMove : MonoBehaviour
{
    private Vector3 forward;

    private float direction;
    public float jumpForce = 10f;
    private AudioSource plateformAudio;
    public AudioClip jumpSound;
    // Start is called before the first frame update
    private void Start()
    {
        direction = Random.Range(0f, 1f);
        plateformAudio = GetComponent<AudioSource>();
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
                plateformAudio.PlayOneShot(jumpSound, 1.0f);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        forward = new Vector3(1, 0, 0);
        if (direction < 0.5)
            transform.Translate(-forward * Time.deltaTime);
        if (direction >= 0.5)
            transform.Translate(forward * Time.deltaTime);
        if (transform.position.x >= 2)
            direction = 0;
        if (transform.position.x <= -2)
            direction = 1;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
