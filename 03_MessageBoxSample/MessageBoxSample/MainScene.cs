using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace MessageBoxSample
{
    public partial class MainScene : Scene
    {
		private MessageDialog dialog;
        public MainScene()
        {
            InitializeWidget();

			Button_1.ButtonAction += new EventHandler<TouchEventArgs>(Button1ExecuteAction);
			Button_2.ButtonAction += new EventHandler<TouchEventArgs>(Button2ExecuteAction);
		}
		
		private void Button1ExecuteAction(object sender, TouchEventArgs e)
        {
			dialog = new MessageDialog(MessageDialogStyle.Ok, "タイトル", "メッセージ");
			/*
			【以下の様な書き方も可能】
			dialog = new MessageDialog();
			dialog.Style = MessageDialogStyle.Ok;
			dialog.Title = "タイトル";
			dialog.Message = "メッセージ";
			*/
            dialog.ButtonPressed += new EventHandler<MessageDialogButtonEventArgs>(MessageBoxButtonDownHandler);
			dialog.Show();
		}
		
		private void Button2ExecuteAction(object sender, TouchEventArgs e)
        {
			dialog = new MessageDialog(MessageDialogStyle.OkCancel, "タイトル", "メッセージ");
            dialog.ButtonPressed += new EventHandler<MessageDialogButtonEventArgs>(MessageBoxButtonDownHandler);
			dialog.Show();
		}
		
		private void MessageBoxButtonDownHandler(object sender, MessageDialogButtonEventArgs e)
		{
//			Label_1.Text = "押されたボタン : " + e.Result.ToString();
			if (e.Result == MessageDialogResult.Ok) {
				Label_1.Text = "OKボタンが押されました";
			} else if (e.Result == MessageDialogResult.Cancel) {
				Label_1.Text = "Cancelボタンが押されました";
			}
		}
    }
}
