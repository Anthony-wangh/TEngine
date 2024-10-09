using System;
using Cysharp.Threading.Tasks;
using GameBase;
using TEngine;

namespace GameMain
{
    public class ProcedureStartGame : ProcedureBase
    {
        public override bool UseNativeDialog { get; }

        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);
            //GameModule.UI.ShowUIAsync<TestPanel>();
            StartGame().Forget();            
        }

        private async UniTaskVoid StartGame()
        {
            await UniTask.Yield();
            UILoadMgr.HideAll();
        }
    }
}