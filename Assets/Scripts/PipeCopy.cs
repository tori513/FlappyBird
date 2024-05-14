using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class PipeCopy : MonoBehaviour
{
    float stageTime = 1.5f;
    
    [SerializeField]
    private float height = 0.45f;
    [SerializeField]
    private GameObject pipe2;

    float timeCheck = 0;

    public addSco addSco;

    void Start()
    {
        CopyPipe();
    }

    
    void Update()
    {
        timeCheck += Time.deltaTime;

        if (timeCheck > stageTime)
        {
            CopyPipe();
            timeCheck = 0;

            if(addSco != null)
            {
                if (addSco.score == 4)
                {
                    stageTime = 0.9f;
                    height = 0.02f;
                }
                if (addSco.score == 15)
                {
                    stageTime = 1.4f;
                    height = 0.8f;
                }
            }
            
        }
        
    }

    void CopyPipe()
    {
        Vector3 copyPosition = transform.position + new Vector3(0,Random.Range(-height, height));
        GameObject pipe = Instantiate(pipe2, copyPosition, Quaternion.identity);
        Destroy(pipe,7f);
    }
}
