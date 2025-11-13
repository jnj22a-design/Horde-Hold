using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public GameManager gameManager;
    private bool didCountPickup = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            didCountPickup = true;
            gameManager.KeyImage.enabled = true;
            gameManager.Door.SetActive(false);
            Destroy(gameObject);
        }
    }
}
