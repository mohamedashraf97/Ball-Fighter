using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
	public Transform player ;
    public Transform player2;
	public Vector3 offset ;
	void Update () {
		transform.position = ((player.position + player2.position) / 2 )+ offset ;
	}
}
