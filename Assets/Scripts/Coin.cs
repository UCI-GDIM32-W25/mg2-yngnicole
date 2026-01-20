using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] Transform _coinTransform;
    [SerializeField] Collider2D _coinCollider;
    [SerializeField] private float _moveSpeed;
   //[SerializeField] private float _destroyCoin = -12f;

    private bool _isDestroyed;
  

    // Update is called once per frame
    void Update()
    {
        if (_isDestroyed)
            return;

        // coin is moving left 
        transform.Translate(Vector2.left * _moveSpeed * Time.deltaTime);

        // if coin goes off screen, gets destroyed
        //if (transform.position.x < _destroyCoin)
        /*{
            Destroy(gameObject);
            return;
        }
        */
    }

    private void OnBecameInvisible()
    {
        DestroyCoin();
    }

    public void DestroyCoin()
    {
        if (_isDestroyed) return;

        _isDestroyed = true;
        Destroy(gameObject);
    }
}
