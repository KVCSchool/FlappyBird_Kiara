using UnityEngine;

public class BirdScript : MonoBehaviour
{
    //TODO: Change to conform to expectations of teacher
    public Rigidbody2D RigidBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //FIXME: Switch to old input manager for this tutorial
        if (Input.GetKeyDown(KeyCode.Space))
            RigidBody.linearVelocity = Vector2.up * 10.0f;
    }
}
