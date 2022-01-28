using UnityEngine;
using TMPro;

public class CarSelector : MonoBehaviour
{
    public bool isBus = false;

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
                CameraOffset();
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
    private void CameraOffset()
    {
        if (isBus)
        {
            CameraController.instance.firstPersonOffset = new Vector3(0, 2.3f, 2.6f);
        }
        else
        {
            CameraController.instance.firstPersonOffset = new Vector3(0, 2, 1.45f);
        }
    }
}
