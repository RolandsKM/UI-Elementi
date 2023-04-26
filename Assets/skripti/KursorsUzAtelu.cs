using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KursorsUzAtelu : MonoBehaviour {
	public AudioSource skanasAvots;
	public AudioClip skanaKoAskanont;
	public void UzbiditsAttelu()
	{
        skanasAvots.PlayOneShot(skanaKoAskanont);
	}
	public void kursorsnost()
	{
		skanasAvots.Stop();
	}
}
