using UnityEngine;

public class MeteorController : MonoBehaviour
{
    public float randomXRange = 70;
    public float randomYRange = 30;
    public float randomZRange = 70;

    public float moveSpeed = 3f;
    public float changeDirectionTime = 3f;

    private Vector3 targetPosition;
    private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetNewTarget();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        timer += Time.deltaTime;
        if(timer >= changeDirectionTime || Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            SetNewTarget();
            timer = 0f;
        }
    }

    void SetNewTarget() {
        float x = Random.Range(randomXRange, -randomXRange);
        float y = Random.Range(randomYRange, -randomYRange);
        float z = Random.Range(randomZRange, -randomZRange);

        targetPosition = new Vector3(x, y, z);
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            Debug.Log("You Lose!");
        }
    }
}
