using UnityEngine;
using UnityEngine.UIElements;

public class Spawners : MonoBehaviour
{
    public GameObject Maca,Cenoura,Banana; // Bons
    public GameObject Pirulito, Chips; //Ruim
    public GameObject Chocolate; //Bost 

    public GameObject spawners;

    public float VelSpawn;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float NumAleatorio = Random.Range(2.0f, 8.0f);

        Debug.Log(NumAleatorio);

        Invoke("InvocarAlgo", NumAleatorio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void InvocarAlgo()
    {
        GameObject Sla = Instantiate(Maca,spawners.transform.position,Quaternion.identity);
        Rigidbody2D RdbgSpawn = Sla.GetComponent<Rigidbody2D>();
        RdbgSpawn.linearVelocityX = -20; 
        float NumAleatorio = Random.Range(2.0f, 8.0f);
        Invoke("InvocarAlgo", NumAleatorio);
        Destroy(Sla,5f);
    }

    

}
