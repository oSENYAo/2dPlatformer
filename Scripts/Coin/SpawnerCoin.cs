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

    private void Start()
    {
        _instCoin = Instantiate(_coin, new Vector3(_cointPoints[_currentPoint].position.x, _cointPoints[_currentPoint].position.y), Quaternion.identity);
    }

    private void Update()
    {
        if (_instCoin.IsDestroy)
        {
            _currentPoint++;
            
            if (_currentPoint >= _cointPoints.Count)
            {
                _currentPoint = 0;
            }

            _instCoin = Instantiate(_coin, new Vector3(_cointPoints[_currentPoint].position.x, _cointPoints[_currentPoint].position.y), Quaternion.identity);
        }
    }
}
