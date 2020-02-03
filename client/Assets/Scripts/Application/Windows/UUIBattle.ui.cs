using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UGameTools;
using UnityEngine.UI;
//AUTO GenCode Don't edit it.
namespace Windows
{
    [UIResources("UUIBattle")]
    partial class UUIBattle : UUIAutoGenWindow
    {
        public class GridTableTemplate : TableItemTemplate
        {
            public GridTableTemplate(){}
            public Button Button;
            public Text Cost;
            public Image ICdMask;

            public override void InitTemplate()
            {
                Button = FindChild<Button>("Button");
                Cost = FindChild<Text>("Cost");
                ICdMask = FindChild<Image>("ICdMask");

            }
        }


        protected GridLayoutGroup Grid;
        protected Text Time;
        protected Button bt_Auto;
        protected Text Text;
        protected Button bt_Exit;


        protected UITableManager<AutoGenTableItem<GridTableTemplate, GridTableModel>> GridTableManager = new UITableManager<AutoGenTableItem<GridTableTemplate, GridTableModel>>();


        protected override void InitTemplate()
        {
            base.InitTemplate();
            Grid = FindChild<GridLayoutGroup>("Grid");
            Time = FindChild<Text>("Time");
            bt_Auto = FindChild<Button>("bt_Auto");
            Text = FindChild<Text>("Text");
            bt_Exit = FindChild<Button>("bt_Exit");

            GridTableManager.InitFromGrid(Grid);

        }
    }
}