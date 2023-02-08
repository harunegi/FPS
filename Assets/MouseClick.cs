using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
	public GameObject Image;

	void Update()
	{
		if (Input.GetMouseButtonDown(1))
		{//Click‚Å‰æ‘œ•\¦
			Image.SetActive(true);
		}

		if (Input.GetMouseButtonUp(1))
		{//‰EClick‚Å‰æ‘œÁ‹
			Image.SetActive(false);
		}
	}
}