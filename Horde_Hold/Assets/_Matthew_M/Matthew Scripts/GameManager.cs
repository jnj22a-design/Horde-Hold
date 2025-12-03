using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int lives = 5;
    public TextMeshProUGUI livesText;
    public int zoinks = 0;
    public TextMeshProUGUI zoinksText;
    public Image KeyImage;
    public GameObject Door;
    public GameObject RealKey;
    public Vector3 SpawnPoint;
    public AudioSource audioSource;
    public AudioClip keyClip;
    public AudioClip coinClip;

    void Start()
    {
        KeyImage.enabled = false;
        RealKey.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        zoinksText.text = "Zoinks: " + zoinks;
    }
}
