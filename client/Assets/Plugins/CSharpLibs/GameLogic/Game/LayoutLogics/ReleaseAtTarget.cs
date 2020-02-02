﻿using System;
using GameLogic.Game.Elements;
using EngineCore;
using UMath;

namespace GameLogic.Game.LayoutLogics
{
	public class ReleaseAtTarget:IReleaserTarget
	{
		public ReleaseAtTarget (BattleCharacter releaser, BattleCharacter target)
		{
			Releaser = releaser;
			ReleaserTarget = target;
		}

		//public BattleCharacter Releaser;

		#region IReleaserTarget implementation

		public BattleCharacter Releaser {
			get ;
			private set;
		}

		public BattleCharacter ReleaserTarget {
			get ;
			private set;
		}

		public UVector3 TargetPosition {
			get {

                return ReleaserTarget.View.Transform.position;
			}
		}

		#endregion
	}
}

