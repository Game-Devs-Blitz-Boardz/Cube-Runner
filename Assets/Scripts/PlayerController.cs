using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    Rigidbody rb;
    public float jumpForce;
    bool canJump = true;

    void Awake() {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Ground") {
            canJump = true;
        }
    }

    private void OnCollisionExit(Collision other) {
        if (other.gameObject.tag == "Ground") {
            canJump = false;
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canJump) {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Obstacle") {
            SceneManager.LoadScene("Game");
        }
    }

}
