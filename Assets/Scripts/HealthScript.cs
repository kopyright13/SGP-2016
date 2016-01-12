using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour
{
	public int hp = 1;

	public bool isEnemy = true;

	public void Damage(int damageCount)
	{

		hp -= damageCount;
		
		if (hp <= 0)
		{
			Destroy(gameObject);
		}
	}
	
	void OnTriggerEnter(Collider otherCollider)
	{

		BombScript shot = otherCollider.gameObject.GetComponent<BombScript>();

		if (shot != null)
		{
			if (shot.isEnemyShot != isEnemy)
			{
				Damage(shot.damage);

				Destroy(shot.gameObject); 
			}
		}
	}
}