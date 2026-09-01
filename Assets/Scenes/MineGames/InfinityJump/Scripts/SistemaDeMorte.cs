using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SistemaDeMorte : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player morreu");
            Destroy(collision.gameObject);
            SceneManager.LoadScene("Gaming");
        }   
    }
}
