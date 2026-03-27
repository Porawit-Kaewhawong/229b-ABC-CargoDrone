using UnityEngine;

public class DeliveryZone : MonoBehaviour
{
    public int totalCargo;
    public int currentCargoDelivered;

    public GameObject door;
    public Material successColor;

    private Renderer rend;

    private PlayerController playerController;

    void Start()
    {
        rend = GetComponent<Renderer>();
        playerController = Object.FindAnyObjectByType<PlayerController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Crate") && playerController.attachedCrate == null)
        {
            Debug.Log("Cargo Delivered!");
            currentCargoDelivered++;
            Destroy(other.gameObject);

            if (currentCargoDelivered >= totalCargo)
            {
                rend.material = successColor;
                door.SetActive(true);
            }
        }
    }
}
