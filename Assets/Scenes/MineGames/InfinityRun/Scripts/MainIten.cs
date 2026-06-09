using UnityEngine;

public class MainIten : MonoBehaviour
{
        public float boost;
        public int dano = 0;
        public GameObject mainGame;
    void Start()
    {
        //Aqui eu econtro o objeto MainGame para usar logo ai em baixo
        mainGame = GameObject.FindGameObjectWithTag("MainGameInfinntyRunning");
    } 
    void Update()
    {
        
    }

    //aqui é uma função de controlar a adiçao e a remoção de tempo e vida do jogo
    public void ControlerBoostAndVida()
    {
        if(dano == 0)
        {
            mainGame.GetComponent<MainGame>().estaminaController += boost;
            //aqui dai vai a maingame para poder pegar as variaveis das para fazer as operações
        }
        else
        {
            mainGame.GetComponent<MainGame>().vida -= dano;
        }
    }


}
