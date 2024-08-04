using UnityEngine;

public class BallMovement : MonoBehaviour {
    private Rigidbody2D rb;

    private bool isBallLaunched;
     
    [SerializeField] private Vector2 force;

    void Start() {
       rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if (Input.GetButtonDown("Launch") && !isBallLaunched) {
            Launch();
        }
    }

    private void Launch() {
        isBallLaunched = true;
        
        rb.AddForce(force);
        
        transform.parent = null;
    }
}