using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Game Quit");
        Application.Quit();
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }
}
