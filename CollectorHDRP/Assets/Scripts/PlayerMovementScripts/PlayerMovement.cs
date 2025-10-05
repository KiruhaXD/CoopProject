using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController _characterController;
    //[SerializeField] Rigidbody _rbPlayer;

    [SerializeField] float _speedWalk = 3f;
    //[SerializeField] Animator _animator;

    //[SerializeField] float _currentSpeed;
    //float _animationInterpolation = 1f;

    public void Walk() 
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moveWalk = transform.TransformDirection(new Vector3(horizontal, 0f, vertical));

        _characterController.Move(moveWalk * _speedWalk * Time.deltaTime);

        //_rbPlayer.linearVelocity = new Vector3(moveWalk.x, _rbPlayer.linearVelocity.y, moveWalk.z);

        /*_animationInterpolation = Mathf.Lerp(_animationInterpolation, 1f, Time.deltaTime * 3f);
        _animator.SetFloat("x", Input.GetAxis("Horizontal") * _animationInterpolation);
        _animator.SetFloat("y", Input.GetAxis("Vertical") * _animationInterpolation);

        _currentSpeed = Mathf.Lerp(_currentSpeed, _speedWalk, Time.deltaTime * 3f);*/
    }
}
