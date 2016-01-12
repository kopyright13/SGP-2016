using UnityEngine;

public class WeaponScript : MonoBehaviour
{
	public Transform bombPrefab;

	public float shootingRate = 0.25f;

	private float shootCooldown;
	
	void Start()
	{
		shootCooldown = 0f;
	}
	
	void Update()
	{
		if (shootCooldown > 0)
		{
			shootCooldown -= Time.deltaTime;
		}
	}

	public void Attack(bool isEnemy)
	{
		if (CanAttack)
		{
			shootCooldown = shootingRate;

			var bombTransform = Instantiate(bombPrefab) as Transform;

			bombTransform.position = transform.position;

			BombScript shot = bombTransform.gameObject.GetComponent<BombScript>();

			if (shot != null)
			{
				shot.isEnemyShot = isEnemy;
			}

			MoveScript move = bombTransform.gameObject.GetComponent<MoveScript>();

			if (move != null)
			{
				move.direction = this.transform.right;
			}
		}
	}

	public bool CanAttack
	{
		get
		{
			return shootCooldown <= 0f;
		}
	}
}
