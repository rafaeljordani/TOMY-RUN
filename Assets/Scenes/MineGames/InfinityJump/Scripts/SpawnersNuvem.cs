using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnersNuvem : MonoBehaviour
{
    public GameObject NuvemPrefab;
    public List<GameObject> NuvemList;

    public int RandoNuvem, NuvensExistem;
    public int suporte = 7;



    void Start()
    {

    }
    
    
    void Update()
    {
        if ((Input.GetKeyUp(KeyCode.Space)) && (NuvensExistem <= 2))
        {
            SpawnNuvem();
        }
    }


    public void SpawnNuvem()
    {
        
        int numAntigo = suporte;


        if (NuvensExistem <= 2)
        {
            Debug.Log("Spawnou Nuvem");
            RandoNuvem = Random.Range(0,4);
            suporte = RandoNuvem;
            if(numAntigo == suporte)
            {
                if(RandoNuvem == 0)
                {
                    RandoNuvem +=1;
                }
                RandoNuvem -= 1;
            }
            Instantiate(NuvemPrefab, NuvemList[RandoNuvem].transform.position, NuvemPrefab.transform.rotation);
            NuvensExistem += 1;
        }
    }

}
