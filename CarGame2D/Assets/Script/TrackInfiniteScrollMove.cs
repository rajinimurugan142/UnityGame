using UnityEngine;

public class TrackInfiniteScrollMove : MonoBehaviour
{
    [Range(0.5f, 2f)]
    public float fTrackMvSpd;

    private Vector2 v2TrackOffset;

    // Update is called once per frame
    void Update()
    {
        v2TrackOffset = new Vector2(0,Time.time*fTrackMvSpd);
        //v2TrackOffset ->   Y increases to 0.1 
        //Debug.Log(v2TrackOffset);
        GetComponent<Renderer>().material.mainTextureOffset = v2TrackOffset;
    }
}
