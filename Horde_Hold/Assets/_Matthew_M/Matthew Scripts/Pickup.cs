using TMPro;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private GameManager gameManager;
    private bool didCountPickup = false;

    private void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            didCountPickup = true;
            gameManager.zoinks++;
            Destroy(gameObject);
            gameManager.audioSource.clip = gameManager.coinClip;
            gameManager.audioSource.Play();
        }
    }

}
