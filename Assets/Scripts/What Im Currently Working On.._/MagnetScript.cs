using UnityEngine;
using System.Collections;

public class MagnetScript : MonoBehaviour {

	public Transform player;
	public Transform target;
	public Transform target2;
	public Transform target3;
	public Transform target4;
	public float speed;
	static public int counter;

	void LateUpdate(){



				if (counter == 2) {
						float step = speed * Time.deltaTime;

						//print (player.position);
						//print (target.position);
		

						Vector3 newPosition = new Vector3 ();
						float angle = Mathf.Atan2 (target.position.y - player.position.y, target.position.x - player.position.x);

						newPosition.x = Mathf.Cos (angle) * step;
						newPosition.y = Mathf.Sin (angle) * step;

						player.position += newPosition;
				} 
				else if (counter == 3) {
				if (counter == 3) {
				float step = speed * Time.deltaTime;
				
				//print (player.position);
				//print (target.position);
				
				
				Vector3 newPosition = new Vector3 ();
				float angle = Mathf.Atan2 (target2.position.y - player.position.y, target2.position.x - player.position.x);
				
				newPosition.x = Mathf.Cos (angle) * step;
				newPosition.y = Mathf.Sin (angle) * step;
				
				player.position += newPosition;
			}	
			}

			else if (counter == 4) {
			float step = speed * Time.deltaTime;
			
			//print (player.position);
			//print (target.position);
			
			
			Vector3 newPosition = new Vector3 ();
			float angle = Mathf.Atan2 (target3.position.y - player.position.y, target3.position.x - player.position.x);
			
			newPosition.x = Mathf.Cos (angle) * step;
			newPosition.y = Mathf.Sin (angle) * step;
			
			player.position += newPosition;
		} 
		else if (counter == 5) {
			if (counter == 5) {
				float step = speed * Time.deltaTime;
				
				//print (player.position);
				//print (target.position);
				
				
				Vector3 newPosition = new Vector3 ();
				float angle = Mathf.Atan2 (target4.position.y - player.position.y, target4.position.x - player.position.x);
				
				newPosition.x = Mathf.Cos (angle) * step;
				newPosition.y = Mathf.Sin (angle) * step;
				
				player.position += newPosition;
			}	
		}
		}
}