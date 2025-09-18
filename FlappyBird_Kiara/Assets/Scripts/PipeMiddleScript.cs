using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    //TODO: Change to conform to expectations of teacher

    private LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        const int BirdLayer = 3;

        if (collision.gameObject.layer == BirdLayer)
            logic.AddScore(1);
    }
}
