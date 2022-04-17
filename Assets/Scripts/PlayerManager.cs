using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        //this is a change
        var player = Instantiate(playerPrefab, this.transform.position, Quaternion.identity, transform);
        player.AddComponent<Player>();
    }
}
