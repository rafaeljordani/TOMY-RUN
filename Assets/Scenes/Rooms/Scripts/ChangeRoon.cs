using UnityEngine;

public class ChangeRoon : MonoBehaviour
{
    public GameObject Player;
    public Vector2 location;
    public Camera mainCameraFalse,mainCameraTrue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")){

            Player.transform.position = new Vector2(location.x, location.y);
            mainCameraFalse.enabled = false;
            mainCameraTrue.enabled = true;
        }
    }



}
