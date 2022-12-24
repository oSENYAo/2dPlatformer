using UnityEngine;
using DG.Tweening;

public class CoinAnimation : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _delay;

    void Update()
    {
        transform.DORotate(new Vector3(0, 75, 0), _duration, RotateMode.Fast).SetLoops(-1, LoopType.Yoyo).SetDelay(_delay);
    }
}
