using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
	public class move
	{
		public Vector3 position;
		public Quaternion rotation;
		public move (Vector3 pos, Quaternion rot)
		{
			position = pos;
			rotation = rot;
		}
	}

	public List <Marker> markerlist = new List <Marker>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UpdateMarkerList();
    }

    public void UpdateMarkerList()
    {
    	markerlist.Add(new Marker(transform.position, transform.rotation));
    }

    public void ClearMarkerList()
    {
    	markerlist.Clear();
    	markerlist.Add(new Marker(transform.position, transform.rotation))
    }
}
