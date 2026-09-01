
using TMPro;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    public MainGame mainGame;
    public TextMeshProUGUI textEstamina, textVida;
    void Start()
    {
        //Aqui eu econtro o objeto MainGame para usar logo ai em baixo

        textEstamina.text = "estamina: " + mainGame.estaminaController.ToString();
        textVida.text = "vida: " + mainGame.vida.ToString();
    }
    void Update()
    {
        changeText();
    }

    //aqui é uma função de controlar a adiçao e a remoção de tempo e vida do jogo
    public void changeText()
    {
           
            textEstamina.text = "estamina: " + mainGame.estaminaController.ToString();

            textVida.text = "vida: " + mainGame.vida.ToString();
    }
}

