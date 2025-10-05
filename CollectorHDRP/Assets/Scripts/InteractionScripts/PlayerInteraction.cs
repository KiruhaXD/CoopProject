using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] Camera _camera;
    [SerializeField] float _distanceRay = 15f;

    [SerializeField] GameObject _textsCanvas;

    int _takeItem;

    public void InteractionRay() 
    {
        RaycastHit hit;

        bool _hitSomething = false;

        if (Physics.Raycast(_camera.transform.position, _camera.transform.forward, out hit, _distanceRay)) 
        {
            IInteraction interaction = hit.collider.GetComponent<IInteraction>();

            if (interaction != null) 
            {
                _hitSomething = true;

                if (Input.GetKeyDown(KeyCode.F)) 
                {
                    _takeItem++;
                    interaction.Interact();
                }

            }
        }


        _textsCanvas.SetActive(_hitSomething);
    }
}
