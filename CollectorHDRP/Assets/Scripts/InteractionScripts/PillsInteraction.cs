using UnityEngine;
using UnityEngine.UI;

public class PillsInteraction : MonoBehaviour, IInteraction
{
    [SerializeField] Slider _sliderHealth;

    public void Interact() => PickUp();

    public void PickUp()
    {
        gameObject.SetActive(false);
    }
}
