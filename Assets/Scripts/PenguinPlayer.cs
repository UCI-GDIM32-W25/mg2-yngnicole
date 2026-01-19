using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class PenguinPlayer : MonoBehaviour
{
    // [SerializeField] private Transform _playerTransform;
    [SerializeField] private Rigidbody2D _playerRigidbody;
    [SerializeField] private Collider2D _playerCollider;
    [SerializeField] private float _jump;
    [SerializeField] private Coin _coinCountUI;

    private int _coinsCollected;
    private bool _isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        _coinsCollected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // The Space button makes the player jump.Jumping is not possible if the player is not grounded.
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _playerRigidbody.AddForce(Vector2.up * _jump, ForceMode2D.Impulse);
            _isGrounded = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //When the player hits the coin, Gain a point, Destroy the coin.
        if (collision.CompareTag("Coin"))
        { 
            _coinsCollected++;
            Destroy(collision.gameObject);

            _coinCountUI.UpdateCoin(_coinsCollected);
        }
    }
    
    void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = true;
        }
    }
}
