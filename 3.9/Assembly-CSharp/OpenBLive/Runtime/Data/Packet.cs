using System;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;

namespace OpenBLive.Runtime.Data
{
	// Token: 0x02000E55 RID: 3669
	[Token(Token = "0x2000E55")]
	public struct Packet
	{
		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06004B57 RID: 19287 RVA: 0x001723CC File Offset: 0x001705CC
		[Token(Token = "0x17000973")]
		public int Length
		{
			[Token(Token = "0x6004B57")]
			[Address(RVA = "0x8CF440", Offset = "0x8CDA40", VA = "0x1808CF440")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06004B58 RID: 19288 RVA: 0x001723DC File Offset: 0x001705DC
		[Token(Token = "0x6004B58")]
		[Address(RVA = "0x8CF280", Offset = "0x8CD880", VA = "0x1808CF280")]
		public Packet(ReadOnlySpan<byte> bytes)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException();
			int num = 0;
			int num2 = 0;
			this.Header = num;
			if (bytes <= num2)
			{
				num2 -= bytes;
			}
			ThrowHelper.ThrowArgumentOutOfRangeException();
			byte[] array;
			this.PacketBody = array;
		}

		// Token: 0x06004B59 RID: 19289 RVA: 0x0017241C File Offset: 0x0017061C
		[Token(Token = "0x6004B59")]
		[Address(RVA = "0x8CF3F0", Offset = "0x8CD9F0", VA = "0x1808CF3F0")]
		public Packet(Operation operation, [Optional] byte[] body)
		{
			int num = 0;
			if (body != 0)
			{
			}
			num += 16;
			this.Header = num;
			this.PacketBody = body;
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06004B5A RID: 19290 RVA: 0x00172444 File Offset: 0x00170644
		[Token(Token = "0x17000974")]
		public byte[] ToBytes
		{
			[Token(Token = "0x6004B5A")]
			[Address(RVA = "0x8CF450", Offset = "0x8CDA50", VA = "0x1808CF450")]
			get
			{
				if (this.PacketBody != (ulong)0L)
				{
				}
				byte[] array = new byte[0];
				int num = 0;
				if (this.PacketBody != (ulong)0L)
				{
					int num2 = 0;
					int num3;
					Array.Copy(this.PacketBody, num2, array, num, num3);
				}
				return array;
			}
		}

		// Token: 0x06004B5B RID: 19291 RVA: 0x0017248C File Offset: 0x0017068C
		[Token(Token = "0x6004B5B")]
		[Address(RVA = "0x8CEFF0", Offset = "0x8CD5F0", VA = "0x1808CEFF0")]
		public static Packet HeartBeat(string msg)
		{
			Encoding utf = Encoding.UTF8;
			byte[] array;
			if (array != 0)
			{
				int num = array.Length;
				num += 16;
			}
			Packet packet = Packet.s_NoBodyHeartBeatPacket;
			throw new NullReferenceException();
		}

		// Token: 0x06004B5C RID: 19292 RVA: 0x001724C8 File Offset: 0x001706C8
		[Token(Token = "0x6004B5C")]
		[Address(RVA = "0x8CF120", Offset = "0x8CD720", VA = "0x1808CF120")]
		public static Packet HeartBeat([Optional] byte[] msg)
		{
			Packet packet = Packet.s_NoBodyHeartBeatPacket;
			msg.m_value = packet;
			return default(Packet);
		}

		// Token: 0x06004B5D RID: 19293 RVA: 0x001724F0 File Offset: 0x001706F0
		[Token(Token = "0x6004B5D")]
		[Address(RVA = "0x8CEF40", Offset = "0x8CD540", VA = "0x1808CEF40")]
		public static Packet Authority(string token, ProtocolVersion protocolVersion = ProtocolVersion.Brotli)
		{
			int num = 0;
			token._stringLength = num;
			Encoding utf = Encoding.UTF8;
			int num2 = 0;
			token._stringLength = num2;
			byte[] array;
			int num3 = array.Length;
			num3 += 16;
			token._stringLength = (int)((ulong)1L);
			throw new NullReferenceException();
		}

		// Token: 0x04003592 RID: 13714
		[Token(Token = "0x4003592")]
		private static readonly Packet s_NoBodyHeartBeatPacket = 0;

		// Token: 0x04003593 RID: 13715
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003593")]
		public PacketHeader Header;

		// Token: 0x04003594 RID: 13716
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003594")]
		public byte[] PacketBody;
	}
}
