using UnityEngine;

public class BirdScript : MonoBehaviour
{
    //TODO: Change to conform to expectations of teacher

    public bool isAlive = true;

    public float flapStrength;

    public Rigidbody2D RigidBody;
    private LogicScript logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
            RigidBody.linearVelocity = Vector2.up * flapStrength;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
        logic.GameOver();
    }
}
