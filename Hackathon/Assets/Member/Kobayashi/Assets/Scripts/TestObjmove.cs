using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObjmove : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(-speed * 0.01f,0,0);  
        if(this.transform.position.x<= -30)
        {
            this.gameObject.SetActive(false);
        }
    }


}
