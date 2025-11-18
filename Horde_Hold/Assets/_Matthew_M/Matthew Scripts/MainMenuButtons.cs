using System.Collections;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public GameObject MainCanvas;
    public GameObject OptionsCanvas;
    public GameObject PlayCanvas;
    public string SceneLoadName;
    public string SceneLoadName2;
    public Animator anim;

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

    IEnumerator CoolLevel1(string SceneLoadName)
    {
        anim.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneLoadName);
    }
    public void LevelOne()
    {
        StartCoroutine(CoolLevel1(SceneLoadName));
    }

    public void LevelTwo()
    {
        StartCoroutine(CoolLevel1(SceneLoadName2));
    }
}
