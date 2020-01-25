using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chompies.Shared;

public class WorldGenerator : MonoBehaviour
{

    [Header("Settings")]

    [Range(0, 100)]
    [SerializeField]
    private int WorldWidth;
    
    [Range(0, 100)]
    [SerializeField]
    private int WorldLength;

    [Range(0, 40)]
    [SerializeField]
    private int Zombies;


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

    private Chompies.Shared.World World;



    // Start is called before the first frame update
    void Start()
    {
        this.World = new World();
        World.Populate(WorldWidth, WorldLength, Zombies);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
