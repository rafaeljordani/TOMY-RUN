using UnityEngine;

public class AnimDor : MonoBehaviour
{
    //Animação da porta
    public Animator AnimDoor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        setaAnimDoorTrue(collision);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        setaAnimDoorFalse(collision);
    }


    public void setaAnimDoorTrue(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AnimDoor.SetBool("OpenTheDoor", true);
        }
        else if (collision.gameObject.CompareTag("ExitDoor"))
        {
            AnimDoor.SetBool("CloseTheDoor", true);
        }
    }
    public void setaAnimDoorFalse(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AnimDoor.SetBool("OpenTheDoor", false);
        }
        else if (collision.gameObject.CompareTag("ExitDoor"))
        {
            AnimDoor.SetBool("CloseTheDoor", false);
        }
    }

}
