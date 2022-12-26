using UnityEngine;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{
    public event UnityAction Destroyed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroyed?.Invoke();
        Destroy(gameObject);
    }
}
