using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void Game()
    {
        SceneManager.LoadScene("game");
    }

    public void Menu()
    {
        SceneManager.LoadScene("menu");
    }
}
