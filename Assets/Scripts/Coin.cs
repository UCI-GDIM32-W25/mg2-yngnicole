using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] Transform _coinTransform;
    [SerializeField] Collider2D _coinCollider;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _destroyCoin = -12f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // instantiate coin randomly on screen in a line with not-perfectly-regular intervals (this could be random or in a pattern). random.range
        // coin is moving left 
        // if coin goes off screen, gets destroyed
    }

}
