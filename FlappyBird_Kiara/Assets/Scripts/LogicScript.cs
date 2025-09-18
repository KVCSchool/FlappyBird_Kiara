using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    //TODO: Change to conform to expectations of teacher

    public int playerScore;

    public Text scoreText;

    [ContextMenu("Increase score")]
    public void AddScore(int val)
    {
        playerScore += val;

        scoreText.text = playerScore.ToString();
    }
}
