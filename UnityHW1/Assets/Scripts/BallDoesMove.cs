using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BallDoesMove : MonoBehaviour
{
    [SerializeField] private NavMeshObstacle obstacle;

    void Update()
    {
      
        if (obstacle.transform.position.x < 5)
        {
            obstacle.transform.Translate(Vector3.right * Time.deltaTime*1.5f);
        }
    }
}
