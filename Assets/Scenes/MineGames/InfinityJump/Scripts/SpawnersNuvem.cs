using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnersNuvem : MonoBehaviour
{
    public GameObject NuvemPrefab;
    List<GameObject> NuvemList;

    int RandoNuvem;



    void Start()
    {
        RandoNuvem = Random.Range(0, NuvemList.Count);
        GameObject sla = NuvemList[RandoNuvem];
    }

    
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(NuvemPrefab, , NuvemPrefab.transform.rotation);
        }
    }

    
}
