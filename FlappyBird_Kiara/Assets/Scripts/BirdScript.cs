using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BirdScript : MonoBehaviour
{
    //TODO: Change to conform to expectations of teacher

    public bool isAlive = true;

    public float flapStrength;

    private Rigidbody2D rigidBody;
    private LogicScript logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
            rigidBody.linearVelocity = Vector2.up * flapStrength;
    }

    private void Die()
    {
        isAlive = false;
        logic.GameOver();
    }

    private void OnBecameInvisible()
    {
        //Die if offscreen

        Die();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Die();
    }
}
