using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstructorScript : MonoBehaviour
{
    public GameObject pandulak;
    public int numPandulaks = 100;

    public float distanceFromStart = 100;
    
    void Start()
    {
        for (int i = 0; i < numPandulaks; i++)
        {
            Vector3 newPosition = new Vector3(Random.Range(0, distanceFromStart), 0, Random.Range(0, distanceFromStart));
            Quaternion quaternion = Quaternion.Euler(0, Random.Range(0, 360), 0);
            Instantiate(pandulak, newPosition, quaternion);
        }
    }
}
