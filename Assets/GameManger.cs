using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    bool gameHasEnded = false;
    public float RestartTimer = 2f;

    public void EndGame()
    {
        if (gameHasEnded == false) {
            Debug.Log("end game");
            gameHasEnded = true;
            Invoke("Restart", RestartTimer);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
