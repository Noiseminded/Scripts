using UnityEngine;
using System.Collections;

public class SpherePlacement : MonoBehaviour {

	public GameObject spherePrefab;

	public float bounds = 200;

	public AudioClip[] clips;

	void Awake()
	{
		

		for (int i = 0; i < 16; i++) {

			Vector3 randomLocation = new Vector3 (Random.Range (-bounds, bounds), Random.Range (-bounds, bounds), Random.Range (-bounds, bounds));

			GameObject sphere = Instantiate (spherePrefab, randomLocation, transform.rotation) as GameObject;

			sphere.GetComponent<AudioSource> ().clip = clips [i];
			sphere.GetComponent<AudioSource> ().Play(0);


		}

	}
}
