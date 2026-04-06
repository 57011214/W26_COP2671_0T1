using UnityEngine;

public class Orb : MonoBehaviour
{

    public bool hasOrb = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            gameObject.SetActive(false);
            hasOrb = true;
        }
    }
}
