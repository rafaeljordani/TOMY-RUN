using UnityEngine;

public class Player_Main : MonoBehaviour
{
    public Rigidbody2D Rgdb2D;
    public float Vel, JumpForce;
    public Vector2 Dir;
    public GameObject Camera;
    public bool OnFloor;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Dir = new Vector2(Input.GetAxisRaw("Horizontal"),0);
        //Aqui voce libera o persoangem so andar horizontal e deixando o eixo Y em 0 sempre

        Rgdb2D.linearVelocity = new Vector2(Dir.x * Vel, Rgdb2D.linearVelocity.y);
        //Aqui voce adiciona a força de andar no Rg mas apenas no eixo X por que a logica precisa ser assim mantendo o eixo Y para o addforce fazer ele pular  



        CameraMov();
        //Mov da camera
        Pulo();
        //Pulo do pernagem 


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            OnFloor = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            OnFloor = false;
        }
    }

    public void CameraMov()
    {
        Camera.transform.position = new Vector3(this.gameObject.transform.position.x, 0, -10);
        //Isso faz com que a camera siga o personagem no eixo X e nao saia do eixo Y que sempre vai ser fixo em 0 
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
