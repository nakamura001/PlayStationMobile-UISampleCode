// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace Preview
{
    partial class MainScene
    {
        Button Button_1;
        ImageBox ImageBox_1;
        Button Button_2;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            Button_1 = new Button();
            Button_1.Name = "Button_1";
            ImageBox_1 = new ImageBox();
            ImageBox_1.Name = "ImageBox_1";
            Button_2 = new Button();
            Button_2.Name = "Button_2";

            // Button_1
            Button_1.TextColor = new UIColor(15f / 255f, 255f / 255f, 56f / 255f, 255f / 255f);
            Button_1.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // ImageBox_1
            ImageBox_1.Image = new ImageAsset("/Application/assets/player.jpg");
            ImageBox_1.ImageScaleType = ImageScaleType.AspectInside;

            // Button_2
            Button_2.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            Button_2.TextFont = new UIFont(FontAlias.System, 25, FontStyle.Regular);

            // MainScene
            this.RootWidget.AddChildLast(Button_1);
            this.RootWidget.AddChildLast(ImageBox_1);
            this.RootWidget.AddChildLast(Button_2);

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

                    Button_1.SetPosition(387, 217);
                    Button_1.SetSize(214, 56);
                    Button_1.Anchors = Anchors.None;
                    Button_1.Visible = true;

                    ImageBox_1.SetPosition(41, 42);
                    ImageBox_1.SetSize(200, 200);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    Button_2.SetPosition(380, 92);
                    Button_2.SetSize(214, 56);
                    Button_2.Anchors = Anchors.None;
                    Button_2.Visible = true;

                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    Button_1.SetPosition(337, 219);
                    Button_1.SetSize(285, 105);
                    Button_1.Anchors = Anchors.Top | Anchors.Left;
                    Button_1.Visible = true;

                    ImageBox_1.SetPosition(41, 42);
                    ImageBox_1.SetSize(262, 389);
                    ImageBox_1.Anchors = Anchors.None;
                    ImageBox_1.Visible = true;

                    Button_2.SetPosition(380, 92);
                    Button_2.SetSize(214, 56);
                    Button_2.Anchors = Anchors.None;
                    Button_2.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            Button_1.Text = UIStringTable.Get(UIStringID.ID_TEST);

            Button_2.Text = "Button";
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
