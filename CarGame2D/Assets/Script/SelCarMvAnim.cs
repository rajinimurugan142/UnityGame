using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelCarMvAnim : MonoBehaviour
{
    public Vector3 finalPos;
    private Vector3 initialPos;
    // Start is called before the first frame update
    private void Awake()
    {
        initialPos = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(finalPos,initialPos,0.8f);
    }
    private void OnDisable()
    {
        transform.position = initialPos;
    }
}
