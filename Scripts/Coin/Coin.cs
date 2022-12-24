using UnityEngine;

public class Coin : MonoBehaviour
{
    public bool IsDestroy { get; private set; }

    private void Awake()
    {
        IsDestroy = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        IsDestroy = true;
    }
}
