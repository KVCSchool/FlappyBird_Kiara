using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenLogicScript : MonoBehaviour
{
    // Start the game.
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
