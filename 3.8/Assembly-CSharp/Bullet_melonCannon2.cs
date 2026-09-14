using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200016D RID: 365
[Token(Token = "0x200016D")]
public class Bullet_melonCannon2 : Bullet_cannon
{
	// Token: 0x06000688 RID: 1672 RVA: 0x000225AC File Offset: 0x000207AC
	[Token(Token = "0x6000688")]
	[Address(RVA = "0x6C9CD0", Offset = "0x6C82D0", VA = "0x1806C9CD0", Slot = "13")]
	protected override bool CannonEffect()
	{
		int num = 0;
		int num2 = 0;
		GameObject gameObject = this.subMelonPrefab;
		Transform transform = base.transform;
		float num3 = global::UnityEngine.Random.Range(-3f, 3f);
		float num4 = global::UnityEngine.Random.Range((float)num2, 6f);
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform2 = this.board.transform;
		GameObject gameObject2;
		SubMelon component = gameObject2.GetComponent<SubMelon>();
		int damage = this._damage;
		component.damage = damage;
		Board board = this.board;
		component.board = board;
		int theBulletRow = this.theBulletRow;
		component.row = theBulletRow;
		Vector2 cannonPos = this.cannonPos;
		float y = this.cannonPos.y;
		component.cannonTarget.y = y;
		component.cannonTarget = cannonPos;
		PlantType fromType = this.fromType;
		component.fromType = fromType;
		if (num == 0)
		{
			component.doom = true;
			num++;
		}
		num++;
		return true;
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x00022694 File Offset: 0x00020894
	[Token(Token = "0x6000689")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_melonCannon2()
	{
	}

	// Token: 0x04000382 RID: 898
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000382")]
	public GameObject subMelonPrefab;
}
