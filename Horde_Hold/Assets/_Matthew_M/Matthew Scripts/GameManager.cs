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

    void Start()
    {
        KeyImage.enabled = false;
        RealKey.SetActive(false);
    }

    void Update()
    {
        livesText.text = "Lives: " + lives;
        zoinksText.text = "Zoinks: " + zoinks;
    }
}
