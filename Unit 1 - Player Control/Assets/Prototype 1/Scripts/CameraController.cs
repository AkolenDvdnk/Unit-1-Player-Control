using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;

    public Transform player;

    [HideInInspector] public Vector3 firstPersonOffset = new Vector3(0, 2, 1.45f);
    private Vector3 thirdPersonOffset = new Vector3(0, 5, -7);

    private bool pressed = false;

    private void Start()
    {
        instance = this;
    }
    private void LateUpdate()
    {
        transform.position = player.transform.position + CameraOffset();
        if (Input.GetKeyDown(KeyCode.Q))
        {
            pressed = !pressed;
        }
    }
    private Vector3 CameraOffset()
    {
        if (pressed)
            return firstPersonOffset;
        else
            return thirdPersonOffset;
    }
}
