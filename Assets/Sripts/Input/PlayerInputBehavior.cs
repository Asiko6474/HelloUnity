using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputBehavior : MonoBehaviour
{

    private PlayerMovementScript _playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        _playerMovement = GetComponent<PlayerMovementScript>();
    }

    // Update is called once per frame
    void Update()
    {
        _playerMovement.MoveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        _playerMovement.RotationDirection = new Vector2(Input.GetAxisRaw("MouseX"), Input.GetAxisRaw("MouseY")).normalized;
    }
}
