using JetBrains.Annotations;
using UnityEngine;

public class ControlerDeleteAndADD : MonoBehaviour
{
    public GameObject player, prefabLinha,linha;
    public Vector3 limiteQueda;
    public int linhasSpawnadas = 1;
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
            Destroy(linha);
            limiteQueda = collision.gameObject.transform.position;
            //pega a posição da nuvem que destroio para spawnar a linha
            Destroy(collision.gameObject);
            //destroi a nuvem que caiu
            SpawnLinha();
            //para spawnar a linha e destruir o jogador que caiu

            player.GetComponent<SpawnersNuvem>().NuvensExistem -= 1;
            Debug.Log("destruio o objeto");
            player.GetComponent<SpawnersNuvem>().SpawnNuvem();
        }
    }

    public void SpawnLinha()
    {
        Vector3 spawnLinha = limiteQueda;
        linha = Instantiate(prefabLinha, spawnLinha, Quaternion.identity);
        
    }
}
