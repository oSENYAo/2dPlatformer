using UnityEngine;
using DG.Tweening;

public class CoinAnimation : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _delay;

    private void Start()
    {
        int loopsValue = -1;
        float rotateValueToY = 75;
        transform.DORotate(new Vector3(0, rotateValueToY, 0), _duration, RotateMode.Fast).SetLoops(loopsValue, LoopType.Yoyo).SetDelay(_delay);
    }
}
