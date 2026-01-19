using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinPlayer : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Rigidbody2D _playerRigidbody;
    [SerializeField] private Collider2D _playerCollider;
    [SerializeField] private float _jump;
    //[SerializeField] private CoinCountUI _coinCountUI;

    private int _coinsCollected;
    private bool _isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // The Space button makes the player jump.Jumping is not possible if the player is not grounded.
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _playerRigidbody.AddForce(Vector3.up * _jump, ForceMode.Impulse);
            _isGrounded = false;
        } 


            //When the player hits the coin, 
            // Gain a point, which updates in the UI.
            // Destroy the coin.
            // collider 

        }
    void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = true;
        }
    }
}
