using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float ProjectilForce;
    public Rigidbody2D rb;
    private Rigidbody2D BouleRb;
    public Animator playerAnim;
    public GameObject projectile1;
    public SpriteRenderer spriteRenderer;

    private AudioSource playerAudio;
    public AudioClip ShootSound;
    private Vector3 positionProj;

    private float moveX;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed;
        CheckKeys();
       

    }
    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = moveX;
        rb.velocity = velocity;
        //Flip(rb.velocity.x);


    }

    bool AnimatorIsPlaying()
    {
        return playerAnim.GetCurrentAnimatorStateInfo(0).length > playerAnim.GetCurrentAnimatorStateInfo(0).normalizedTime;
    }

    bool AnimatorIsPlaying(string stateName)
    {
        return AnimatorIsPlaying() && playerAnim.GetCurrentAnimatorStateInfo(0).IsName(stateName);
    }

    void CheckKeys()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)&& AnimatorIsPlaying("Doodler_jetpack")==false && AnimatorIsPlaying("Doodler_helico") == false)
        {
            positionProj = new Vector3(0, 0.5f, 0);
            playerAnim.SetTrigger("Shoot_trig");
            playerAudio.PlayOneShot(ShootSound, 1.0f);
            GameObject Boule = Instantiate(projectile1, transform.position + positionProj, Quaternion.identity) as GameObject;
            BouleRb = Boule.GetComponent<Rigidbody2D>();
            BouleRb.AddForce(Vector3.up * ProjectilForce, ForceMode2D.Impulse);

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            spriteRenderer.flipX = true;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            spriteRenderer.flipX = false;
        }

    }

    void Flip(float _velocity)
    {
        if (_velocity > 0.1f)
        {
            spriteRenderer.flipX = false;
        }
        else if (_velocity < 0.1f)
        {
            spriteRenderer.flipX = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plateform"))
        {
            if (rb.velocity.y < 0.1f)
            {
                //playerAnim.SetTrigger("Jump_trig");
            }
                
        }

    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       
    }
}
