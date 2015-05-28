using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CountVisits : MonoBehaviour {
	public int count = 0;
	public int totalCount;
	public Text textCount;

	// Use this for initialization
	void Start () {
		UpdateTextCount ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void IncreaseCount(){
		count ++;
		UpdateTextCount ();
	}

	private void UpdateTextCount(){
		textCount.text = count.ToString () + "/" + totalCount.ToString();
	}
}
