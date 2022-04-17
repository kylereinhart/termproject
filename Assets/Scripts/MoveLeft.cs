using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float mSpeed = 1;

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.left * Time.deltaTime * mSpeed, Space.World);

    }

    /*private void ShowRandomSprite()
    {
        int index = UnityEngine.Random.Range(0, 3);
        int childCount = transform.childCount;
        
        for (int i = 0; i < childCount; i++)
        {
            Transform child = transform.GetChild(i);
            bool shouldShow = index == i;
            
            child.gameObject.SetActive(shouldShow); // activates if the child is the random int
        }
    }

    private void OnEnable()
    {
        ShowRandomSprite();
    }*/
}
