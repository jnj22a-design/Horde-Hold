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

    void Start()
    {
        KeyImage.enabled = false;
        RealKey.SetActive(false);
    }

    void Update()
    {
        zoinksText.text = "Zoinks: " + zoinks;
    }
}
