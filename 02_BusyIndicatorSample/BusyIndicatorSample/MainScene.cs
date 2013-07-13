using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace BusyIndicatorSample
{
    public partial class MainScene : Scene
    {
        public MainScene()
        {
            InitializeWidget();
			
			StartButton.ButtonAction += new EventHandler<TouchEventArgs>(StartButtonAction);
			StopButton.ButtonAction += new EventHandler<TouchEventArgs>(StopButtonAction);
        }
		
		private void StartButtonAction(object sender, TouchEventArgs e)
        {
			BusyIndicator_1.Start();
		}
		
		private void StopButtonAction(object sender, TouchEventArgs e)
        {
			BusyIndicator_1.Stop();
		}
    }
}
