using UnityEngine;

public class PlayerGravity : MonoBehaviour
{
    [SerializeField] CharacterController _characterController;

    [SerializeField] Transform _groundCheck;
    [SerializeField] float _groundDistance;
    [SerializeField] LayerMask _groundMask;

    float _gravity = -9.81f;

    Vector3 _velocity;

    bool _isGrounded = false;

    public void Gravity() 
    {
        _isGrounded = Physics.CheckSphere(_groundCheck.position, _groundDistance, _groundMask);

        if (_isGrounded && _velocity.y < 0)
            _velocity.y = -2f;

        _velocity.y += _gravity * Time.deltaTime;

        _characterController.Move(_velocity * Time.deltaTime);
    }
}
