using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameEnded = false;
    public float restart_delay = 2f;
    public GameObject completelevelUI;
    public Playermovement movement;

    public void Completelevel()
    {
        completelevelUI.SetActive(true);
        movement.enabled = false;
    }

    public void EndGame()
    {
        if (!gameEnded)
        {
            Debug.Log("GAME OVER");
            gameEnded = true;
            Invoke("Restart", restart_delay); 
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
