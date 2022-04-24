using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

	public GameObject Settings;
	public GameObject Done;

    public void Play()
    {
    	SceneManager.LoadScene("LevelSelectMenu");
    }

    public void settings()
    {
    	Settings.SetActive(!Settings.activeSelf);
    }

    public void Quit()
    {
    	Application.Quit();
    }

    public void done()
    {
    	Done.SetActive(!Done.activeSelf);
    }
}
