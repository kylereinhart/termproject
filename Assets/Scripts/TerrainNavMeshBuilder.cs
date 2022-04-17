using System;
using UnityEditor.AI;
using UnityEngine;

namespace Fifth.Code.Scripts
{
    public class TerrainNavMeshBuilder : MonoBehaviour
    {
        private void Start()
        {
            NavMeshBuilder.BuildNavMesh();
        }
    }
}