using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;

    public Transform player;

    private Vector3 offset = new Vector3(0, 5, -7);

    private void Start()
    {
        instance = this;
    }
    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
