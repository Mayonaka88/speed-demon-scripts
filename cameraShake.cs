using UnityEngine;
using System.Collections;

public class cameraShake : MonoBehaviour
{
	// Transform of the camera to shake. Grabs the gameObject's transform
	// if null.
	public Transform camTransform;

	// Amplitude of the shake. A larger value shakes the camera harder.
	public float shakeAmount = 0f;
	public float increaseFactor = 0.01f;

	Vector3 originalPos;

	void Awake()
	{
		if (camTransform == null)
		{
			camTransform = GetComponent(typeof(Transform)) as Transform;
		}
	}

	void OnEnable()
	{
		originalPos = camTransform.localPosition;
	}

	void Update()
	{
		camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;
		shakeAmount = shakeAmount + Time.deltaTime * increaseFactor;
	}
}