using System;
using TEngine;
using UnityEngine;
using UnityEngine.UI;

namespace GameBase
{
    [Window(UILayer.UI, fromResources: false, location: "TestPanel", fullScreen: false)]
    public class TestPanel : UIWindow
    {
        private Button _testBtn;

        public override void ScriptGenerator()
        {
            _testBtn = FindChildComponent<Button>("m_btnTest");

            _testBtn.onClick.AddListener(OnClick);
        }

        private void OnClick()
        {
            Debug.Log("!@@##$$%%%^^&&****(((");
        }
    }
}
