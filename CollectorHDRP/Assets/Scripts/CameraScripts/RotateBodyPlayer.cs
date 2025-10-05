using System;
using UnityEngine;

public class RotateBodyPlayer : MonoBehaviour
{
    [SerializeField] Transform _playerBodyTransform;
    [SerializeField] float _sensivity = 500f;

    //[SerializeField] Transform _aimTarget;

    //[SerializeField] Animator _animator;

    float _xRotation = 0f;

    public void RotateBody() 
    {
        float mouseX = Input.GetAxis("Mouse X") * _sensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _sensivity * Time.deltaTime;
 
        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -80f, 80f);

        //_xRotation = Mathf.Lerp(_xRotation, mouseX, 10 * Time.deltaTime);
        //_animator.SetFloat("MouseX", _xRotation);

        transform.localRotation = Quaternion.Euler(_xRotation, 0, 0);
        _playerBodyTransform.Rotate(Vector3.up * mouseX);

    }

    /*public void RayTarget() 
    {
        Ray ray = this.GetComponent<Camera>().ScreenPointToRay(new Vector2(Screen.width / 2f, Screen.height / 2f));
        Vector3 target = ray.origin + ray.direction;
        _aimTarget.position = target;
    }*/
}
