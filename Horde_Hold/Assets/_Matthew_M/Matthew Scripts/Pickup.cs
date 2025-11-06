using TMPro;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameManager gameManager;
    private bool didCountPickup = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            didCountPickup = true;
            gameManager.zoinks++;
            Destroy(gameObject);
        }
    }

}
