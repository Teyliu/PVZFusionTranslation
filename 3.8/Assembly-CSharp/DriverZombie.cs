using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200064E RID: 1614
[Token(Token = "0x200064E")]
public class DriverZombie : Zombie
{
	// Token: 0x06001EA6 RID: 7846 RVA: 0x000A3C64 File Offset: 0x000A1E64
	[Token(Token = "0x6001EA6")]
	[Address(RVA = "0x53E9C0", Offset = "0x53CFC0", VA = "0x18053E9C0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		GameAPP.PlaySound(76, 1f, 1f);
		float num = this.startSpeed;
		this.currentSpeed = num;
	}

	// Token: 0x06001EA7 RID: 7847 RVA: 0x000A3C98 File Offset: 0x000A1E98
	[Token(Token = "0x6001EA7")]
	[Address(RVA = "0x53E700", Offset = "0x53CD00", VA = "0x18053E700", Slot = "21")]
	protected override void PositionUpdate()
	{
		Board board = this.board;
		Transform axis = this.axis;
		float num = this.currentSpeed;
		Rigidbody2D rb = this.rb;
		Transform child = base.transform.GetChild(2);
		List<IceRoad> iceRoads = this.board.iceRoads;
		int theZombieRow = this.theZombieRow;
		float x = iceRoads[theZombieRow].x;
		Board board2 = this.board;
		List<IceRoad> iceRoads2 = this.board.iceRoads;
		int theZombieRow2 = this.theZombieRow;
		iceRoads2[theZombieRow2].fadeTimer = 30f;
		Board board3 = this.board;
		Transform axis2 = this.axis;
		float num2 = this.currentSpeed;
		Rigidbody2D rb2 = this.rb;
		float num3 = this.currentSpeed;
		if (num3 > 0.2f)
		{
			float deltaTime = Time.deltaTime;
			this.currentSpeed = num3;
		}
	}

	// Token: 0x06001EA8 RID: 7848 RVA: 0x000A3D78 File Offset: 0x000A1F78
	[Token(Token = "0x6001EA8")]
	[Address(RVA = "0x537D20", Offset = "0x536320", VA = "0x180537D20", Slot = "27")]
	public override void Die(int reason = 0)
	{
		base.Die(reason);
	}

	// Token: 0x06001EA9 RID: 7849 RVA: 0x000A3D8C File Offset: 0x000A1F8C
	[Token(Token = "0x6001EA9")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06001EAA RID: 7850 RVA: 0x000A3D9C File Offset: 0x000A1F9C
	[Token(Token = "0x6001EAA")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
	}

	// Token: 0x06001EAB RID: 7851 RVA: 0x000A3DAC File Offset: 0x000A1FAC
	[Token(Token = "0x6001EAB")]
	[Address(RVA = "0x53DE10", Offset = "0x53C410", VA = "0x18053DE10")]
	private void CreateIceRoad()
	{
		Transform child = base.transform.GetChild(2);
		List<IceRoad> iceRoads = this.board.iceRoads;
		int theZombieRow = this.theZombieRow;
		float x = iceRoads[theZombieRow].x;
		Board board = this.board;
		List<IceRoad> iceRoads2 = this.board.iceRoads;
		int theZombieRow2 = this.theZombieRow;
		iceRoads2[theZombieRow2].fadeTimer = 30f;
	}

	// Token: 0x06001EAC RID: 7852 RVA: 0x000A3E20 File Offset: 0x000A2020
	[Token(Token = "0x6001EAC")]
	[Address(RVA = "0x53D760", Offset = "0x53BD60", VA = "0x18053D760", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		int num;
		do
		{
			num = 0;
			int num2 = this.theHealth;
			num2 -= theDamage;
			this.theHealth = num2;
			num2 -= theDamage;
			num2 -= theDamage;
			float num3;
			float num4;
			if (num3 > num4)
			{
				Transform transform = base.transform;
				int num5 = 0;
				SpriteRenderer component = transform.GetChild(num5).GetComponent<SpriteRenderer>();
				Sprite sprite = GameAPP.spritePrefab[29];
				component.sprite = sprite;
				uint num6;
				SpriteRenderer component2 = base.transform.GetChild((int)num6).GetComponent<SpriteRenderer>();
				Sprite sprite2 = GameAPP.spritePrefab[31];
				component2.sprite = sprite2;
			}
			float num7;
			if (num7 <= num3)
			{
				break;
			}
			this.anim.SetTrigger("shake");
			Transform transform2 = base.transform;
			int num8 = 0;
			SpriteRenderer component3 = transform2.GetChild(num8).GetComponent<SpriteRenderer>();
			Sprite sprite3 = GameAPP.spritePrefab[30];
			component3.sprite = sprite3;
			uint num9;
			SpriteRenderer component4 = base.transform.GetChild((int)num9).GetComponent<SpriteRenderer>();
			Sprite sprite4 = GameAPP.spritePrefab[32];
			component4.sprite = sprite4;
			uint num10;
			Transform child = base.transform.GetChild((int)num10);
			int num11 = 0;
			ulong num12;
			child.GetChild(num11).gameObject.SetActive(num12 != 0UL);
			uint num13;
			Transform child2 = base.transform.GetChild((int)num13);
			int num14 = 0;
			GameObject gameObject = child2.GetChild(num14).gameObject;
			ulong num15;
			gameObject.SetActive(num15 != 0UL);
			IEnumerator enumerator = gameObject.transform.GetEnumerator();
			Renderer component6;
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				enumerator += enumerator;
				ParticleSystem particleSystem;
				Renderer component5 = particleSystem.GetComponent<Renderer>();
				int theZombieRow = this.theZombieRow;
				string text = string.Format("zombie{0}", component5);
				component5.sortingLayerName = text;
				ParticleSystem particleSystem2;
				component6 = particleSystem2.GetComponent<Renderer>();
				uint num16;
				component6.sortingOrder = (int)num16;
			}
			if (component6 != 0)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06001EAD RID: 7853 RVA: 0x000A4014 File Offset: 0x000A2214
	[Token(Token = "0x6001EAD")]
	[Address(RVA = "0x530300", Offset = "0x52E900", VA = "0x180530300")]
	protected void DieAndExplode()
	{
	}

	// Token: 0x06001EAE RID: 7854 RVA: 0x000A4024 File Offset: 0x000A2224
	[Token(Token = "0x6001EAE")]
	[Address(RVA = "0x53DF30", Offset = "0x53C530", VA = "0x18053DF30", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[34];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
	}

	// Token: 0x06001EAF RID: 7855 RVA: 0x000A407C File Offset: 0x000A227C
	[Token(Token = "0x6001EAF")]
	[Address(RVA = "0x538170", Offset = "0x536770", VA = "0x180538170")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x06001EB0 RID: 7856 RVA: 0x000A409C File Offset: 0x000A229C
	[Token(Token = "0x6001EB0")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06001EB1 RID: 7857 RVA: 0x000A40AC File Offset: 0x000A22AC
	[Token(Token = "0x6001EB1")]
	[Address(RVA = "0x53E0F0", Offset = "0x53C6F0", VA = "0x18053E0F0", Slot = "73")]
	public override void KillByCaltrop()
	{
		int num;
		do
		{
			num = 0;
			this.anim.SetTrigger("shake");
			this.anim.SetTrigger("GoDie");
			Transform transform = base.transform;
			int num2 = 0;
			SpriteRenderer component = transform.GetChild(num2).GetComponent<SpriteRenderer>();
			Sprite sprite = GameAPP.spritePrefab[30];
			component.sprite = sprite;
			uint num3;
			SpriteRenderer component2 = base.transform.GetChild((int)num3).GetComponent<SpriteRenderer>();
			Sprite sprite2 = GameAPP.spritePrefab[32];
			component2.sprite = sprite2;
			uint num4;
			Transform child = base.transform.GetChild((int)num4);
			int num5 = 0;
			ulong num6;
			child.GetChild(num5).gameObject.SetActive(num6 != 0UL);
			uint num7;
			Transform child2 = base.transform.GetChild((int)num7);
			int num8 = 0;
			GameObject gameObject = child2.GetChild(num8).gameObject;
			ulong num9;
			gameObject.SetActive(num9 != 0UL);
			IEnumerator enumerator = gameObject.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				enumerator += enumerator;
				ParticleSystem particleSystem;
				Renderer component3 = particleSystem.GetComponent<Renderer>();
				int theZombieRow = this.theZombieRow;
				string text = string.Format("zombie{0}", component3);
				component3.sortingLayerName = text;
				ParticleSystem particleSystem2;
				uint num10;
				particleSystem2.GetComponent<Renderer>().sortingOrder = (int)num10;
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		int num11 = 0;
		BoxCollider2D boxCollider2D;
		boxCollider2D.enabled = num11 != 0;
	}

	// Token: 0x06001EB2 RID: 7858 RVA: 0x000A4238 File Offset: 0x000A2438
	[Token(Token = "0x6001EB2")]
	[Address(RVA = "0x53EA60", Offset = "0x53D060", VA = "0x18053EA60")]
	public DriverZombie()
	{
	}

	// Token: 0x0400105F RID: 4191
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400105F")]
	protected float startSpeed = 0.8f;

	// Token: 0x04001060 RID: 4192
	[FieldOffset(Offset = "0x25C")]
	[Token(Token = "0x4001060")]
	protected float currentSpeed = 0.8f;
}
