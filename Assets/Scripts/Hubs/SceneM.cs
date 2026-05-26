using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneM : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void menu_game()
    {
        SceneManager.LoadScene("Gaming");
    }

    public void menu_saves()
    {
        SceneManager.LoadScene("Tela de Saves");
    }

    public void menu_config()
    {
        SceneManager.LoadScene("Config");
    }

    public void config_menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void saves_menu()
    {
        SceneManager.LoadScene("Menu");
    }

}
