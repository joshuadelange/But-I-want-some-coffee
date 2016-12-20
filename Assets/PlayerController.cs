using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public AudioSource audioSource;

	void Update()
	{
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * -3.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * -3.0f;

		transform.Translate(x, 0, z);
	}

	void OnTriggerEnter(Collider other) 
	{

		if (other.transform.parent.gameObject.CompareTag ("Person"))
		{

			audioSource.Stop();

			GameObject[] peopleToRotate = GameObject.FindGameObjectsWithTag("Person");

			foreach (GameObject person in peopleToRotate) {

				Debug.Log("rotating");
				Debug.Log(person);

				PersonController personController = person.GetComponent<PersonController>();
				if(personController != null){
					personController.startLookingAtPlayer();
				}
			}

		}
	}

}
