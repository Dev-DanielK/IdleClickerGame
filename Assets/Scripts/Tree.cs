using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour{
    [SerializeField] int logs = 1;
    [SerializeField] int currentLogs = 0;
    [SerializeField] float chopRate;

    // Start is called before the first frame update
    void Start(){
        currentLogs = 0;
    }

    // Update is called once per frame
    void Update(){
        ChopClick();
    }

    public void ChopClick(){
        if (Input.GetMouseButtonDown(0)) {
            chopRate = UnityEngine.Random.Range(1, 100);
            if (chopRate <= 25)
            {
                FindObjectOfType<GameManager>().AddLogs();
            }
        }
    }
}
