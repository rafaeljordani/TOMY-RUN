using UnityEngine;

public class PlayerScriptInfinityRunning : MonoBehaviour
{
    public Rigidbody2D Rgdb2D;
    public float Vel, JumpForce;
    public Vector2 Dir;
    public bool OnFloor;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Dir = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        //Aqui voce libera o persoangem so andar horizontal e deixando o eixo Y em 0 sempre

        Rgdb2D.linearVelocity = new Vector2(Dir.x * Vel, Rgdb2D.linearVelocity.y);
        //Aqui voce adiciona a força de andar no Rg mas apenas no eixo X por que a logica precisa ser assim mantendo o eixo Y para o addforce fazer ele pular  

        Pulo();
        //Pulo do pernagem 


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            OnFloor = true;
            //para ver se esta no chao ou nao 
        }

        if (collision.gameObject.CompareTag("ItensInfinntyRunning"))
        {
            collision.gameObject.GetComponent<MainIten>().ControlerBoostAndVida();
            //pegar a função do obejeto que colidio e chamar essa função
            
            Destroy(collision.gameObject);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            OnFloor = false;
        }
    }
    public void Pulo()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)) && (OnFloor == true))
        {
            Rgdb2D.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            // Aqui ele adiciona forca ao pulo mas apenas a eixo Y e o forcemode2d é para o objeto ser mais interagivel com massa e gravidade
        }
    }
}

