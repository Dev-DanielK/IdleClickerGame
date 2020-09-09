using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour{
    [SerializeField] float mineRate;

    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
        MineClick();
    }

    public void MineClick(){
        if (Input.GetMouseButtonDown(0)){
            mineRate = UnityEngine.Random.Range(1, 100);
            if (mineRate <= 25){
                FindObjectOfType<GameManager>().AddOres();
            }
        }
    }
}