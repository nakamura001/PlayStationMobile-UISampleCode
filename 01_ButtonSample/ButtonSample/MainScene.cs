using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace ButtonSample
{
    public partial class MainScene : Scene
    {
        public MainScene()
        {
            InitializeWidget();
			
			Button_1.ButtonAction += new EventHandler<TouchEventArgs>(ButtonExecuteAction);

        }
		
		private void ButtonExecuteAction(object sender, TouchEventArgs e)
        {
			Label_1.Text = "ボタンを押しました!!";
		}
    }
}
