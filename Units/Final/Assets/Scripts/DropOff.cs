using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DropOff : MonoBehaviour
{
    public AudioSource source;
    public Orb orbScript;
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}
