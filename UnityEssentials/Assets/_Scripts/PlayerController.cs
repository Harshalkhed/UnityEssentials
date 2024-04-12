using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private string _horizontalAxis = "Horizontal", _verticalAxis = "Vertical";
    [SerializeField]
    private Rigidbody2D _playerRigidbody;
    private float _playerSpeed = 3f; 


    private void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw(_horizontalAxis);//left and right
        float vertialInput = Input.GetAxisRaw(_verticalAxis);//up and down

        Vector2 _input = new Vector2(horizontalInput, vertialInput);

        _playerRigidbody.velocity = _input * _playerSpeed;

        _input.Normalize();
    }

    
}
