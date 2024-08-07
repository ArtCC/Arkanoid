using Unity.VisualScripting;
using UnityEngine;

public class BallColiision : MonoBehaviour {
    private GameManager gameManager;

    void Start() {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        DestroyIfIsBlock(collision);
    }

    private void OnTriggerEnter2D() {
        gameManager.RestartScene();
    }

    private void DestroyIfIsBlock(Collision2D collision) {
        if (collision.gameObject.CompareTag("Block")) {
            Destroy(collision.gameObject);

            gameManager.DecreaseBlock();
        }
    }
}
