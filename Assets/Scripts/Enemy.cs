using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour{
    [SerializeField] float damageRate;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        AttackClick();
    }

    public void AttackClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            damageRate = UnityEngine.Random.Range(1, 100);
            if (damageRate <= 50)
            {
                int takeDamage = UnityEngine.Random.Range(1, 5);
                int damage = takeDamage;
                FindObjectOfType<GameManager>().TakeDamage(damage);
            }
        }
    }
}

