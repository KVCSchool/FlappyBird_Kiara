using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    //TODO: Change to conform to expectations of teacher

    private GameLogicScript gameLogic;

    void Start()
    {
        gameLogic = GameObject.FindGameObjectWithTag("GameLogic").GetComponent<GameLogicScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        const int BirdLayer = 3;

        if (collision.gameObject.layer == BirdLayer)
            gameLogic.AddScore(1);
    }
}
