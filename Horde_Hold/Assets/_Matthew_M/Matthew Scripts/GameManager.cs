using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int lives = 5;
    public TextMeshProUGUI livesText;
    public int zoinks = 0;
    public TextMeshProUGUI zoinksText;

    void Start()
    {
        
    }

    void Update()
    {
        livesText.text = "Lives: " + lives;
        zoinksText.text = "Zoinks: " + zoinks;
    }
}
