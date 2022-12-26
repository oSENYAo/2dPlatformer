using UnityEngine;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{
    public UnityAction Destroyed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroyed?.Invoke();
        Destroy(gameObject);
    }
}
