using UnityEngine;
using System.Collections;

public class MagnetScript2 : MonoBehaviour {

	public Transform player;
	public Transform target;
	public Transform target2;
	public float speed;
	static public int counter;

	void Update(){



				if (counter == 1) {
						float step = speed * Time.deltaTime;

						//print (target.position);
		

						Vector3 newPosition = new Vector3 ();
						float angle = Mathf.Atan2 (target.position.y - player.position.y, target.position.x - player.position.x);

						newPosition.x = Mathf.Cos (angle) * step;
						newPosition.y = Mathf.Sin (angle) * step;

						player.position += newPosition;
				} else if (counter == 2) {
			if (counter == 2) {
				float step = speed * Time.deltaTime;
				
				print (player.position);
				//print (target.position);
				
				
				Vector3 newPosition = new Vector3 ();
				float angle = Mathf.Atan2 (target2.position.y - player.position.y, target2.position.x - player.position.x);
				
				newPosition.x = Mathf.Cos (angle) * step;
				newPosition.y = Mathf.Sin (angle) * step;
				
				player.position += newPosition;
			}	
			}
		}
}