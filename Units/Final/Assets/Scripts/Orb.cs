using UnityEngine;
using System.Threading;

public class Orb : MonoBehaviour
{
    public AudioSource source;

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
            source.Play();
            gameObject.SetActive(false);
            hasOrb = true;
        }
    }
}
