using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool ZombiesAlive;
    public int Wave;
    public TextMeshProUGUI WaveText;
    public int lives;
    public TextMeshProUGUI LivesText;

    public void nextWave()
    {
        if (!ZombiesAlive)
        {
            Wave = Wave + 1;
        }
    }
    
    void Update()
    {
        WaveText.text = "Wave: " + Wave;
    }
}