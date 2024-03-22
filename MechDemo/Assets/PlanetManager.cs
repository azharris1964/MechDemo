using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetManager : MonoBehaviour
{
    [SerializeField] Planet planet;
    [SerializeField] int gridSpacing = 800;
    [SerializeField]int numPlanetsOnAxis = 3;

    // Start is called before the first frame update
    void Start()
    {
        PlacePlanets();
    }
    void PlacePlanets()
    {
        for(int x = 0; x < numPlanetsOnAxis; x++)
        {
            for (int y = 0; y < numPlanetsOnAxis; y++)
            {
                for (int z = 0; z < numPlanetsOnAxis; z++)
                {
                    InstantiatePlanet(x, y, z);
                }
            }
        }
    }

    // Update is called once per frame
    void InstantiatePlanet(int x, int y, int z)
    {
        Instantiate(planet, 
            new Vector3(
                transform.position.x+(x*gridSpacing)+PlanetOffset(), 
                transform.position.y +(y * gridSpacing) + PlanetOffset(), 
                transform.position.z+(z * gridSpacing) + PlanetOffset()), 
                Quaternion.identity, 
                transform);
    }

    float PlanetOffset()
    {
        return Random.Range(-gridSpacing/2f, gridSpacing/2f);
    }
}
