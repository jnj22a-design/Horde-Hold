using System.Collections;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningScene : MonoBehaviour
{
    public string SceneLoadName;
    IEnumerator TheOpening()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(SceneLoadName);
    }
    void Start()
    {
        StartCoroutine(TheOpening());
    }
}
