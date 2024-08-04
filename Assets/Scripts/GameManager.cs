using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    private int blocksLeft;

    void Start() {
        blocksLeft = GameObject.FindGameObjectsWithTag("Block").Length;
    }

    public void DecreaseBlock() {
        blocksLeft--;

        if (blocksLeft == 0) {
            LoadNextScene();
        }
    }

    public void RestartScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadNextScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CloseGame() {
        Application.Quit();
    }
}
