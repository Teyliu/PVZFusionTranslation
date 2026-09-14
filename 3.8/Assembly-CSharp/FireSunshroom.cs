using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004AA RID: 1194
[Token(Token = "0x20004AA")]
public class FireSunshroom : Producer
{
	// Token: 0x06001688 RID: 5768 RVA: 0x0007C898 File Offset: 0x0007AA98
	[Token(Token = "0x6001688")]
	[Address(RVA = "0x4A2D60", Offset = "0x4A1360", VA = "0x1804A2D60", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (PlantStatus)((ulong)34L);
		base.AttributeCountdown = 120f;
		this.attributeCount = (int)((ulong)12L);
	}

	// Token: 0x06001689 RID: 5769 RVA: 0x0007C8CC File Offset: 0x0007AACC
	[Token(Token = "0x6001689")]
	[Address(RVA = "0x4A31A0", Offset = "0x4A17A0", VA = "0x1804A31A0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		if (this.thePlantType <= PlantType.SunFlower)
		{
			this.anim.SetFloat("IdleType", 1f);
			return;
		}
	}

	// Token: 0x0600168A RID: 5770 RVA: 0x0007C904 File Offset: 0x0007AB04
	[Token(Token = "0x600168A")]
	[Address(RVA = "0x4A3210", Offset = "0x4A1810", VA = "0x1804A3210", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
			float num = this.timer;
			int num2 = 0;
			if (num > (float)num2)
			{
				float deltaTime = Time.deltaTime;
				this.timer = num;
				if (num2 > (int)num)
				{
					PlantType thePlantType = this.thePlantType;
					int num3 = 0;
					if (thePlantType == PlantType.FireSunshroom_a)
					{
						int num4 = 0;
						base.Die((Plant.DieReason)num4);
						CreatePlant instance = CreatePlant.Instance;
						int num5 = 0;
						Plant plant;
						if (!(plant != num5))
						{
							goto IL_0105;
						}
						float attributeCountdown = this.attributeCountdown;
						plant.AttributeCountdown = attributeCountdown;
						if (plant != 0)
						{
							goto IL_0105;
						}
						Transform axis = plant.axis;
						Transform transform = plant.transform;
					}
					if (thePlantType == PlantType.FireSunshroom_b)
					{
						int num6 = 0;
						base.Die((Plant.DieReason)num6);
						CreatePlant instance2 = CreatePlant.Instance;
						int num7 = 0;
						Plant plant2;
						if (plant2 != num7)
						{
							float attributeCountdown2 = this.attributeCountdown;
							plant2.AttributeCountdown = attributeCountdown2;
							if (plant2 == 0)
							{
								Transform axis2 = plant2.axis;
								Vector3 vector;
								float z = vector.z;
								Transform transform2 = plant2.transform;
								Vector3 vector2;
								float z2 = vector2.z;
							}
						}
					}
					IL_0105:
					this.timer = (float)num3;
				}
			}
		}
	}

	// Token: 0x0600168B RID: 5771 RVA: 0x0007CA28 File Offset: 0x0007AC28
	[Token(Token = "0x600168B")]
	[Address(RVA = "0x4A2C80", Offset = "0x4A1280", VA = "0x1804A2C80", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.theStatus = (PlantStatus)((ulong)0L);
		FireSunshroom.<Grow>d__5 <Grow>d__;
		<Grow>d__.System.IDisposable.Dispose();
		<Grow>d__.<>1__state = (int)((ulong)0L);
		<Grow>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Grow>d__);
		GameAPP.PlaySound(56, 0.5f, 1f);
	}

	// Token: 0x0600168C RID: 5772 RVA: 0x0007CA74 File Offset: 0x0007AC74
	[Token(Token = "0x600168C")]
	[Address(RVA = "0x4A3030", Offset = "0x4A1630", VA = "0x1804A3030")]
	private IEnumerator Grow()
	{
		FireSunshroom.<Grow>d__5 <Grow>d__;
		<Grow>d__.System.IDisposable.Dispose();
		<Grow>d__.<>1__state = (int)((ulong)0L);
		<Grow>d__.<>4__this = this;
		return null;
	}

	// Token: 0x0600168D RID: 5773 RVA: 0x0007CA98 File Offset: 0x0007AC98
	[Token(Token = "0x600168D")]
	[Address(RVA = "0x4A30A0", Offset = "0x4A16A0", VA = "0x1804A30A0", Slot = "70")]
	protected override void ProduceSun()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.3f, 1f);
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x0600168E RID: 5774 RVA: 0x0007CACC File Offset: 0x0007ACCC
	[Token(Token = "0x600168E")]
	[Address(RVA = "0x4A2DA0", Offset = "0x4A13A0", VA = "0x1804A2DA0", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num = this.zombieLayer;
		int num2 = 0;
		int num3 = 0;
		Collider2D[] array;
		if (num2 < array.Length)
		{
			bool flag;
			bool flag2;
			if (flag && flag2)
			{
				int attributeCount = this.attributeCount;
			}
			num3++;
		}
		Transform axis2 = this.axis;
		ParticleManager instance = ParticleManager.Instance;
	}

	// Token: 0x0600168F RID: 5775 RVA: 0x0007CB3C File Offset: 0x0007AD3C
	[Token(Token = "0x600168F")]
	[Address(RVA = "0x4A3620", Offset = "0x4A1C20", VA = "0x1804A3620")]
	public FireSunshroom()
	{
	}

	// Token: 0x04000D8C RID: 3468
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D8C")]
	private float timer = 150f;
}
