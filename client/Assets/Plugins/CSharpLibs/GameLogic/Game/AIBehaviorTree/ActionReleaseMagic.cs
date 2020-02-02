﻿using System.Collections.Generic;
using BehaviorTree;
using EConfig;
using ExcelConfig;
using GameLogic.Game.Elements;
using GameLogic.Game.LayoutLogics;
using Layout.AITree;

namespace GameLogic.Game.AIBehaviorTree
{
    [TreeNodeParse(typeof(TreeNodeReleaseMagic))]
	public class ActionReleaseMagic : ActionComposite, ITreeNodeHandle
	{
        public override IEnumerable<RunStatus> Execute(ITreeRoot context)
        {
            var root = context as AITreeRoot;
            var index = root[AITreeRoot.TRAGET_INDEX];
            if (index == null)
            {
                yield return RunStatus.Failure;
                yield break;
            }

            if (!(root.Perception.State[(int)index] is BattleCharacter target))
            {
                yield return RunStatus.Failure;
                yield break;
            }

            string key = Node.magicKey;
            switch (Node.valueOf)
            {
                case MagicValueOf.BlackBoard:
                    {
                        var id = root[AITreeRoot.SELECT_MAGIC_ID];
                        if (id == null)
                        {
                            yield return RunStatus.Failure;
                            yield break;
                        }
                        var magicData = ExcelToJSONConfigManager.Current
                                                                .GetConfigByID<CharacterMagicData>((int)id);
                        key = magicData.MagicKey;
                        var attackSpeed = root.Character.AttackSpeed;
                        root.Character.AttachMagicHistory(magicData.ID,root.Time);
                    }
                    break;
                case MagicValueOf.MagicKey:
					{
						key = Node.magicKey;
					}
					break;
			}

			if (!root.Perception.View.ExistMagicKey(key))
			{
				yield return RunStatus.Failure;
				yield break;
			}

            releaser = root.Perception.CreateReleaser(
                 key,
                 new ReleaseAtTarget(root.Character, target),
                 ReleaserType.Magic
            );


            var time = root.Time;
            while (time + root.Character.AttackSpeed > root.Time)
            {
                yield return RunStatus.Running;
            }

		    yield return RunStatus.Success;
        }

		private TreeNodeReleaseMagic Node;

        private MagicReleaser releaser;

		public void SetTreeNode(TreeNode node)
		{
			Node = node as TreeNodeReleaseMagic;
		}

        public override void Stop(ITreeRoot context)
        {

            if (LastStatus.HasValue && LastStatus.Value == RunStatus.Running)
            {
                if (!releaser.IsLayoutStartFinish)
                {
                    releaser.StopAllPlayer();
                }
                releaser.SetState(ReleaserStates.ToComplete);
            }
            base.Stop(context);
        }

	}
}

