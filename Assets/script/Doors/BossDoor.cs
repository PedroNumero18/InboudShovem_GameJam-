using UnityEngine;

public class BossDoor : MonoBehaviour
{
    private BoxCollider2D bc2D;
    private SpriteRenderer sr;
    void Start()
    {
        bc2D = GetComponent<BoxCollider2D>();
        sr = GetComponent<SpriteRenderer>();
        sr.enabled = false;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        bc2D.isTrigger = false;
        sr.enabled = true;
    }
}
