// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace MessageBoxSample
{
    partial class MainScene
    {
        Button Button_1;
        Button Button_2;
        Label Label_1;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Button_1 = new Button();
            Button_1.Name = "Button_1";
            Button_2 = new Button();
            Button_2.Name = "Button_2";
            Label_1 = new Label();
            Label_1.Name = "Label_1";

            // Button_1
            Button_1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_1.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Button_2
            Button_2.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_2.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // Label_1
            Label_1.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Label_1.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Label_1.LineBreak = LineBreak.Character;
            Label_1.HorizontalAlignment = HorizontalAlignment.Center;

            // MainScene
            this.RootWidget.AddChildLast(Button_1);
            this.RootWidget.AddChildLast(Button_2);
            this.RootWidget.AddChildLast(Label_1);

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.DesignWidth = 544;
                    this.DesignHeight = 960;

                    Button_1.SetPosition(197, 268);
                    Button_1.SetSize(214, 56);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    Button_2.SetPosition(197, 268);
                    Button_2.SetSize(214, 56);
                    Button_2.Anchors = Anchors.None;
                    Button_2.Visible = true;

                    Label_1.SetPosition(371, 149);
                    Label_1.SetSize(214, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    Button_1.SetPosition(111, 334);
                    Button_1.SetSize(327, 107);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    Button_2.SetPosition(521, 334);
                    Button_2.SetSize(327, 107);
                    Button_2.Anchors = Anchors.None;
                    Button_2.Visible = true;

                    Label_1.SetPosition(89, 193);
                    Label_1.SetSize(782, 36);
                    Label_1.Anchors = Anchors.None;
                    Label_1.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Button_1.Text = "OKボタン付き";

            Button_2.Text = "OK/Cancelボタン付き";

            Label_1.Text = "ここにDialogで押された情報を表示";
        }

        private void onShowing(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    break;

                default:
                    break;
            }
        }

        private void onShown(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    break;

                default:
                    break;
            }
        }

    }
}
