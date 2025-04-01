using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private GameObject _gameOverCanvas;

    // Make GameManager a singleton
    private void Awake()
    {
      if(instance == null){
        instance = this;
      }   
      // Reset Time
      Time.timeScale = 1f;
    }

    public void GameOver()
    {
      // Show the GameOver Screen and Stop the Time
        _gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame(){
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
