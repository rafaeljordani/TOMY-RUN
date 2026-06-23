using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnersNuvem : MonoBehaviour
{
    public GameObject NuvemPrefab;
    public List<GameObject> NuvemList;

    public int RandoNuvem, NuvensExistem;



    void Start()
    {
        
        //GameObject sla = NuvemList[RandoNuvem];
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
        if (NuvensExistem <= 2)
        {
            Debug.Log("Spawnou Nuvem");
            RandoNuvem = Random.Range(0,NuvemList.Count - 1);
            Instantiate(NuvemPrefab, NuvemList[RandoNuvem].transform.position, NuvemPrefab.transform.rotation);
            NuvensExistem += 1;
        }
    }

}
