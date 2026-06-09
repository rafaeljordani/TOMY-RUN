using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawners : MonoBehaviour
{
    public GameObject Maca,Cenoura,Banana; // Bons
    public GameObject Pirulito, Chips; //Ruim
    public GameObject Chocolate; //Bost 

    public List<GameObject> ItensColetaveis; //lista para poder aleatorizar o spawn de objetos
    public GameObject spawners;
    public float VelSpawn;
    public int NumItem;



    
    void Start()
    {
        float NumAleatorio = Random.Range(2.0f, 8.0f);

        Debug.Log(NumAleatorio);

        Invoke("InvocarAlgo", NumAleatorio);

        
    }

  
    void Update()
    {
        
    }


    public void InvocarAlgo()
    {

        NumItem = Random.Range(0, ItensColetaveis.Count);
        //Sistema de spawn aleatorio de obejto 

        GameObject Item = Instantiate(ItensColetaveis[NumItem], spawners.transform.position,Quaternion.identity);
        //aqui ele da spawn no objeto

        Rigidbody2D RdbgSpawn = Item.GetComponent<Rigidbody2D>();
        RdbgSpawn.linearVelocityX = -20; 
        //aqui manda ele para a direcao proposta 

        float NumAleatorio = Random.Range(2.0f, 8.0f);
        Invoke("InvocarAlgo", NumAleatorio);
        //sistema de aleatorizar o spawm

        Destroy(Item,5f);
    }

    

}
