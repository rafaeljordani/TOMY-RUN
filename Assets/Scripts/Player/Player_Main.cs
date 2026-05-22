using UnityEngine;

public class Player_Main : MonoBehaviour
{
    public Rigidbody2D Rgdb2D;
    public float Vel;
    public Vector2 Dir;
    public GameObject Camera;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Dir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Rgdb2D.linearVelocity = Dir * Vel;

        Camera.transform.position = Rgdb2D.position ;
    }
}
