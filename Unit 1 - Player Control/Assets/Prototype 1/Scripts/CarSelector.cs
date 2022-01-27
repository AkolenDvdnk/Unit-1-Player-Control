using UnityEngine;
using TMPro;

public class CarSelector : MonoBehaviour
{
    public PlayerController carToSpawn; 

    private bool canSelect;

    private void Update()
    {
        if (canSelect)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Vector3 playerPositions = PlayerController.instance.transform.position;

                Destroy(PlayerController.instance.gameObject);

                PlayerController newPlayer = Instantiate(carToSpawn, playerPositions, carToSpawn.transform.rotation);
                PlayerController.instance = newPlayer;

                gameObject.SetActive(false);

                CameraController.instance.player = newPlayer.transform;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canSelect = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canSelect = false;
        }
    }
}
