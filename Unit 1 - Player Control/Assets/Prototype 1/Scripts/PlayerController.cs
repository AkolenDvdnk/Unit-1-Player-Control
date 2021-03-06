using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    public float speed;
    public float turnSpeed;

    private float verticalInput;
    private float horizontalInput;

    private void Start()
    {
        instance = this;
    }
    private void Update()
    {
        GetInput();
    }
    private void FixedUpdate()
    {
        MoveVihicle();
    }
    private void GetInput()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
    }
    private void MoveVihicle()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
