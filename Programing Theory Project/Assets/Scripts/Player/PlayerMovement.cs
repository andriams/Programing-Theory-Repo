using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 10;
    [SerializeField] private float _rotationSpeed = 10;

    private Rigidbody _playerRb;
    private float _horizontalInput;
    private float _verticalInput;
    private float _orientationInput;

    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void GetInput()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
        _orientationInput = Input.GetAxis("Orientation");
    }

    private void Move()
    {
        //translation
        _playerRb.velocity = new Vector3(_horizontalInput, 0, _verticalInput) * _speed;

        //rotation
        Quaternion deltaRotation = Quaternion.Euler(new Vector3(0, _orientationInput, 0) * _rotationSpeed * Time.fixedDeltaTime);
        _playerRb.MoveRotation(_playerRb.rotation * deltaRotation);
    }
}
