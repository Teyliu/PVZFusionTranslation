using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000373 RID: 883
[Token(Token = "0x2000373")]
public class DiamondImitater : Imitater
{
	// Token: 0x0600103C RID: 4156 RVA: 0x0005D588 File Offset: 0x0005B788
	[Token(Token = "0x600103C")]
	[Address(RVA = "0x42F060", Offset = "0x42D660", VA = "0x18042F060")]
	private void AnimExplode()
	{
		uint num2;
		int num = global::UnityEngine.Random.Range(0, (int)num2);
		List<PlantType> ultimatePlants = Lawnf.GetUltimatePlants();
		Predicate<PlantType> <>9__0_ = DiamondImitater.<>c.<>9__0_0;
		if (<>9__0_ == 0)
		{
			DiamondImitater.<>c.<>9__0_0 = delegate(PlantType p)
			{
				bool flag;
				return flag;
			};
		}
		int num3 = ultimatePlants.RemoveAll(<>9__0_);
		int num4 = ultimatePlants._size;
		int num5 = 0;
		CreatePlant instance = CreatePlant.Instance;
		num4 = global::UnityEngine.Random.Range(num5, num4);
		PlantType plantType = ultimatePlants[num4];
		Transform axis = this.axis;
		ParticleManager instance2 = ParticleManager.Instance;
		CreatePlant instance3 = CreatePlant.Instance;
		Plant plant;
		plant.GetComponent<Present>().AnimEvent();
		Transform axis2 = this.axis;
		CreateZombie instance4 = CreateZombie.Instance;
		Transform axis3 = this.axis;
		CreateZombie instance5 = CreateZombie.Instance;
		Zombie zombie;
		zombie.GetComponent<RandomZombie>().theFirstArmorHealth = (int)((ulong)1L);
	}

	// Token: 0x0600103D RID: 4157 RVA: 0x0005D7DC File Offset: 0x0005B9DC
	[Token(Token = "0x600103D")]
	[Address(RVA = "0x42FCA0", Offset = "0x42E2A0", VA = "0x18042FCA0")]
	private void FireBall()
	{
		GameObject gameObject = Resources.Load<GameObject>("Zombies/_Image/FireBall");
		int num = LayerMask.NameToLayer("Plant");
		Board board = this.board;
		int num2 = 0;
		if (num2 < board.rowNum)
		{
			BoxType[] roadType = this.board.roadType;
			Mouse instance = Mouse.Instance;
			int num3 = 0;
			float boxXFromColumn = instance.GetBoxXFromColumn(num3);
			float landY = Mouse.Instance.GetLandY(boxXFromColumn, num2);
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = this.board.transform;
			GameObject gameObject2;
			ZombieBall component = gameObject2.GetComponent<ZombieBall>();
			component.plant = true;
			component.gameObject.layer = num;
			SortingGroup component2 = component.GetComponent<SortingGroup>();
			int num4;
			num2 = num4;
			string text = string.Format("bullet{0}", num4);
			component2.sortingLayerName = text;
			component.theBallRow = num2;
			component.dmg = (int)((ulong)40L);
			Board board2 = this.board;
			num2++;
			uint num5;
			num5 += (uint)4;
		}
	}

	// Token: 0x0600103E RID: 4158 RVA: 0x0005D8D0 File Offset: 0x0005BAD0
	[Token(Token = "0x600103E")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public DiamondImitater()
	{
	}

	// Token: 0x02000374 RID: 884
	[Token(Token = "0x2000374")]
	private enum RandomEffect
	{
		// Token: 0x04000B74 RID: 2932
		[Token(Token = "0x4000B74")]
		TravelBuff,
		// Token: 0x04000B75 RID: 2933
		[Token(Token = "0x4000B75")]
		Sun,
		// Token: 0x04000B76 RID: 2934
		[Token(Token = "0x4000B76")]
		FireBall,
		// Token: 0x04000B77 RID: 2935
		[Token(Token = "0x4000B77")]
		KillZombies,
		// Token: 0x04000B78 RID: 2936
		[Token(Token = "0x4000B78")]
		DamagePlants
	}
}
