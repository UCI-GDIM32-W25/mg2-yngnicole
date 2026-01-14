using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinPlayer : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Rigidbody _playerRigidbody;
    [SerializeField] private Collider _playerCollider;
    [SerializeField] private CoinCountUI _coinCountUI;

    private int _coinsCollected;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // The Space button makes the player jump.Jumping is not possible if the player is not grounded.
        // Gain a point, which updates in the UI.
        // Destroy the coin.
        // collider 

    }
}
