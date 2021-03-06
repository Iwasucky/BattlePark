﻿using System;
using UnityEngine;
using UnityEngine.Networking;

public class GridObjectPlacedNetMessage : MessageBase {
	public const short Code = 1021;
	
	public string Type;
	
	public Vector3 Position;
	public Quaternion Rotation;
	public string ObjectData;
}