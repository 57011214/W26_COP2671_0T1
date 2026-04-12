using UnityEngine;

public class MeteorController : MonoBehaviour
{
    public AudioClip meteorCrash;

    public float moveSpeed = 3f;
    public float changeDirectionTime = 3f;

    private Vector3 targetPosition;
    private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        targetPosition = new Vector3(90, transform.position.y, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        if(transform.position.x > 85) {
            Destroy(gameObject);
        }
    }


    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            AudioSource.PlayClipAtPoint(meteorCrash, transform.position);
            Destroy(gameObject);
            Debug.Log("You Lose!");
        }
    }
}
