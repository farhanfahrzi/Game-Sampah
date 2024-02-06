using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SceneManagement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject exitMenu;
    public void MainMenu(){
        Application.LoadLevel("MainMenu");
    }
    public void Informasi(){
        Application.LoadLevel("Informasi");
    }
    public void Sinau(){
        Application.LoadLevel("Sinau");
    }
    public void SampleScene(){
        Application.LoadLevel("SampleScene");
    }
    public void Tutorial(){
        Application.LoadLevel("Tutorial");
    }
        public void NoClose(){
        exitMenu.SetActive(false);
    }
    public void Close(){
        Application.Quit();
    }
    
}