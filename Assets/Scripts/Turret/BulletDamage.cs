using UnityEngine;
using System.Collections;

public class BulletDamage : MonoBehaviour {

	public int damage = 1;
	void OnTriggerEnter(Collider co) 
	{
		if (co.tag == "Player") {
			// Deal Damage, destroy Bullet
			co.GetComponent<Health> ().doDamage (damage);
			Destroy (this.gameObject);
		} else if(co.tag == "Block" || co.tag == "fill1" || co.tag == "filll2" || co.tag == "fill3" || co.tag == "blockblock") {
			Destroy (this.gameObject);
		}
		else if(co.tag == "Wall" || co.tag == "block1" || co.tag == "block2" || co.tag == "block3") {
			Destroy (this.gameObject);
		}
		else if(co.tag == "BlockLevel2" || co.tag == "BlockLevel3") {
			Destroy (this.gameObject);
		}
	}

	public void increaseDamage(int n)
	{
		this.damage += n;
	}
}
