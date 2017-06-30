using BeardedManStudios.Forge.Networking.Frame;
using BeardedManStudios.Forge.Networking.Unity;
using System;
using UnityEngine;

namespace BeardedManStudios.Forge.Networking.Generated
{
	[GeneratedInterpol("{\"inter\":[]")]
	public partial class GameStateManagerNetworkObject : NetworkObject
	{
		public const int IDENTITY = 4;

		private byte[] _dirtyFields = new byte[0];


		protected override void OwnershipChanged()
		{
			SnapInterpolations();
		}
		
		public void SnapInterpolations()
		{
		}

		public override int UniqueIdentity { get { return IDENTITY; } }

		protected override BMSByte WritePayload(BMSByte data)
		{

			return data;
		}

		protected override void ReadPayload(BMSByte payload, ulong timestep)
		{
		}

		protected override BMSByte SerializeDirtyFields()
		{
			dirtyFieldsData.Clear();
			dirtyFieldsData.Append(_dirtyFields);


			return dirtyFieldsData;
		}

		protected override void ReadDirtyFields(BMSByte data, ulong timestep)
		{
			if (readDirtyFlags == null)
				Initialize();

			Buffer.BlockCopy(data.byteArr, data.StartIndex(), readDirtyFlags, 0, readDirtyFlags.Length);
			data.MoveStartIndex(readDirtyFlags.Length);

		}

		public override void InterpolateUpdate()
		{
			if (IsOwner)
				return;

		}

		private void Initialize()
		{
			if (readDirtyFlags == null)
				readDirtyFlags = new byte[0];

		}

		public GameStateManagerNetworkObject() : base() { Initialize(); }
		public GameStateManagerNetworkObject(NetWorker networker, INetworkBehavior networkBehavior = null, int createCode = 0) : base(networker, networkBehavior, createCode) { Initialize(); }
		public GameStateManagerNetworkObject(NetWorker networker, uint serverId, FrameStream frame) : base(networker, serverId, frame) { Initialize(); }

		// DO NOT TOUCH, THIS GETS GENERATED PLEASE EXTEND THIS CLASS IF YOU WISH TO HAVE CUSTOM CODE ADDITIONS
	}
}