using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MainMenu : MonoBehaviour
{

	public GameObject Settings;
	public GameObject Done;

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

    public void NewGame()
    {
        PlayerPrefs.DeleteAll();
    }
}