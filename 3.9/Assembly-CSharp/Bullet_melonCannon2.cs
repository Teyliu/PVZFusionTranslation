using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000173 RID: 371
[Token(Token = "0x2000173")]
public class Bullet_melonCannon2 : Bullet_cannon
{
	// Token: 0x06000693 RID: 1683 RVA: 0x00021F34 File Offset: 0x00020134
	[Token(Token = "0x6000693")]
	[Address(RVA = "0x804D50", Offset = "0x803350", VA = "0x180804D50", Slot = "14")]
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

	// Token: 0x06000694 RID: 1684 RVA: 0x0002201C File Offset: 0x0002021C
	[Token(Token = "0x6000694")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_melonCannon2()
	{
	}

	// Token: 0x0400038B RID: 907
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400038B")]
	public GameObject subMelonPrefab;
}
