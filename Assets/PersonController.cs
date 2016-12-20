 using UnityEngine;
 
 public class PersonController: MonoBehaviour
 {
     //values that will be set in the Inspector
     private Transform Target;
     private float RotationSpeed;

     //values for internal use
     private Quaternion _lookRotation;
     private Vector3 _direction;

     private bool lookAtPlayer;

     private Animator animation;
     
     void Start()
     {

          animation = GetComponent<Animator>();

          lookAtPlayer = false;
          animation.SetBool("PersonIsStaringAtPlayer", false);

          RotationSpeed = 2.0f;
          Target = GameObject.FindGameObjectsWithTag("Player")[0].transform;
     }

     public void startLookingAtPlayer()
     {

          if(!lookAtPlayer){

     		animation.SetBool("PersonIsStaringAtPlayer", true);
     		lookAtPlayer = true;
               
          }

     }

     // Update is called once per frame
     void LateUpdate()
     {

     	if(lookAtPlayer){

               transform.LookAt(Target.position);

	         // //find the vector pointing from our position to the target
	         // _direction = (Target.position - transform.position).normalized;
	 
	         // //create the rotation we need to be in to look at the target
	         // _lookRotation = Quaternion.LookRotation(_direction);
	 
	         // //rotate us over time according to speed until we are in the required rotation
	         // transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * RotationSpeed);

	     }

     }
 }
