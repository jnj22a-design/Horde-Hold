using UnityEngine;

public class ButtonHit : MonoBehaviour
{
    public SpriteRenderer fanta;
    public Sprite sevenUp;
    public GameManager gameManager;
    private bool didCountPickup = false;
    public PolygonCollider2D porygonZ;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            didCountPickup = true;
            gameManager.RealKey.SetActive(true);
            fanta.sprite = sevenUp;
            porygonZ.isTrigger = false;
        }
    }
}
