using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogicScript : MonoBehaviour
{
    //TODO: Change to conform to expectations of teacher

    public int playerScore;

    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase score")]
    public void AddScore(int val)
    {
        playerScore += val;

        scoreText.text = playerScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
