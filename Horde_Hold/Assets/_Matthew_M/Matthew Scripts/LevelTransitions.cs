using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransitions : MonoBehaviour
{
    public Animator anim;
    public string SceneLoadName;
    IEnumerator CoolLevel1(string SceneLoadName)
    {
        anim.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneLoadName);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(CoolLevel1(SceneLoadName));
    }
}
