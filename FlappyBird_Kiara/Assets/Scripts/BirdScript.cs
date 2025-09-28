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
    private GameLogicScript gameLogic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        gameLogic = GameObject.FindGameObjectWithTag("GameLogic").GetComponent<GameLogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
            Flap();
    }

    // Flap bird wings and go up.
    private void Flap()
    {
        rigidBody.linearVelocity = Vector2.up * flapStrength;
        audioSource.PlayOneShot(flapSound);
    }

    private void Die()
    {
        isAlive = false;
        gameLogic.GameOver();
    }

    private void OnBecameInvisible()
    {
        //Die if offscreen
        //FIXME: causes an error on exit due this being called after stopping the game (game over screen is enabled after it's been destroyed)

        if (isAlive)
        {
            //act like we hit something offscreen
            audioSource.PlayOneShot(collisionSound);

            Die();
        }
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
