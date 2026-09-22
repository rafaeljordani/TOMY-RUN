using UnityEngine;

public class Player_Main : MonoBehaviour
{
    //Personagem geral
    public bool OnFloor;
    //Variaveis boolianas do personagem 

    public float Vel;
    public float JumpForce;
    //Variaveis floats do personagem 

    //Movimento do personagem
    public Vector2 dir;
    public Rigidbody2D Rgdb2D;

    //Camera do personagem
    public GameObject Camera;
    public bool infinityJump = false;

    //Animação do personagem
    public Animator Anim;
    public SpriteRenderer spriteRenderer;

    void Update()
    {
        Mov();
        //Mov do personagem
        CameraMov();
        //Mov da camera
        Pulo();
        //Pulo do pernagem 
        animWalk();
        //Animação do personagem andando
        animJump();
        //Animaçao de pulo do personagem
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ItensInfinntyRunning"))
        {
            setAnimEat();
            collision.gameObject.GetComponent<MainIten>().ControlerBoostAndVida();
            //pegar a função do obejeto que colidio e chamar essa função
            Destroy(collision.gameObject);
        }

            
    }

    public void CameraMov()
    {
        
        if (infinityJump)
        { 
            Camera.transform.position = new Vector3(0, this.gameObject.transform.position.y, -10);
        }
        else Camera.transform.position = new Vector3(this.gameObject.transform.position.x, 0, -10);
        //Isso faz com que a camera siga o personagem no eixo X e nao saia do eixo Y que sempre vai ser fixo em 0  
    }
    public void Mov()
    {
        dir = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        //Aqui voce libera o persoangem so andar horizontal e deixando o eixo Y em 0 sempre

        Rgdb2D.linearVelocity = new Vector2(dir.x * Vel, Rgdb2D.linearVelocity.y);
        //Aqui voce adiciona a força de andar no Rg mas apenas no eixo X por que a logica precisa ser assim mantendo o eixo Y para o addforce fazer ele pular  
        Debug.Log(dir.x);
    }
    public void Pulo()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            if (OnFloor == true)
            {
                Debug.Log("Pulo");
                Rgdb2D.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
                // Aqui ele adiciona forca ao pulo mas apenas a eixo Y e o forcemode2d é para o objeto ser mais interagivel com massa e gravidade
                OnFloor = false;
                //lembra de colocar o OnFloor = false para que o jogador não consiga pular duplo

            }

        }
    }
    public void animWalk()
    {
        if (dir.x == 1)
        {
            Anim.SetBool("isWalk", true);
            spriteRenderer.flipX = false;
        }
        else if(dir.x == -1) 
        {
            Anim.SetBool("isWalk", true);
            spriteRenderer.flipX = true;
        }
        else
        {
            Anim.SetBool("isWalk", false);
        }
    }
    public void animJump()
    {
        if (OnFloor)
        {
            Anim.SetBool("isJump", false);
        }
        else
        {
            Anim.SetBool("isJump", true);
        }
    }

    public void eatFront()
    {
            Anim.SetBool("isEatFront", false);
    }
    public void eatSides()
    {
        Anim.SetBool("isEatSides", false);
    }

    public void setAnimEat()
    {
        Anim.SetBool("isEatFront", true);
        Anim.SetBool("isEatSides", true);
    }


}
