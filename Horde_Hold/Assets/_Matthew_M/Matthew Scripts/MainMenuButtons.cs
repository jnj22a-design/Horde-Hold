using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public GameObject MainCanvas;
    public GameObject PlayCanvas;
    public GameObject CreditsCanvas;
    public string SceneLoadName;
    public string SceneLoadName2;
    public Animator anim;

    private void Start()
    {
        MainCanvas.SetActive(true);
        PlayCanvas.SetActive(false);
        CreditsCanvas.SetActive(false);
    }

    public void StartButton()
    {
        MainCanvas.SetActive(false);
        PlayCanvas.SetActive(true);
        CreditsCanvas.SetActive(false);
    }

    public void CreditsButton()
    {
        MainCanvas.SetActive(false);
        CreditsCanvas.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void BackButton()
    {
        MainCanvas.SetActive(true);
        PlayCanvas.SetActive(false);
        CreditsCanvas.SetActive(false);
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
