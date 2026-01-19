using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] Transform _coinTransform;
    [SerializeField] Collider _coinCollider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if goes off screen, gets destroyed
        // coin is moving left 
        // instatiated randomly on screen in a line.   not-perfectly-regular intervals (this could be random or in a pattern). random.range
    }

    public void UpdateCoin(int coinCollected)
    {

    }
}
