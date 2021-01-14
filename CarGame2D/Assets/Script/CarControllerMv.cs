using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControllerMv : MonoBehaviour
{
    [Range(10f, 15f)]
    public float fCarMvSpd;
    private float fPosXLimit=2f;
    private Vector3 v3CarPosition;

    // Start is called before the first frame update
    void Start()
    {
        //Get Car Position Initially
        v3CarPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Add x direction
        v3CarPosition.x += Input.GetAxis("Horizontal") * Time.deltaTime * fCarMvSpd;
        //Limit to X-Region
        v3CarPosition.x = Mathf.Clamp(v3CarPosition.x, -fPosXLimit, fPosXLimit);
        transform.position = v3CarPosition;
    }
}
