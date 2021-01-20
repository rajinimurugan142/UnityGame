using UnityEngine;

public class TrackInfiniteScrollMove : MonoBehaviour
{
    [Range(0.5f, 2f)]
    public float fTrackMvSpd;
    private Vector2 v2TrackOffset;
    // Update is called once per frame
    void Update()
    {
        fTrackMvSpd = Input.GetKey(KeyCode.DownArrow) ? 1.2f : 2f;
        //v2TrackOffset -> Y increases to 0.1 
        v2TrackOffset = new Vector2(0, Time.time * fTrackMvSpd);
        GetComponent<Renderer>().material.mainTextureOffset = v2TrackOffset;
    }
}