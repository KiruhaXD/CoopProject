using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] PlayerMovement _playerMovement;
    [SerializeField] RotateBodyPlayer _rotateBodyPlayer;
    [SerializeField] PlayerGravity _playerGravity;
    [SerializeField] RotateText[] _rotateText;
    [SerializeField] PlayerInteraction _playerInteraction;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        _playerMovement.Walk();
        _playerGravity.Gravity();
        _rotateBodyPlayer.RotateBody();

        //foreach(RotateText rotate in _rotateText)
          //  rotate.Rotate();

        _playerInteraction.InteractionRay();
        //_rotateBodyPlayer.RayTarget();
    }
}
