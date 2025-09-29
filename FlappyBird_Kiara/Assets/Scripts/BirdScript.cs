using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(AudioSource))]
public class BirdScript : MonoBehaviour
{
    //TODO: Change to conform to expectations of teacher

    public bool isAlive = true;

    public float flapStrength;

    public AudioClip flapSound;
    public AudioClip collisionSound;

    private Rigidbody2D rigidBody;
    private AudioSource audioSource;
    private Animator animator;
    private GameLogicScript gameLogic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        gameLogic = GameObject.FindGameObjectWithTag("GameLogic").GetComponent<GameLogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float minY = Camera.main.transform.position.y - Camera.main.orthographicSize - 3.0f;

        //OnBecameInvisible() does not work, as we don't have a sprite renderer
        //in the player gameobject with this script
        //Upper bound is handled by ceiling
        //act like we hit something offscreen
        if (transform.position.y < minY && isAlive)
        {
            audioSource.PlayOneShot(collisionSound);
            Die();
        }

        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
            Flap();
    }

    // Flap bird wings and go up.
    private void Flap()
    {
        rigidBody.linearVelocity = Vector2.up * flapStrength;
        audioSource.PlayOneShot(flapSound);
        animator.SetTrigger("Flap");
    }

    private void Die()
    {
        isAlive = false;
        gameLogic.GameOver();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isAlive)
        {
            audioSource.PlayOneShot(collisionSound);
            Die();
        }
    }
}
