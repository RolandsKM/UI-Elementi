using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virtuluGenerator : MonoBehaviour
{
	public GameObject[] virtuluSgatave;
	public float laikaIntervals = 1f;//x854.9
	float minX, maxX;
	private Transform krasnsTransform;
	// Use this for initialization
	void Start()
	{
		krasnsTransform = GetComponent<Transform>();

	}
	public void sagatavotVurtulus(bool stavoklis)
	{
		if (stavoklis)
			StartCoroutine(Generet());
		else
			StopAllCoroutines();

	}
	IEnumerator Generet()
	{
		while (true)
		{
			minX= krasnsTransform.position.x-15;
			maxX= krasnsTransform.position.x+15;
			var cipars = Random.Range(minX, maxX);
			var pozicija = new Vector2(cipars, transform.position.y);
			GameObject virtulis = Instantiate(virtuluSgatave[Random.Range(0, virtuluSgatave.Length)], pozicija, Quaternion.identity, krasnsTransform);
			
			yield return new WaitForSeconds(laikaIntervals);
		}
	}
}