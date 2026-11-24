
using UnityEngine;

public class HubAnim : MonoBehaviour
{
    public GameObject imagem1;
   
    public void MostrarImagens()
    {

        if(imagem1.activeSelf)
        {
            imagem1.SetActive(false);
        
        }
        else
        {
            imagem1.SetActive(true);
        }
    }
   
}
