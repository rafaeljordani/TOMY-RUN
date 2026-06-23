using UnityEngine;

public class ControlerDeleteAndADD : MonoBehaviour
{
    public GameObject Player;
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
        if (collision.gameObject.CompareTag("NuvemInfinntyJump"))
        {
            Destroy(collision.gameObject);
            Player.GetComponent<SpawnersNuvem>().NuvensExistem -= 1;
            Debug.Log("destruio o objeto");
            Player.GetComponent<SpawnersNuvem>().SpawnNuvem();
        }

    }
}
