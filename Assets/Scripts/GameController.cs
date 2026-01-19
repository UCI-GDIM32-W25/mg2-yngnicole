using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;

public class Ui : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinPoints;
    [SerializeField] private GameObject _coinPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // When the player hits the coin, they Gain a point, which updates in the UI.
        // Coins (or some other kind of object) appear at not-perfectly-regular intervals (this could be random or in a pattern).
        // coin spawn location
        // number of points
        // coin prefab
        // instantiate coin randomly on screen in a line with not-perfectly-regular intervals (this could be random or in a pattern). random.range
    }
    public void UpdateCoin(int coinCollected)
    {

    }
}
