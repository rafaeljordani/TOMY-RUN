using UnityEngine;

public class StartAnim : MonoBehaviour
{
    public Animator animator1, animator2,animator3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartAnimation()
    {
        animator1.SetBool("anim", true);
        animator2.SetBool("anim", true);
        animator3.SetBool("anim", true);
    }
}
