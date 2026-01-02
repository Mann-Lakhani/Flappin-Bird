using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
  public int playScore;
  public TextMeshProUGUI scoreText;
  public GameObject gameOverScreen;

  void Start()
    {
        scoreText.text=playScore.ToString();
    }

  [ContextMenu("Increase Score")]
  public void addScore()
    {
        playScore=playScore+1;
        scoreText.text=playScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void exitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
