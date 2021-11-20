using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedMonster : MonoBehaviour
{
    private Vector3 forward;

    private float direction;
    public float jumpForce = 10f;
    public GameObject doodler;
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
                Destroy(gameObject);
            }
        }


        if (collision.gameObject.CompareTag("Projectile"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

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
