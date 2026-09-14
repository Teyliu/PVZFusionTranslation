using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000102 RID: 258
[Token(Token = "0x2000102")]
public class ZumaPrize : PrizeMgr
{
	// Token: 0x060004EA RID: 1258 RVA: 0x00019B30 File Offset: 0x00017D30
	[Token(Token = "0x60004EA")]
	[Address(RVA = "0x5EE550", Offset = "0x5ECB50", VA = "0x1805EE550", Slot = "4")]
	protected override void Update()
	{
		float y = this.velocity.y;
		float deltaTime = Time.deltaTime;
		this.velocity.y = y;
		Transform transform = base.transform;
		float deltaTime2 = Time.deltaTime;
		Transform transform2 = base.transform;
		Vector3 vector;
		if (this.startPosition.y > vector.y)
		{
			this.isLand = true;
		}
		if (Input.GetMouseButtonDown(0))
		{
			this.Click();
		}
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x00019BAC File Offset: 0x00017DAC
	[Token(Token = "0x60004EB")]
	[Address(RVA = "0x5EDFD0", Offset = "0x5EC5D0", VA = "0x1805EDFD0", Slot = "5")]
	protected override void Click()
	{
		Camera main = Camera.main;
		float z = Input.mousePosition.z;
		Vector2 zeroVector = Vector2.zeroVector;
		int num = 0;
		RaycastHit2D[] array;
		if (num < array.Length)
		{
			int num2 = 0;
			Collider2D collider2D;
			if (collider2D != num2)
			{
				Collider2D collider2D2;
				GameObject gameObject = collider2D2.gameObject;
				GameObject gameObject2 = base.gameObject;
				if (gameObject == gameObject2)
				{
					LevelType theBoardType = GameAPP.theBoardType;
					if (theBoardType == LevelType.Advanture || theBoardType == LevelType.Advanture || theBoardType == LevelType.Advanture || theBoardType == LevelType.Challenge)
					{
						bool[] advLevelCompleted = GameAPP.advLevelCompleted;
						int theBoardLevel = GameAPP.theBoardLevel;
					}
					IEnumerator enumerator = base.MoveAndScaleObject();
					Coroutine coroutine = base.StartCoroutine(enumerator);
					uint num3;
					GameAPP.PlaySound((int)num3, 0.5f, 1f);
					GameAPP.music.Stop();
					GameAPP.prelude.audioSource.Stop();
					GameAPP.musicDrum.Stop();
					uint num4;
					ulong num5;
					base.transform.GetChild((int)num4).gameObject.SetActive(num5 != 0UL);
				}
			}
			num++;
		}
		SaveInfo.Instance.SavePlayerData();
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x00019CBC File Offset: 0x00017EBC
	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x5EE4A0", Offset = "0x5ECAA0", VA = "0x1805EE4A0", Slot = "6")]
	public override void GoBack()
	{
		SaveInfo.Instance.SavePlayerData();
		UIMgr.BackToMenu();
		global::UnityEngine.Object.Destroy(Zuma.Instance.gameObject);
	}

	// Token: 0x060004ED RID: 1261 RVA: 0x00019CF0 File Offset: 0x00017EF0
	[Token(Token = "0x60004ED")]
	[Address(RVA = "0x5EE660", Offset = "0x5ECC60", VA = "0x1805EE660")]
	public ZumaPrize()
	{
	}
}
