using UnityEngine;

public class MainPlayerInfinityEat : MonoBehaviour
{
    public Rigidbody2D Rgdb2D;
    public float Vel;
    public Vector2 Dir;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Dir = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        //Aqui voce libera o persoangem so andar horizontal e deixando o eixo Y em 0 sempre

        Rgdb2D.linearVelocity = new Vector2(Dir.x * Vel, Rgdb2D.linearVelocity.y);
        //Aqui voce adiciona a força de andar no Rg mas apenas no eixo X por que a logica precisa ser assim mantendo o eixo Y para o addforce fazer ele pu
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ItensInfinntyRunning"))
        {
            collision.gameObject.GetComponent<MainIten>().ControlerBoostAndVida();
            //pegar a função do obejeto que colidio e chamar essa função

            Destroy(collision.gameObject);
        }
    }

}
