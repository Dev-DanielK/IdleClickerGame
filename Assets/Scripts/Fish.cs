using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    [SerializeField] float fishRate;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        FishClick();
    }

    public void FishClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            fishRate = UnityEngine.Random.Range(1, 100);
            if (fishRate <= 25)
            {
                FindObjectOfType<GameManager>().AddFish();
            }
        }
    }
}
