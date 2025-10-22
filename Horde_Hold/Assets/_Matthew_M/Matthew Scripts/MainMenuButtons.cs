using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public GameObject MainCanvas;
    public GameObject OptionsCanvas;
    public GameObject PlayCanvas;
    public string SceneLoadName;
    public string SceneLoadName2;

    private void Start()
    {
        MainCanvas.SetActive(true);
        OptionsCanvas.SetActive(false);
        PlayCanvas.SetActive(false);
    }

    public void StartButton()
    {
        MainCanvas.SetActive(false);
        PlayCanvas.SetActive(true);
    }

    public void OptionsButton()
    {
        MainCanvas.SetActive(false);
        OptionsCanvas.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void BackButton()
    {
        MainCanvas.SetActive(true);
        OptionsCanvas.SetActive(false);
        PlayCanvas.SetActive(false);
    }

    public void LevelOne()
    {
        SceneManager.LoadScene(SceneLoadName);
    }

    public void LevelTwo()
    {
        SceneManager.LoadScene(SceneLoadName2);
    }
}
