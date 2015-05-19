using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

[Serializable]
public class Information  {
	public string preTitle;
	public string title;
	public List<Data> dataList;
	[Multiline]
	public string description;	
	public Sprite photo;
}
