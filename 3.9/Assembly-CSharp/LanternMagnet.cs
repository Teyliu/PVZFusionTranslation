using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003DE RID: 990
[Token(Token = "0x20003DE")]
public class LanternMagnet : Magnetshroom
{
	// Token: 0x0600120C RID: 4620 RVA: 0x000653C4 File Offset: 0x000635C4
	[Token(Token = "0x600120C")]
	[Address(RVA = "0x49AE70", Offset = "0x499470", VA = "0x18049AE70", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Zombie", "Ladder" });
		this.magnetLayer = layerMask;
		ParticleSystem component = base.transform.Find("LanternShine").GetComponent<ParticleSystem>();
		this.lightShine = component;
		throw new NullReferenceException();
	}

	// Token: 0x0600120D RID: 4621 RVA: 0x0006542C File Offset: 0x0006362C
	[Token(Token = "0x600120D")]
	[Address(RVA = "0x49AFC0", Offset = "0x4995C0", VA = "0x18049AFC0", Slot = "68")]
	protected override void MagnetUpdate()
	{
		this.SetRange();
	}

	// Token: 0x0600120E RID: 4622 RVA: 0x00065440 File Offset: 0x00063640
	[Token(Token = "0x600120E")]
	[Address(RVA = "0x49B010", Offset = "0x499610", VA = "0x18049B010", Slot = "77")]
	protected virtual void SetRange()
	{
		ParticleSystem.MainModule main = this.lightShine.main;
		this.attrackMaxTime = 5f;
		this.attrackRange = 7f;
		this.rangeRow = 5f;
	}

	// Token: 0x0600120F RID: 4623 RVA: 0x000654DC File Offset: 0x000636DC
	[Token(Token = "0x600120F")]
	[Address(RVA = "0x49ABC0", Offset = "0x4991C0", VA = "0x18049ABC0", Slot = "72")]
	protected override Bucket AttrackItem(GameObject item, int theRow)
	{
		int num = 0;
		if (!(item == num))
		{
			Transform transform = item.transform;
			Vector3 vector;
			float z = vector.z;
			LayerMask zombieLayer = this.zombieLayer;
			int num2 = 0;
			int num3 = 0;
			Collider2D[] array;
			if (num2 < array.Length)
			{
				bool flag;
				bool flag2;
				if (flag && flag2)
				{
					PlantType thePlantType = this.thePlantType;
				}
				num3++;
			}
			return base.AttrackItem(item, theRow);
		}
		throw new IndexOutOfRangeException();
	}

	// Token: 0x06001210 RID: 4624 RVA: 0x0006554C File Offset: 0x0006374C
	[Token(Token = "0x6001210")]
	[Address(RVA = "0x49B110", Offset = "0x499710", VA = "0x18049B110")]
	public LanternMagnet()
	{
		this.attrackRange = 4f;
		this.attrackMaxTime = 15f;
		this.rangeRow = 2f;
		base..ctor();
	}

	// Token: 0x04000C31 RID: 3121
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000C31")]
	private ParticleSystem lightShine;
}
