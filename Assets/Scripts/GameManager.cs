
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public float slowness = 10f;

    public void endGame()
    {
        Time.timeScale = 1 / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;
        Invoke("restartGame", 1 / slowness);
    }

    void restartGame()
    {


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;

    }

}
