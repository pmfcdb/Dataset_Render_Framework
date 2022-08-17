using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using Stride.UI.Controls;
using Stride.UI.Events;
using Stride.UI.Panels;
using Stride.UI;

namespace MyGame3
{
    public class KeyboardMenu : SyncScript
    {
        // Declared public member fields and properties will show in the game studio
        public Entity back_camera;
        public Entity ui_menu;
        private Grid menuBlock;
        private CameraComponent bcamera;

        public override void Start()
        {
            // Initialization of the script.
            var activePage = ui_menu.Get<UIComponent>().Page;
            //textBlock = activePage.RootElement.FindVisualChildOfType<TextBlock>("MyTextBlock");
            //var tutorialMenu = activePage.RootElement.FindVisualChildOfType<Grid>("MyGrid");
            menuBlock = activePage.RootElement.FindName("MyGrid") as Grid;
            //menuBlock.Visibility = Visibility.Hidden;
            
            var button = activePage.RootElement.FindVisualChildOfType<Button>("button_newgame");
            button.Click += ButtonClicked;
            
            bcamera = back_camera.Get<CameraComponent>();
        }

        private void ButtonClicked(object sender, RoutedEventArgs e)
        {
            DebugText.Print("Generate Image", new Int2(340, 500));
        }

        public override void Update()
        {
            // Do stuff every new frame
            if (Input.HasKeyboard)
            {
                // Key down is used for when a key is being held down.
                if (Input.IsKeyDown(Keys.M))
                {
                    DebugText.Print("Toggle M to show and hide the menu", new Int2(340, 500));
                    if(menuBlock.Visibility == Visibility.Visible)
                        menuBlock.Visibility = Visibility.Hidden;
                    else
                        menuBlock.Visibility = Visibility.Visible;
                }
                if (Input.IsKeyDown(Keys.G))
                {
                    DebugText.Print("Generate Image", new Int2(340, 500));                
                }
                if (Input.IsKeyDown(Keys.V))
                {
                    DebugText.Print("Change View", new Int2(340, 500));                
                    //bcamera.
                }
                if (Input.IsKeyDown(Keys.Escape))
                {
                    Log.Warning("Exit app");
                    var game = (Game)Game;
                    game.Exit();
                }

            }
        }
    }
}
