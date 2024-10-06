using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateStars : MonoBehaviour
{
    [SerializeField]
    private bool isStarSpawner = false;
    [SerializeField]
    private GameObject Star;
    [SerializeField]
    private int numStars = 1;

    [SerializeField]
    private float rotateSpeed = 60f;
    // Start is called before the first frame update
    void Start()
    {
        if (isStarSpawner)
        {
            for (int i = 0; i < numStars; i++)
            {
                GameObject star = Instantiate(Star, transform);
                float angle = 360 / numStars;
                star.transform.RotateAround(transform.position, Vector3.up, angle * i);
                star.transform.position = star.transform.position + star.transform.forward * -numStars;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, rotateSpeed * Time.deltaTime);
    }
}
