using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000D7 RID: 215
[Token(Token = "0x20000D7")]
public class NutCannon : MonoBehaviour
{
	// Token: 0x06000417 RID: 1047 RVA: 0x00014D74 File Offset: 0x00012F74
	[Token(Token = "0x6000417")]
	[Address(RVA = "0x4BDD50", Offset = "0x4BC350", VA = "0x1804BDD50")]
	public void Shoot()
	{
		NutCannon_bullet nutCannon_bullet = this.shootObj;
		nutCannon_bullet.launched = true;
		Transform transform = nutCannon_bullet.transform;
		Transform transform2 = Board.Instance.transform;
		transform.parentInternal = transform2;
		NutCannon_bullet nutCannon_bullet2 = this.waitObj;
		this.shootObj = nutCannon_bullet2;
		Transform transform3 = this.shootObj.transform;
		Transform transform4 = this.shoot;
		transform3.parentInternal = transform4;
		Transform transform5 = this.shootObj.transform;
		Transform transform6 = this.shootObj.transform;
		Transform transform7 = this.shootObj.transform;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		transform7.localRotation = identityQuaternion;
		NutCannon_bullet bullet = this.GetBullet((PlantType)((uint)3));
		this.waitObj = bullet;
		Transform transform8 = this.waitObj.transform;
		Transform transform9 = this.wait;
		transform8.parentInternal = transform9;
		Transform transform10 = this.waitObj.transform;
		Transform transform11 = this.waitObj.transform;
		Transform transform12 = this.waitObj.transform;
		Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
		transform12.localRotation = identityQuaternion2;
		this.anim.SetTrigger("shoot");
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x00014EA0 File Offset: 0x000130A0
	[Token(Token = "0x6000418")]
	[Address(RVA = "0x4BE1C0", Offset = "0x4BC7C0", VA = "0x1804BE1C0")]
	private void Start()
	{
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		NutCannon_bullet bullet = this.GetBullet((PlantType)((uint)3));
		this.shootObj = bullet;
		Transform transform = this.shootObj.transform;
		Transform transform2 = this.shoot;
		transform.parentInternal = transform2;
		Transform transform3 = this.shootObj.transform;
		Transform transform4 = this.shootObj.transform;
		Transform transform5 = this.shootObj.transform;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		transform5.localRotation = identityQuaternion;
		NutCannon_bullet bullet2 = this.GetBullet((PlantType)((uint)3));
		this.waitObj = bullet2;
		Transform transform6 = this.waitObj.transform;
		Transform transform7 = this.wait;
		transform6.parentInternal = transform7;
		Transform transform8 = this.waitObj.transform;
		Transform transform9 = this.waitObj.transform;
		Transform transform10 = this.waitObj.transform;
		Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
		transform10.localRotation = identityQuaternion2;
	}

	// Token: 0x06000419 RID: 1049 RVA: 0x00014F8C File Offset: 0x0001318C
	[Token(Token = "0x6000419")]
	[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0")]
	private PlantType GetPlantType()
	{
		return PlantType.WallNut;
	}

	// Token: 0x0600041A RID: 1050 RVA: 0x00014F9C File Offset: 0x0001319C
	[Token(Token = "0x600041A")]
	[Address(RVA = "0x4BE580", Offset = "0x4BCB80", VA = "0x1804BE580")]
	private void Update()
	{
		if (this.auto)
		{
			if (this.auto)
			{
				return;
			}
		}
		else
		{
			Camera main = Camera.main;
			float z = Input.mousePosition.z;
			Transform transform = base.transform;
			Vector3 vector;
			float z2 = vector.z;
			Transform transform2 = this.cannonPos.transform;
			bool mouseButton = Input.GetMouseButton(0);
			while (!mouseButton)
			{
			}
			while (mouseButton)
			{
			}
		}
		this.Shoot();
		this.timer = 0.2f;
		throw new NullReferenceException();
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x00015018 File Offset: 0x00013218
	[Token(Token = "0x600041B")]
	[Address(RVA = "0x4BDAB0", Offset = "0x4BC0B0", VA = "0x1804BDAB0")]
	private void FixedUpdate()
	{
		float num = this.timer;
		int num2 = 0;
		if (num > (float)num2)
		{
			float fixedDeltaTime = Time.fixedDeltaTime;
			this.timer = num;
			this.timer = 0f;
		}
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x0001504C File Offset: 0x0001324C
	[Token(Token = "0x600041C")]
	[Address(RVA = "0x4BDB00", Offset = "0x4BC100", VA = "0x1804BDB00")]
	private NutCannon_bullet GetBullet(PlantType theSeedType)
	{
		Dictionary<PlantType, GameObject> plantPreviews = GameAPP.resourcesManager.plantPreviews;
		bool flag;
		if (!flag)
		{
		}
		NutCannon_bullet nutCannon_bullet = new GameObject("bullet").AddComponent<NutCannon_bullet>();
		nutCannon_bullet.thePlantType = theSeedType;
		GameObject gameObject;
		Transform transform = gameObject.transform;
		Transform transform2 = nutCannon_bullet.transform;
		transform.parentInternal = transform2;
		Transform transform3 = gameObject.transform;
		throw new NullReferenceException();
	}

	// Token: 0x0600041D RID: 1053 RVA: 0x000150B4 File Offset: 0x000132B4
	[Token(Token = "0x600041D")]
	[Address(RVA = "0x4BE730", Offset = "0x4BCD30", VA = "0x1804BE730")]
	public NutCannon()
	{
	}

	// Token: 0x04000230 RID: 560
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000230")]
	public Transform cannonPos;

	// Token: 0x04000231 RID: 561
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000231")]
	public Transform shoot;

	// Token: 0x04000232 RID: 562
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000232")]
	public Transform wait;

	// Token: 0x04000233 RID: 563
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000233")]
	public bool auto = true;

	// Token: 0x04000234 RID: 564
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000234")]
	private NutCannon_bullet shootObj;

	// Token: 0x04000235 RID: 565
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000235")]
	private NutCannon_bullet waitObj;

	// Token: 0x04000236 RID: 566
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000236")]
	private Animator anim;

	// Token: 0x04000237 RID: 567
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000237")]
	private float timer;
}
