using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointsMovement : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform _enemyPath;
    [SerializeField] private float _speed;

    private List<Transform> _points = new List<Transform>();
    private int _currentPoint = 0;
    
    private void Start()
    {
        for (int i = 0; i < _enemyPath.childCount; i++)
        {
            _points.Add(_enemyPath.GetChild(i));
        }
    }

    private void Update()
    {
        Transform target = _points[_currentPoint];

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if (transform.position == target.position)
        {
            _currentPoint++;
            
            if (_currentPoint >= _points.Count)
            {
                _currentPoint = 0;
            }
        }
    }
}
