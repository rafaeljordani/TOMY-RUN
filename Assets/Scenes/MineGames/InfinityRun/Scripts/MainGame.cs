using Unity.VisualScripting;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    public float estaminaController = 100;
    public int vida = 5;

    void Start()
    {
        //invoca a função TimeWasteEstamina a cada 1 segundo 
        InvokeRepeating("TimeWasteEstamina", 1f, 1f);

    }

    void Update()
    {
        VerificadeLoser();
    }

    //aqui é para gastar 1 de estamina a cada segundo 
    public void TimeWasteEstamina()
    {
        estaminaController -= 1;
    }

    //aplicação da funçao de vitoria e derrota 
    public void VerificadeLoser()
    {
        if ((estaminaController <= 0) || (vida <= 0))
        {
            Application.Quit();
            Debug.Log("morreu");
        }
    }
}
