using UnityEngine;

public class PlayerController : MonoBehaviour
{
	void Update()
	{
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * -3.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * -3.0f;

		// transform.Rotate(0, x, 0);
		transform.Translate(x, 0, z);
	}

	void OnTriggerEnter(Collider other) 
	{

		if (other.transform.parent.gameObject.CompareTag ("Person"))
		{

			Debug.Log("OH NO!");

			GameObject[] peopleToRotate = GameObject.FindGameObjectsWithTag("Person");

			Debug.Log(peopleToRotate);

			foreach (GameObject person in peopleToRotate) {
				Debug.Log("rotating one!");
				person.GetComponent<PersonController>().lookAtPlayer = true;
			}

		}
	}

}
