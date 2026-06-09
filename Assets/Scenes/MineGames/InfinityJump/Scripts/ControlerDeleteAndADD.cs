using UnityEngine;

public class ControlerDeleteAndADD : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NuvemInfinntyJump"))
        {
            Destroy(collision.gameObject);
            Debug.Log("destruio o objeto");
        }

    }
}
