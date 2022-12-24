using UnityEngine;
using DG.Tweening;

public class FollowPerson : MonoBehaviour
{
    [SerializeField] private Person _person;
    private Vector3 offset = new Vector3(-0.67f, 4, -9f);

    private void LateUpdate()
    {
        transform.position = _person.transform.position + offset;
    }
}
