using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnerCoin : MonoBehaviour
{
    [SerializeField] private Person _person;
    [SerializeField] private List<Transform> _cointPoints;
    [SerializeField] private Coin _coin;

    private Coin _instCoin;
    private int _currentPoint = 0;

    private void OnDisable()
    {
        _instCoin.Destroyed -= OnDestroyed;
    }

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        _instCoin = Instantiate(_coin, new Vector3(_cointPoints[_currentPoint].position.x, _cointPoints[_currentPoint].position.y), Quaternion.identity);

        _instCoin.Destroyed += OnDestroyed;
    }

    private void OnDestroyed()
    {
        _currentPoint++;

        if (_currentPoint >= _cointPoints.Count)
        {
            _currentPoint = 0;
        }

        Spawn();
    }
}
