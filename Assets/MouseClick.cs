using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
	public GameObject Image;

	void Update()
	{
		if (Input.GetMouseButtonDown(1))
		{//Click�ŉ摜�\��
			Image.SetActive(true);
		}

		if (Input.GetMouseButtonUp(1))
		{//�EClick�ŉ摜����
			Image.SetActive(false);
		}
	}
}