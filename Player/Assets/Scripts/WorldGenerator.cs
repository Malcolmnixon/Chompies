using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{

    [Header("Settings")]

    [Range(-5f, 5f)]
    [SerializeField]
    private float randomness;


    [Header("Game Objects")]

    [Tooltip("Base of the world, will be reconstructed")]
    [SerializeField]
    public GameObject world;

    
    [Header("Prefabs")]
    
    [SerializeField]
    public GameObject heroPrefab;
    
    [Space]

    [SerializeField]
    public GameObject hordePrefab;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
