using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000FD RID: 253
[Token(Token = "0x20000FD")]
public class ZumaPrize : PrizeMgr
{
	// Token: 0x060004CF RID: 1231 RVA: 0x0001972C File Offset: 0x0001792C
	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x5B8A80", Offset = "0x5B7080", VA = "0x1805B8A80", Slot = "4")]
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

	// Token: 0x060004D0 RID: 1232 RVA: 0x000197A8 File Offset: 0x000179A8
	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x5B8500", Offset = "0x5B6B00", VA = "0x1805B8500", Slot = "5")]
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

	// Token: 0x060004D1 RID: 1233 RVA: 0x000198B8 File Offset: 0x00017AB8
	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x5B89D0", Offset = "0x5B6FD0", VA = "0x1805B89D0", Slot = "6")]
	public override void GoBack()
	{
		SaveInfo.Instance.SavePlayerData();
		UIMgr.BackToMenu();
		global::UnityEngine.Object.Destroy(Zuma.Instance.gameObject);
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x000198EC File Offset: 0x00017AEC
	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x5B8B90", Offset = "0x5B7190", VA = "0x1805B8B90")]
	public ZumaPrize()
	{
	}
}
