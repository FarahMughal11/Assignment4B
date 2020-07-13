using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject panelofmainmenu;       //MenuPanel
    public GameObject panelofhummingbird;  //HummingPanel
    // Start is called before the first frame update
    void Start()
    {
        panelofmainmenu.SetActive(true);
    }
    public void Penguingame()
    {
        SceneManager.LoadScene("Penguins");
    }
    public void Hummingbirdmenu()
    {
        panelofhummingbird.SetActive(true);
        panelofmainmenu.SetActive(false);
    }
    public void MlAgent()
    {
        SceneManager.LoadScene("Training");
    }
    public void Battlewithmlagent()
    {
        SceneManager.LoadScene("FlowerIsland");
    }
    public void back()
    {
        panelofmainmenu.SetActive(true);
        panelofhummingbird.SetActive(false);

    }

}
