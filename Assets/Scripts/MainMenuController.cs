using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    
    public void PlayGame() 
    { 
        SceneManager.LoadScene("Tutorial"); 
    } 

    public void OpenAuthor() 
    { 
        Debug.Log("Created By Septiandry Khrisna Setiono - 149251970101-54"); 
    }
    
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
