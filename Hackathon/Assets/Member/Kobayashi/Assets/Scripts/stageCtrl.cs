using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageCtrl : MonoBehaviour
{
    [SerializeField] private float stageMoveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StageMove();
    }

    void StageMove()
    {
        //this.transform.Translate(-stageMoveSpeed*Time.deltaTime, 0, 0);
        transform.position -= new Vector3(Time.deltaTime * stageMoveSpeed, 0);
        if (this.transform.position.x <= -8.9f)
        {
            this.transform.position = new Vector3(8.9f, this.transform.position.y, this.transform.position.z);
        }
    }
}
