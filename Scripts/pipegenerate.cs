using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipegenerate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public Vector3 pos;
    void Start()
    {
        StartCoroutine(Generatepipes());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Generatepipes()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            float randy = Random.Range(-1f, 3.5f);
            pos = new Vector3(4f, randy, 0f);
            Instantiate(pipe, pos, Quaternion.identity);

        }
    }
}
