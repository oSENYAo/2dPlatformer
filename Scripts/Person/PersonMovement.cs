using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PersonMovement : MonoBehaviour
{
    [Range(5f, 12f)]
    [SerializeField] private float _speed;
    [SerializeField] private float _heightOfJump;

    public float _inputHorizontal;
    private float jumpValue;
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _inputHorizontal = Input.GetAxis("Horizontal");
        
        if (_inputHorizontal < 0)
        {
            Run(-1);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (_inputHorizontal > 0)
        {
            Run(1);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (_inputHorizontal != 0)
        {
            _animator.ResetTrigger(Animator.StringToHash(PersonAnimator.States.IdleTrigger));
            _animator.SetTrigger(Animator.StringToHash(PersonAnimator.States.RunTrigger));
        }
        else
        {
            _animator.ResetTrigger(Animator.StringToHash(PersonAnimator.States.RunTrigger));
            _animator.SetTrigger(Animator.StringToHash(PersonAnimator.States.IdleTrigger));
        }
    }

    private void Run(int direction)
    {
        transform.Translate((Vector3.right * _inputHorizontal * _speed * Time.deltaTime) * direction);
    }

    private void FixedUpdate()
    {
        jumpValue = Input.GetAxis("Jump");
        transform.Translate(Vector3.up * _heightOfJump * jumpValue * Time.deltaTime);
    }
}
