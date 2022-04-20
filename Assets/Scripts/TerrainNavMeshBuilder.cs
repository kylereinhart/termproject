using System;
using UnityEditor.AI;
using UnityEngine;

namespace Scripts
{
    public class TerrainNavMeshBuilder : MonoBehaviour
    {
        private void Start()
        {
            NavMeshBuilder.BuildNavMesh();
        }
    }
}