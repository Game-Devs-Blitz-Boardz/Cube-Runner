using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnBecameInvisible() {
        Destroy(gameObject);
    }
}
