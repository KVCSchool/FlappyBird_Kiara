using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    //TODO: Change to conform to expectations of teacher

    public float moveSpeed = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += moveSpeed * Time.deltaTime * Vector3.left;

        //This seems like an awful way to do this, but okay.
        if (transform.position.x < -90.0f)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
