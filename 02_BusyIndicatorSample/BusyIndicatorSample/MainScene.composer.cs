// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace BusyIndicatorSample
{
    partial class MainScene
    {
        Button StartButton;
        Button StopButton;
        BusyIndicator BusyIndicator_1;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            StartButton = new Button();
            StartButton.Name = "StartButton";
            StopButton = new Button();
            StopButton.Name = "StopButton";
            BusyIndicator_1 = new BusyIndicator();
            BusyIndicator_1.Name = "BusyIndicator_1";

            // StartButton
            StartButton.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            StartButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // StopButton
            StopButton.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            StopButton.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // MainScene
            this.RootWidget.AddChildLast(StartButton);
            this.RootWidget.AddChildLast(StopButton);
            this.RootWidget.AddChildLast(BusyIndicator_1);

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

                    StartButton.SetPosition(295, 295);
                    StartButton.SetSize(214, 56);
                    StartButton.Anchors = Anchors.None;
                    StartButton.Visible = true;

                    StopButton.SetPosition(295, 295);
                    StopButton.SetSize(214, 56);
                    StopButton.Anchors = Anchors.None;
                    StopButton.Visible = true;

                    BusyIndicator_1.SetPosition(459, 221);
                    BusyIndicator_1.SetSize(48, 48);
                    BusyIndicator_1.Anchors = Anchors.Height | Anchors.Width;
                    BusyIndicator_1.Visible = true;

                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    StartButton.SetPosition(122, 370);
                    StartButton.SetSize(330, 80);
                    StartButton.Anchors = Anchors.None;
                    StartButton.Visible = true;

                    StopButton.SetPosition(507, 370);
                    StopButton.SetSize(330, 80);
                    StopButton.Anchors = Anchors.None;
                    StopButton.Visible = true;

                    BusyIndicator_1.SetPosition(456, 218);
                    BusyIndicator_1.SetSize(48, 48);
                    BusyIndicator_1.Anchors = Anchors.Height | Anchors.Width;
                    BusyIndicator_1.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            StartButton.Text = "アニメーション開始";

            StopButton.Text = "アニメーション停止";
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
